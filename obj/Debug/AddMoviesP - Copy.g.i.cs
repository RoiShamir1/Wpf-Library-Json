#pragma checksum "..\..\AddMoviesP - Copy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9CB6991C921C547B459CD9B2D22A429511C1DB73B525DE5EA6E6E60DA0BC9DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FinalManager;
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


namespace FinalManager {
    
    
    /// <summary>
    /// AddMoviesP
    /// </summary>
    public partial class AddMoviesP : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox movieName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox moviePrice;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox movieGener;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox movieDescription;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox movieDiscount;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox movieStock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMovie;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackMain;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddMoviesP - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalManager;component/addmoviesp%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddMoviesP - Copy.xaml"
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
            this.movieName = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\AddMoviesP - Copy.xaml"
            this.movieName.GotFocus += new System.Windows.RoutedEventHandler(this.movieName_GotFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\AddMoviesP - Copy.xaml"
            this.movieName.LostFocus += new System.Windows.RoutedEventHandler(this.movieName_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.moviePrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\AddMoviesP - Copy.xaml"
            this.moviePrice.GotFocus += new System.Windows.RoutedEventHandler(this.moviePrice_GotFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\AddMoviesP - Copy.xaml"
            this.moviePrice.LostFocus += new System.Windows.RoutedEventHandler(this.moviePrice_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.movieGener = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.movieDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\AddMoviesP - Copy.xaml"
            this.movieDescription.GotFocus += new System.Windows.RoutedEventHandler(this.movieDescription_GotFocus);
            
            #line default
            #line hidden
            
            #line 15 "..\..\AddMoviesP - Copy.xaml"
            this.movieDescription.LostFocus += new System.Windows.RoutedEventHandler(this.movieDescription_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.movieDiscount = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\AddMoviesP - Copy.xaml"
            this.movieDiscount.GotFocus += new System.Windows.RoutedEventHandler(this.movieDiscount_GotFocus);
            
            #line default
            #line hidden
            
            #line 16 "..\..\AddMoviesP - Copy.xaml"
            this.movieDiscount.LostFocus += new System.Windows.RoutedEventHandler(this.movieDiscount_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.movieStock = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\AddMoviesP - Copy.xaml"
            this.movieStock.GotFocus += new System.Windows.RoutedEventHandler(this.movieStock_GotFocus);
            
            #line default
            #line hidden
            
            #line 17 "..\..\AddMoviesP - Copy.xaml"
            this.movieStock.LostFocus += new System.Windows.RoutedEventHandler(this.movieStock_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddMovie = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\AddMoviesP - Copy.xaml"
            this.AddMovie.Click += new System.Windows.RoutedEventHandler(this.AddMovie_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BackMain = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AddMoviesP - Copy.xaml"
            this.BackMain.Click += new System.Windows.RoutedEventHandler(this.BackMain_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AddMoviesP - Copy.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

