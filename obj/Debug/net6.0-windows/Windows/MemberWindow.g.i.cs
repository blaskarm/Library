﻿#pragma checksum "..\..\..\..\Windows\MemberWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C7F029E089A278C819218EA4766CE9B9E7E4865E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.Windows;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace Library.Windows {
    
    
    /// <summary>
    /// MemberWindow
    /// </summary>
    public partial class MemberWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button libraryButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button favoritesButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button borrowedButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button settingsButton;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame booksFrame;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame bookInfoFrame;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame favoritesFrame;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame borrowedFrame;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Windows\MemberWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame settingsFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library;component/windows/memberwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\MemberWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.logoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Windows\MemberWindow.xaml"
            this.logoutButton.Click += new System.Windows.RoutedEventHandler(this.logoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.libraryButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Windows\MemberWindow.xaml"
            this.libraryButton.Click += new System.Windows.RoutedEventHandler(this.libraryButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.favoritesButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Windows\MemberWindow.xaml"
            this.favoritesButton.Click += new System.Windows.RoutedEventHandler(this.favoritesButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.borrowedButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Windows\MemberWindow.xaml"
            this.borrowedButton.Click += new System.Windows.RoutedEventHandler(this.borrowedButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.settingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\Windows\MemberWindow.xaml"
            this.settingsButton.Click += new System.Windows.RoutedEventHandler(this.settingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.booksFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 8:
            this.bookInfoFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 9:
            this.favoritesFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 10:
            this.borrowedFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 11:
            this.settingsFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

