using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace VATCalculator.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string France = "France";
        private const string Portugal = "Portugal";
        private const string Spain = "Spain";
        private const string UK = "United Kingdom";

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Events Methods

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
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

            int i = 1;
            foreach (var value in vatValues)
            {
                spVatRate.Children.Add(new CheckBox
                {
                    Name = $"cb{cbValue}Percent{i}",
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

            foreach(var child in spVat.Children)
            {
                if(child is CheckBox cbChild && cbChild.Name != cbVat.Name)
                {
                    cbChild.IsChecked = false;
                }
            }

            cbValueAddedTax.IsChecked = true;
            tbValueAddedTax.IsEnabled = true;
        }

        private void CbPriceWithoutVAT_Checked(object sender, RoutedEventArgs e)
        {
            tbPriceWithoutVAT.IsEnabled = true;

            cbPriceIncludVAT.IsChecked= false;
            tbPriceIncludVAT.IsEnabled= false;

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

        #endregion
    }
}
