﻿#pragma checksum "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2669D6A5BCCF6B1C2AF094EC785BC8B7"
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
    /// HsbDisplay
    /// </summary>
    public partial class HsbDisplay : Imagin.Controls.Extended.ComponentSelector, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rH;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtH;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rS;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtS;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rB;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/displays/hsbdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
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
            this.rH = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
            this.rH.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtH = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 34 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
            this.txtH.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rS = ((System.Windows.Controls.RadioButton)(target));
            
            #line 45 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
            this.rS.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtS = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 57 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
            this.txtS.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 70 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
            this.rB.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtB = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 81 "..\..\..\..\ColorPicker\Displays\HsbDisplay.xaml"
            this.txtB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
