﻿#pragma checksum "..\..\CreationQuizz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "437C73B8B74752F7E9674F3A2D9227D35872351683D50261A34DE056A0F9D593"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using IHM;
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


namespace IHM {
    
    
    /// <summary>
    /// CreationQuizz
    /// </summary>
    public partial class CreationQuizz : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\CreationQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LBCat;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CreationQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LBQuizz;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\CreationQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddCat;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\CreationQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemoveCat;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\CreationQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddQuizz;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CreationQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemoveQuizz;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\CreationQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageLogo;
        
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
            System.Uri resourceLocater = new System.Uri("/IHM;component/creationquizz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreationQuizz.xaml"
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
            this.LBCat = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.LBQuizz = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.ButtonAddCat = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\CreationQuizz.xaml"
            this.ButtonAddCat.Click += new System.Windows.RoutedEventHandler(this.AjCategorie);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonRemoveCat = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.ButtonAddQuizz = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.ButtonRemoveQuizz = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.ImageLogo = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

