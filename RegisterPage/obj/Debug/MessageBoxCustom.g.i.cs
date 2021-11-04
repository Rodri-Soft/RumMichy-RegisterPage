﻿#pragma checksum "..\..\MessageBoxCustom.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7D78B9DEF40C63016D2951D5BCB0B5BFC9A4EB4C87C211A80049E87CF0FDADE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using RegisterPage.Properties.Langs;
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


namespace RegisterPage {
    
    
    /// <summary>
    /// MessageBoxCustom
    /// </summary>
    public partial class MessageBoxCustom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTitle;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageMichyOk;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageInvalidMichy;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageWaitMichy;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxMessage;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxConfirmationCode;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOk;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSubmit;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAccept;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MessageBoxCustom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/RegisterPage;component/messageboxcustom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MessageBoxCustom.xaml"
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
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MessageBoxCustom.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.imageMichyOk = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.imageInvalidMichy = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.imageWaitMichy = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.textBoxMessage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textBoxConfirmationCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.buttonOk = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\MessageBoxCustom.xaml"
            this.buttonOk.Click += new System.Windows.RoutedEventHandler(this.ButtonOk_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\MessageBoxCustom.xaml"
            this.buttonSubmit.Click += new System.Windows.RoutedEventHandler(this.ButtonSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonAccept = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\MessageBoxCustom.xaml"
            this.buttonAccept.Click += new System.Windows.RoutedEventHandler(this.ButtonAccept_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\MessageBoxCustom.xaml"
            this.buttonCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
