﻿#pragma checksum "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC16AE7378E1EB02CFD3ED4449E2CF58"
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
    /// XyzComponentSelector
    /// </summary>
    public partial class XyzComponentSelector : Imagin.Controls.Extended.ComponentSelector, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rX;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtX;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rY;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtY;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rZ;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtZ;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/componentview/xyzcomponentselecto" +
                    "r.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
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
            this.rX = ((System.Windows.Controls.RadioButton)(target));
            
            #line 26 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
            this.rX.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtX = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 35 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
            this.txtX.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rY = ((System.Windows.Controls.RadioButton)(target));
            
            #line 45 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
            this.rY.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtY = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 55 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
            this.txtY.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rZ = ((System.Windows.Controls.RadioButton)(target));
            
            #line 65 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
            this.rZ.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtZ = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 75 "..\..\..\..\ColorPicker\ComponentView\XyzComponentSelector.xaml"
            this.txtZ.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

