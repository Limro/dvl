﻿#pragma checksum "..\..\..\Overview.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39742DBA7BF6AD97E1FEBA879D45C915"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
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
using UI.Data;


namespace UI {
    
    
    /// <summary>
    /// Overview
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class Overview : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid stationGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartEndElectionButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UI;component/overview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Overview.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.stationGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Overview.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Overview.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RemoveButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Overview.xaml"
            this.RemoveButton.Click += new System.Windows.RoutedEventHandler(this.RemoveButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StartEndElectionButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Overview.xaml"
            this.StartEndElectionButton.Click += new System.Windows.RoutedEventHandler(this.StartEndElectionButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

