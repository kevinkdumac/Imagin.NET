﻿#pragma checksum "..\..\..\(Pickers)\ColorSelector.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2B08E96676BC64828948F0C25A925BA8"
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
        
        
        #line 9 "..\..\..\(Pickers)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Extended.ColorSelector PART_ColorSelector;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\(Pickers)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PART_ColorPlane;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\(Pickers)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse PART_SelectionEllipse;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\(Pickers)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse PART_SelectionOuterEllipse;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\(Pickers)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PART_Image;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\(Pickers)\ColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PART_Slider;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\(Pickers)\ColorSelector.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/(pickers)/colorselector.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\(Pickers)\ColorSelector.xaml"
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
            
            #line 37 "..\..\..\(Pickers)\ColorSelector.xaml"
            this.PART_ColorPlane.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnPlaneMouseDown);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\(Pickers)\ColorSelector.xaml"
            this.PART_ColorPlane.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnPlaneMouseMove);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\(Pickers)\ColorSelector.xaml"
            this.PART_ColorPlane.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnPlaneMouseUp);
            
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
            
            #line 77 "..\..\..\(Pickers)\ColorSelector.xaml"
            this.PART_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSliderMouseDown);
            
            #line default
            #line hidden
            
            #line 78 "..\..\..\(Pickers)\ColorSelector.xaml"
            this.PART_Image.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnSliderMouseMove);
            
            #line default
            #line hidden
            
            #line 79 "..\..\..\(Pickers)\ColorSelector.xaml"
            this.PART_Image.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnSliderMouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PART_Slider = ((System.Windows.Controls.Slider)(target));
            
            #line 93 "..\..\..\(Pickers)\ColorSelector.xaml"
            this.PART_Slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.OnSliderChanged);
            
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

