﻿#pragma checksum "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C2AFF5107B5223A75A2696BD2709A980"
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
    public partial class RgbDisplay : Imagin.Controls.Extended.ComponentSelector, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rR;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtR;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rG;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtG;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rB;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtB;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/displays/rgbcomponentselector.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
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
            
            #line 30 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
            this.rR.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtR = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 42 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
            this.txtR.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rG = ((System.Windows.Controls.RadioButton)(target));
            
            #line 57 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
            this.rG.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtG = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 65 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
            this.txtG.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 82 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
            this.rB.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtB = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 93 "..\..\..\..\ColorPicker\Displays\RgbComponentSelector.xaml"
            this.txtB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

