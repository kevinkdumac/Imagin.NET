﻿#pragma checksum "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B3F83EE2C18751A1DDA10BD7E954980A"
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


namespace Imagin.Controls.Extended.Models {
    
    
    /// <summary>
    /// CmykDisplay
    /// </summary>
    public partial class CmykDisplay : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtC;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCUnit;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtM;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMUnit;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtY;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtYUnit;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtK;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtKUnit;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/models/cmyk/cmykdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
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
            this.txtC = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 38 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
            this.txtC.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtR_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
            this.txtC.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtM = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 59 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
            this.txtM.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtMUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtY = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 82 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
            this.txtY.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtYUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtK = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 105 "..\..\..\..\..\ColorPicker\Models\CMYK\CmykDisplay.xaml"
            this.txtK.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtKUnit = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

