﻿#pragma checksum "..\..\Luxury_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B9916FC4FD048B3F1540F4242077A68AF459CC22BD8CE56DECA817FE704C70B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using kurss;


namespace kurss {
    
    
    /// <summary>
    /// Luxury_Window
    /// </summary>
    public partial class Luxury_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Luxury_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Luxury_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GeoBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Luxury_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Luxury_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServiceBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Luxury_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RatingBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Luxury_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OutBTN;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Luxury_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddHotel;
        
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
            System.Uri resourceLocater = new System.Uri("/kurss;component/luxury_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Luxury_Window.xaml"
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
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.GeoBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RoomBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ServiceBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RatingBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.OutBTN = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Luxury_Window.xaml"
            this.OutBTN.Click += new System.Windows.RoutedEventHandler(this.OutBTN_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddHotel = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Luxury_Window.xaml"
            this.AddHotel.Click += new System.Windows.RoutedEventHandler(this.AddHotel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

