﻿#pragma checksum "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "13BFFED4260D0EE698B772248DF80BA8"
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
    /// LabDisplay
    /// </summary>
    public partial class LabDisplay : Imagin.Controls.Extended.ComponentSelector, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rL;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtL;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rA;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtA;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rB;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/displays/labdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
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
            
            #line 24 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
            this.rL.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtL = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 36 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
            this.txtL.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rA = ((System.Windows.Controls.RadioButton)(target));
            
            #line 43 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
            this.rA.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtA = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 56 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
            this.txtA.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 64 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
            this.rB.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtB = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 76 "..\..\..\..\ColorPicker\Displays\LabDisplay.xaml"
            this.txtB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

