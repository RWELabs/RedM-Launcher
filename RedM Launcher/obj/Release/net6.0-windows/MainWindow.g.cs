﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "609C963B7EF0849D9B89EA5B8035F5641377C73C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RedM_Launcher;
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


namespace RedM_Launcher {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DetailText;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatusText;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progress;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ClearCache;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle StartRM;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ClearLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label StartRMLabel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseButtonTopRight;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RedM Launcher;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.DetailText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.StatusText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.progress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 5:
            this.ClearCache = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.ClearCache.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ClearButtonHoverOn);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.ClearCache.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ClearButtonHoverOff);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.ClearCache.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ClearButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StartRM = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.StartRM.MouseLeave += new System.Windows.Input.MouseEventHandler(this.StartButtonHoverOff);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.StartRM.MouseEnter += new System.Windows.Input.MouseEventHandler(this.StartButtonHoverOn);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.StartRM.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.StartButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ClearLabel = ((System.Windows.Controls.Label)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.ClearLabel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ClearButtonHoverOn);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.ClearLabel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ClearButtonHoverOff);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.ClearLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ClearButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.StartRMLabel = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.StartRMLabel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.StartButtonHoverOff);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.StartRMLabel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.StartButtonHoverOn);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.StartRMLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.StartButtonClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CloseButtonTopRight = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.CloseButtonTopRight.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

