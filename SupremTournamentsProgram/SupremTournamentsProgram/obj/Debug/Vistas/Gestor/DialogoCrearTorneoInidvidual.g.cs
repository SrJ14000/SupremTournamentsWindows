﻿#pragma checksum "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3247E383FE26B42FE20EA31539C479D68C2F651344D3942FE9D7F625D5928B4"
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
using SupremTournamentsProgram.Convertidores;
using SupremTournamentsProgram.Vistas.Gestor;
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


namespace SupremTournamentsProgram.Vistas.Gestor {
    
    
    /// <summary>
    /// DialogoCrearTorneoInidvidual
    /// </summary>
    public partial class DialogoCrearTorneoInidvidual : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NombreTorneoTextbox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescripcionCortaTextBox;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescripcionCompletaTextBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.RatingBar CustomRatingBar;
        
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
            System.Uri resourceLocater = new System.Uri("/SupremTournamentsProgram;component/vistas/gestor/dialogocreartorneoinidvidual.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
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
            
            #line 46 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NombreTorneoTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DescripcionCortaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DescripcionCompletaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CustomRatingBar = ((MaterialDesignThemes.Wpf.RatingBar)(target));
            
            #line 80 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
            this.CustomRatingBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.CustomRatingBar_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 120 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 121 "..\..\..\..\Vistas\Gestor\DialogoCrearTorneoInidvidual.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cacelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
