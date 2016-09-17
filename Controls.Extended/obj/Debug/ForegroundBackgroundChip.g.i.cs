﻿#pragma checksum "..\..\ForegroundBackgroundChip.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07C3A352C3ECF890F1F03B95F5878075"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// ForegroundBackgroundChip
    /// </summary>
    public partial class ForegroundBackgroundChip : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\ForegroundBackgroundChip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Extended.ColorChip backChip;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ForegroundBackgroundChip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Extended.ColorChip foreChip;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ForegroundBackgroundChip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rBackgroundDefault;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ForegroundBackgroundChip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rForegroundDefault;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ForegroundBackgroundChip.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rSwitch;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/foregroundbackgroundchip.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ForegroundBackgroundChip.xaml"
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
            this.backChip = ((Imagin.Controls.Extended.ColorChip)(target));
            return;
            case 2:
            this.foreChip = ((Imagin.Controls.Extended.ColorChip)(target));
            return;
            case 3:
            this.rBackgroundDefault = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 40 "..\..\ForegroundBackgroundChip.xaml"
            this.rBackgroundDefault.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.rBackgroundDefault_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rForegroundDefault = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 41 "..\..\ForegroundBackgroundChip.xaml"
            this.rForegroundDefault.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.rForegroundDefault_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rSwitch = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 42 "..\..\ForegroundBackgroundChip.xaml"
            this.rSwitch.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.rSwitch_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

