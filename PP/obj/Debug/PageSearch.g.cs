﻿#pragma checksum "..\..\PageSearch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "894197993F463A461A09A4583DE493E5CD1CF3E60AC130B14F0E6752C028667B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PP;
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


namespace PP {
    
    
    /// <summary>
    /// PageSearch
    /// </summary>
    public partial class PageSearch : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUsersList;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borederUserList;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxUsers;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox innTextBox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddOrganization;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateOrganization;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock infoOrgTextBlock;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddDocument;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\PageSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxDoc;
        
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
            System.Uri resourceLocater = new System.Uri("/PP;component/pagesearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageSearch.xaml"
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
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\PageSearch.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnUsersList = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\PageSearch.xaml"
            this.btnUsersList.Click += new System.Windows.RoutedEventHandler(this.btnUsersList_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.borederUserList = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\PageSearch.xaml"
            this.searchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.listBoxUsers = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.innTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 105 "..\..\PageSearch.xaml"
            this.innTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.innTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 109 "..\..\PageSearch.xaml"
            this.innTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.innTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnAddOrganization = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\PageSearch.xaml"
            this.btnAddOrganization.Click += new System.Windows.RoutedEventHandler(this.btnAddOrganization_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnUpdateOrganization = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\PageSearch.xaml"
            this.btnUpdateOrganization.Click += new System.Windows.RoutedEventHandler(this.btnUpdateOrganization_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.infoOrgTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.btnAddDocument = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\PageSearch.xaml"
            this.btnAddDocument.Click += new System.Windows.RoutedEventHandler(this.btnAddDocument_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.listBoxDoc = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 85 "..\..\PageSearch.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.adoptedUser_Click);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 176 "..\..\PageSearch.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 192 "..\..\PageSearch.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.editDocBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

