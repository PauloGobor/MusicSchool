﻿#pragma checksum "..\..\..\View\frmCadastrarVenda.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D33BF360B720CC3B70BF6B99490C4BB9EDD648D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EscolaDeMusica.View;
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


namespace EscolaDeMusica.View {
    
    
    /// <summary>
    /// frmCadastrarVenda
    /// </summary>
    public partial class frmCadastrarVenda : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClienteCpf;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVendedorCpf;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrarVenda;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantidadeInstrumento;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbInstrumentos;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdicionarItemVenda;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtaVendas;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\frmCadastrarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotal;
        
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
            System.Uri resourceLocater = new System.Uri("/EscolaDeMusica;component/view/frmcadastrarvenda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\frmCadastrarVenda.xaml"
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
            
            #line 8 "..\..\..\View\frmCadastrarVenda.xaml"
            ((EscolaDeMusica.View.frmCadastrarVenda)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtClienteCpf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtVendedorCpf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnCadastrarVenda = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\View\frmCadastrarVenda.xaml"
            this.btnCadastrarVenda.Click += new System.Windows.RoutedEventHandler(this.btnCadastrarVenda_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\..\View\frmCadastrarVenda.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtQuantidadeInstrumento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbInstrumentos = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnAdicionarItemVenda = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\View\frmCadastrarVenda.xaml"
            this.btnAdicionarItemVenda.Click += new System.Windows.RoutedEventHandler(this.btnAdionarItemVenda);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dtaVendas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.lblTotal = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

