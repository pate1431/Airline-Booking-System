﻿#pragma checksum "..\..\..\Flight_Page.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "831BE3148060C8EADA29F9766696BF5C15C0BC52"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Midterm;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Midterm {
    
    
    /// <summary>
    /// Flight_Page
    /// </summary>
    public partial class Flight_Page : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox flightbox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delbtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editbtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idbox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox airbox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox deptbox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox estbox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timebox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox airbox_Copy;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Flight_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox datebox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Midterm;V1.0.0.0;component/flight_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Flight_Page.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.flightbox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Flight_Page.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.delbtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Flight_Page.xaml"
            this.delbtn.Click += new System.Windows.RoutedEventHandler(this.delbtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.editbtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Flight_Page.xaml"
            this.editbtn.Click += new System.Windows.RoutedEventHandler(this.editbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Flight_Page.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.idbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.airbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.deptbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.estbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.timebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.airbox_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.datebox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
