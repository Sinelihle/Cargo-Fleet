#pragma checksum "..\..\ServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2D08848726B58EB42463D19AD226614100D7B05EEE417DDDF7B0EAEF5C46D49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cargo_Fleet_Tracking_System;
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


namespace Cargo_Fleet_Tracking_System {
    
    
    /// <summary>
    /// ServicePage
    /// </summary>
    public partial class ServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dailyBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button weeklyBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVehicleNo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtService;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCode;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid weeklyGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker appointDate;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dailyGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateDaily;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserID;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateWeekly;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Cargo-Fleet-Tracking-System;component/servicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ServicePage.xaml"
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
            this.dailyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ServicePage.xaml"
            this.dailyBtn.Click += new System.Windows.RoutedEventHandler(this.dailyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.weeklyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ServicePage.xaml"
            this.weeklyBtn.Click += new System.Windows.RoutedEventHandler(this.weeklyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtVehicleNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.weeklyGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.appointDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.dailyGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 28 "..\..\ServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnUpdateDaily = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ServicePage.xaml"
            this.btnUpdateDaily.Click += new System.Windows.RoutedEventHandler(this.btnUpdateDaily_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtUserID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.btnUpdateWeekly = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ServicePage.xaml"
            this.btnUpdateWeekly.Click += new System.Windows.RoutedEventHandler(this.btnUpdateWeekly_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.refreshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\ServicePage.xaml"
            this.refreshBtn.Click += new System.Windows.RoutedEventHandler(this.refreshBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

