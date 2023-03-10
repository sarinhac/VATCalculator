#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0D9FBAAD8F6C7ED1EC0E0A6D712AA254F48744BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using VATCalculator.UI;


namespace VATCalculator.UI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCountry;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spVatRate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbPriceWithoutVAT;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPriceWithoutVAT;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbValueAddedTax;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbValueAddedTax;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbPriceIncludVAT;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPriceIncludVAT;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VATCalculator.UI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cbCountry = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.cbCountry.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbCountry_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.spVatRate = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.cbPriceWithoutVAT = ((System.Windows.Controls.CheckBox)(target));
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.cbPriceWithoutVAT.Checked += new System.Windows.RoutedEventHandler(this.CbPriceWithoutVAT_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbPriceWithoutVAT = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.tbPriceWithoutVAT.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.tbPriceWithoutVAT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbValueAddedTax_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbValueAddedTax = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\..\MainWindow.xaml"
            this.cbValueAddedTax.Checked += new System.Windows.RoutedEventHandler(this.CbValueAddedTax_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbValueAddedTax = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\MainWindow.xaml"
            this.tbValueAddedTax.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\MainWindow.xaml"
            this.tbValueAddedTax.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbValueAddedTax_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbPriceIncludVAT = ((System.Windows.Controls.CheckBox)(target));
            
            #line 71 "..\..\..\MainWindow.xaml"
            this.cbPriceIncludVAT.Checked += new System.Windows.RoutedEventHandler(this.CbPriceIncludVAT_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbPriceIncludVAT = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\MainWindow.xaml"
            this.tbPriceIncludVAT.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 78 "..\..\..\MainWindow.xaml"
            this.tbPriceIncludVAT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbValueAddedTax_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

