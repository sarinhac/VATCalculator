using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VATCalculator.Logic.Models;

namespace VATCalculator.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Const

        private const string France = "France";
        private const string Portugal = "Portugal";
        private const string Spain = "Spain";
        private const string UK = "United Kingdom";

        private const string GrossAmout = "tbPriceIncludVAT";
        private const string VATAmount = "tbValueAddedTax";
        private const string NetAmount = "tbPriceWithoutVAT";

        #endregion

        private decimal _taxValue = 0.0M;
        private Double[] _taxValues = Array.Empty<double>();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Events Methods

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{1,5}([,\\.][0-9]{0,2})?$");

            e.Handled = !regex.IsMatch((sender as TextBox)
                    .Text.Insert((sender as TextBox)
                    .SelectionStart,
                e.Text));
        }

        private void CbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string cbValue = (string)((ComboBoxItem)((ComboBox)(FrameworkElement)sender)
                                                        .SelectedValue)
                                                  .Content;

            var vatValues = GetVatRatesFromCountry(cbValue);
            _taxValues = vatValues.ToArray();

            int i = 1;
            spVatRate.Children.Clear();

            foreach (var value in vatValues)
            {
                spVatRate.Children.Add(new CheckBox
                {
                    Name = $"cb{cbValue.Trim()}Percent{i}",
                    VerticalAlignment = VerticalAlignment.Center,
                    Margin = new Thickness(5, 0, 0, 0),
                });
                spVatRate.Children.Add(new TextBlock
                {
                    Text = $"{value}%",
                    VerticalAlignment = VerticalAlignment.Center,
                    Margin = new Thickness(2, 0, 0, 0),
                });

                i++;
            }

            foreach (var item in spVatRate.Children)
            {
                if (item is CheckBox itemCheckBox)
                {
                    itemCheckBox.Checked += new RoutedEventHandler(CheckBoxVAT_Checked);
                }
            }
        }

        private void CheckBoxVAT_Checked(object sender, RoutedEventArgs e)
        {
            var cbVat = (CheckBox)(FrameworkElement)sender;
            var spVat = (StackPanel)cbVat.Parent;

            foreach (var child in spVat.Children)
            {
                if (child is CheckBox cbChild && cbChild.Name != cbVat.Name)
                {
                    cbChild.IsChecked = false;
                }
            }

            int index = Convert.ToInt16(cbVat.Name.Last().ToString());
            _taxValue = Convert.ToDecimal(_taxValues[index-1]);
            
            cbPriceWithoutVAT.IsChecked = true;
            
            tbPriceWithoutVAT.Text = string.Empty;
            tbValueAddedTax.Text = string.Empty;
            tbPriceIncludVAT.Text = string.Empty;
        }

        private void CbPriceWithoutVAT_Checked(object sender, RoutedEventArgs e)
        {
            tbPriceWithoutVAT.IsEnabled = true;

            cbPriceIncludVAT.IsChecked = false;
            tbPriceIncludVAT.IsEnabled = false;

            cbValueAddedTax.IsChecked = false;
            tbValueAddedTax.IsEnabled = false;
        }

        private void CbValueAddedTax_Checked(object sender, RoutedEventArgs e)
        {
            tbValueAddedTax.IsEnabled = true;

            cbPriceIncludVAT.IsChecked = false;
            tbPriceIncludVAT.IsEnabled = false;

            cbPriceWithoutVAT.IsChecked = false;
            tbPriceWithoutVAT.IsEnabled = false;
        }

        private void CbPriceIncludVAT_Checked(object sender, RoutedEventArgs e)
        {
            tbPriceIncludVAT.IsEnabled = true;

            cbValueAddedTax.IsChecked = false;
            tbValueAddedTax.IsEnabled = false;

            cbPriceWithoutVAT.IsChecked = false;
            tbPriceWithoutVAT.IsEnabled = false;
        }

        private void TbValueAddedTax_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox)(FrameworkElement)sender;
            if (textbox.IsEnabled == false)
                return;
            else if (String.IsNullOrEmpty(textbox.Text) || textbox.Text == "0")
                return;
            else if(textbox.Text.Last().ToString() == "," || textbox.Text.Last().ToString() == ".")
                return;

            if (textbox.Text.Contains("."))
                textbox.Text = textbox.Text.Replace(".", ",");

            var calculatorInfo = FillValue((TextBox)(FrameworkElement)sender);

            tbPriceIncludVAT.Text = String.Format("{0:0.##}", calculatorInfo.GrossAmount);
            tbPriceWithoutVAT.Text = String.Format("{0:0.##}", calculatorInfo.NetAmount);
            tbValueAddedTax.Text = String.Format("{0:0.##}", calculatorInfo.VATAmount);
            textbox.SelectionStart = textbox.Text.Length;
        }


        #endregion

        #region Helpers Methods

        private IEnumerable<double> GetVatRatesFromCountry(string country)
        {
            return country switch
            {
                France => new double[] { 5.5, 20, 10 },
                Portugal => new double[] { 6, 13, 23 },
                Spain => new double[] { 21, 10 },
                UK => new double[] { 5, 20 },
                _ => Enumerable.Empty<double>(),
            };
        }

        private VATCalculatorInfo FillValue(TextBox textBox)
        {
            var tbName = textBox.Name;

            VATCalculatorInfo calculatorInfo = new VATCalculatorInfo()
            {
                Tax = _taxValue
            };

            switch (tbName)
            {
                case GrossAmout:
                    calculatorInfo.GrossAmount = Convert.ToDecimal(textBox.Text);
                    break;
                case VATAmount:
                    calculatorInfo.VATAmount = Convert.ToDecimal(textBox.Text);
                    break;
                case NetAmount:
                    calculatorInfo.NetAmount = Convert.ToDecimal(textBox.Text);
                    break;
            };

            calculatorInfo.FillInfo();
            return calculatorInfo;

        }

        #endregion

    }
}
