#pragma checksum "..\..\PageAddOrganization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50821AD71DE13C257048B10D00B7619B582C81CB0974553079DE0888B9EEAC69"
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


namespace Archive {
    
    
    /// <summary>
    /// PageAddOrganization
    /// </summary>
    public partial class PageAddOrganization : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox innTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox directorTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox opfComboBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kppTextBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ogrnTextBox;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextBox;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\PageAddOrganization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
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
            System.Uri resourceLocater = new System.Uri("/Archive;component/pageaddorganization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageAddOrganization.xaml"
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
            this.innTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\PageAddOrganization.xaml"
            this.innTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.number_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.directorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.opfComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.kppTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\PageAddOrganization.xaml"
            this.kppTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.number_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ogrnTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\PageAddOrganization.xaml"
            this.ogrnTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.number_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\PageAddOrganization.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\PageAddOrganization.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

