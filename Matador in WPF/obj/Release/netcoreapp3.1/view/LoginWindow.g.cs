﻿#pragma checksum "..\..\..\..\view\LoginWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948EDF805A78AE49E74051B4C8EA2EF0D09C47DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace Matador_in_WPF.view {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridLogin;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HeadlineLogin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UsernameText;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PasswordText;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxUsername;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\view\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Matador in WPF;component/view/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\view\LoginWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GridLogin = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.HeadlineLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.UsernameText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.PasswordText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TextBoxUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\view\LoginWindow.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RegisterButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\view\LoginWindow.xaml"
            this.RegisterButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\view\LoginWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

