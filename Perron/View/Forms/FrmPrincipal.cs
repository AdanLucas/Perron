﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmPrincipal : Form, IViewPrincipal
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void EventoAbrirtelaCadastroClasse(EventHandler e)
        {
            this.menuItemClasse.Click += e;
        }

        public void EventoAbrirTelaCadastroSabor(EventHandler e)
        {
            menuItemSabor.Click += e;
        }

        public void EventoAbrirtelaCadastroTAmanho(EventHandler e)
        {
            menuItemTamanho.Click += e;
        }

        public void EventoAbrirTelaIngredientes(EventHandler e)
        {
            menuItemIngrediente.Click += e;
        }

        public void EventoFechar(FormClosedEventHandler e)
        {
            FormClosed += e;
        }
    }
}
