﻿#pragma checksum "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA869CD5A450CFBCD480D331298277F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Imagin.Common;
using Imagin.Controls.Common;
using Imagin.Controls.Extended;
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


namespace Imagin.Controls.Extended {
    
    
    /// <summary>
    /// RgbDisplay
    /// </summary>
    public partial class RgbDisplay : Imagin.Controls.Extended.NormalizedColorSpacePicker, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rR;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtR;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtRUnit;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rG;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtG;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtGUnit;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rB;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtB;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBUnit;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/pickers/rgbdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
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
            this.rR = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
            this.rR.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtR = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 33 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
            this.txtR.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtRUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.rG = ((System.Windows.Controls.RadioButton)(target));
            
            #line 47 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
            this.rG.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtG = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 54 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
            this.txtG.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtGUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.rB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 70 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
            this.rB.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtB = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 80 "..\..\..\..\ColorPicker\Pickers\RgbDisplay.xaml"
            this.txtB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtBUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

