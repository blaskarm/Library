﻿#pragma checksum "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34200AC93A1AD5778F374DE2C4C710958E581C15"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.Pages.MemberPages;
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


namespace Library.Pages.MemberPages {
    
    
    /// <summary>
    /// BookInfoPage
    /// </summary>
    public partial class BookInfoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button favoriteButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock addedToFavText;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button borrowButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/pages/memberpages/bookinfopage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
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
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.favoriteButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
            this.favoriteButton.Click += new System.Windows.RoutedEventHandler(this.favoriteButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addedToFavText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.borrowButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
            this.borrowButton.Click += new System.Windows.RoutedEventHandler(this.borrowButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.returnButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\..\Pages\MemberPages\BookInfoPage.xaml"
            this.returnButton.Click += new System.Windows.RoutedEventHandler(this.returnButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

