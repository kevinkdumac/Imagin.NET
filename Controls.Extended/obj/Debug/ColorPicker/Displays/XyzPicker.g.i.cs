﻿#pragma checksum "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7283D0937588741E851FBDE6F473B45C"
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
    /// XyzDisplay
    /// </summary>
    public partial class XyzDisplay : Imagin.Controls.Extended.NormalizedComponentDisplay, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rX;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtX;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rY;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtY;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rZ;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/displays/xyzpicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
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
            
            #line 25 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
            this.rX.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtX = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 34 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
            this.txtX.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rY = ((System.Windows.Controls.RadioButton)(target));
            
            #line 43 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
            this.rY.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtY = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 53 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
            this.txtY.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rZ = ((System.Windows.Controls.RadioButton)(target));
            
            #line 62 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
            this.rZ.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtZ = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 72 "..\..\..\..\ColorPicker\Displays\XyzPicker.xaml"
            this.txtZ.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

