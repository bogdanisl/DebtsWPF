﻿#pragma checksum "..\..\Converter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8A81481D041F5B0E3E089E59704E185C3AE39343A1F4BC531194A7C143EECE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Debts;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Syncfusion;
using Syncfusion.Windows;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Debts {
    
    
    /// <summary>
    /// Converter
    /// </summary>
    public partial class Converter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel TopPanel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run usd;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run eur;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run rub;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedCurrency;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.UpDown upDownUAH;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.UpDown upDownUSD;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.UpDown upDownEUR;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.UpDown upDownRUB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Debts;component/converter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Converter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TopPanel = ((System.Windows.Controls.DockPanel)(target));
            
            #line 15 "..\..\Converter.xaml"
            this.TopPanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TopPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Converter.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.usd = ((System.Windows.Documents.Run)(target));
            return;
            case 4:
            this.eur = ((System.Windows.Documents.Run)(target));
            return;
            case 5:
            this.rub = ((System.Windows.Documents.Run)(target));
            return;
            case 6:
            this.SelectedCurrency = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\Converter.xaml"
            this.SelectedCurrency.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectedCurrency_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.upDownUAH = ((Syncfusion.Windows.Shared.UpDown)(target));
            
            #line 38 "..\..\Converter.xaml"
            this.upDownUAH.ValueChanged += new System.Windows.PropertyChangedCallback(this.upDownUAH_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.upDownUSD = ((Syncfusion.Windows.Shared.UpDown)(target));
            
            #line 41 "..\..\Converter.xaml"
            this.upDownUSD.ValueChanged += new System.Windows.PropertyChangedCallback(this.upDownUSD_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.upDownEUR = ((Syncfusion.Windows.Shared.UpDown)(target));
            
            #line 44 "..\..\Converter.xaml"
            this.upDownEUR.ValueChanged += new System.Windows.PropertyChangedCallback(this.upDownEUR_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.upDownRUB = ((Syncfusion.Windows.Shared.UpDown)(target));
            
            #line 47 "..\..\Converter.xaml"
            this.upDownRUB.ValueChanged += new System.Windows.PropertyChangedCallback(this.upDownRUB_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

