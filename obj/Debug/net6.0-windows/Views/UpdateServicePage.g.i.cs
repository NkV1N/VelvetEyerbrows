﻿#pragma checksum "..\..\..\..\Views\UpdateServicePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7E33C65D358621425DB09B690FBDE1C2B096065D"
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
using VelvetEyrbrown.Views;


namespace VelvetEyrbrown.Views {
    
    
    /// <summary>
    /// UpdateServicePage
    /// </summary>
    public partial class UpdateServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label headerLabel;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text2;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo1;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\UpdateServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VelvetEyrbrown;component/views/updateservicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\UpdateServicePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.headerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 26 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.updateImage);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 41 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addServicePhoto);
            
            #line default
            #line hidden
            return;
            case 4:
            this.text1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.text2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.combo1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.combo2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 93 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveChanges);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 94 "..\..\..\..\Views\UpdateServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

