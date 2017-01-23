﻿#pragma checksum "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F8A376AA1286989B134ACAFAD479E71D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Imagin.Common.Data.Converters;
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
    /// ColorSelector
    /// </summary>
    public partial class ColorSelector : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Extended.ColorSelector PART_ColorSelector;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PART_ColorPlane;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse PART_SelectionEllipse;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse PART_SelectionOuterEllipse;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PART_Image;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PART_Slider;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Extended.AlphaSlider PART_AlphaSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/(pickers)/colorpicker/(components)/colorselec" +
                    "tor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.PART_ColorSelector = ((Imagin.Controls.Extended.ColorSelector)(target));
            return;
            case 2:
            this.PART_ColorPlane = ((System.Windows.Controls.Image)(target));
            
            #line 42 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
            this.PART_ColorPlane.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnColorPlaneMouseMove);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
            this.PART_ColorPlane.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnColorPlaneMouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PART_SelectionEllipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 4:
            this.PART_SelectionOuterEllipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            this.PART_Image = ((System.Windows.Controls.Image)(target));
            
            #line 76 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
            this.PART_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnColorSliderMouseDown);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
            this.PART_Image.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnColorSliderMouseMove);
            
            #line default
            #line hidden
            
            #line 78 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
            this.PART_Image.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnColorSliderMouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PART_Slider = ((System.Windows.Controls.Slider)(target));
            
            #line 92 "..\..\..\..\..\(Pickers)\ColorPicker\(Components)\ColorSelector.xaml"
            this.PART_Slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.OnColorSliderValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PART_AlphaSlider = ((Imagin.Controls.Extended.AlphaSlider)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

