﻿#pragma checksum "..\..\..\Sensor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "479BBF86D2E785728598CCD0A74C9C8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Configuration_Utility {
    
    
    /// <summary>
    /// Sensor
    /// </summary>
    public partial class Sensor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tuio_port;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox invert_horizontal;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox invert_verticle;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox x_offset;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox y_offset;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox debug;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stack;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CanvasBorder;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas VisualFeedback;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label service_status;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Sensor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button service;
        
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
            System.Uri resourceLocater = new System.Uri("/Configuration_Utility;component/sensor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Sensor.xaml"
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
            
            #line 7 "..\..\..\Sensor.xaml"
            ((Configuration_Utility.Sensor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tuio_port = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Sensor.xaml"
            this.tuio_port.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tuio_port_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.invert_horizontal = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\..\Sensor.xaml"
            this.invert_horizontal.Click += new System.Windows.RoutedEventHandler(this.invert_horizontal_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.invert_verticle = ((System.Windows.Controls.CheckBox)(target));
            
            #line 28 "..\..\..\Sensor.xaml"
            this.invert_verticle.Click += new System.Windows.RoutedEventHandler(this.invert_verticle_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.x_offset = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Sensor.xaml"
            this.x_offset.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.x_offset_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.y_offset = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\Sensor.xaml"
            this.y_offset.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.y_offset_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.debug = ((System.Windows.Controls.CheckBox)(target));
            
            #line 45 "..\..\..\Sensor.xaml"
            this.debug.Click += new System.Windows.RoutedEventHandler(this.debug_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.CanvasBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 11:
            this.VisualFeedback = ((System.Windows.Controls.Canvas)(target));
            return;
            case 12:
            this.service_status = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.service = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

