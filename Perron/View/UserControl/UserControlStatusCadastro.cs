using System;
using System.Windows.Forms;

namespace Perron
{
    public partial class UserControlStatusCadastro : UserControl
    {
        public bool Ativo
        {
            get
            {
                return ckAtivo.Checked;

            }
            set
            {
                ckAtivo.Checked = value;
            }
        }
        public bool Inativo
        {
            get
            {
                return ckInativo.Checked;

            }
            set
            {
                ckInativo.Checked = value;
            }
        }


        public UserControlStatusCadastro()
        {
            InitializeComponent();
        }

        public void RemoverCeck()
        {
            ckInativo.Checked = false;
            ckAtivo.Checked = false;

        }

        public void EventockAtivo(EventHandler e)
        {
            ckAtivo.CheckedChanged += e;
        }
        public void EventockInativo(EventHandler e)
        {
            ckInativo.CheckedChanged += e;
        }



    }
}

