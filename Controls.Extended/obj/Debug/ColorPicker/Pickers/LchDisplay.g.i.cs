﻿#pragma checksum "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B41EB588A7004D580ABAA6F2FF5E4DBC"
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
    /// LchDisplay
    /// </summary>
    public partial class LchDisplay : Imagin.Controls.Extended.NormalizedColorSpacePicker, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rL;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtL;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rC;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtC;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rH;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtH;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/pickers/lchdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
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
            this.rL = ((System.Windows.Controls.RadioButton)(target));
            
            #line 24 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
            this.rL.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtL = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 35 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
            this.txtL.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rC = ((System.Windows.Controls.RadioButton)(target));
            
            #line 48 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
            this.rC.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtC = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 59 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
            this.txtC.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rH = ((System.Windows.Controls.RadioButton)(target));
            
            #line 73 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
            this.rH.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtH = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 85 "..\..\..\..\ColorPicker\Pickers\LchDisplay.xaml"
            this.txtH.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

