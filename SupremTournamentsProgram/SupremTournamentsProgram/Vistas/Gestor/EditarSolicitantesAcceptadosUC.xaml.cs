﻿using SupremTournamentsProgram.VM.GestorVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SupremTournamentsProgram.Vistas.Gestor
{
    /// <summary>
    /// Lógica de interacción para EditarSolicitantesAcceptadosUC.xaml
    /// </summary>
    public partial class EditarSolicitantesAcceptadosUC : UserControl
    {
        EditarSolicitantesAcceptadosUCVM vm; 
        public EditarSolicitantesAcceptadosUC()
        {
            vm = new EditarSolicitantesAcceptadosUCVM();
            this.DataContext = vm;
            InitializeComponent();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.AbrirDialogoImagen();
        }
    }
}