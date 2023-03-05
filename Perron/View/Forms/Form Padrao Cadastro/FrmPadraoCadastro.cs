using System;
using System.Windows.Forms;

namespace Perron.View.Forms.Form_Padrao_Cadastro
{
    public partial class FrmPadraoCadastro : Form, IViewPadraoCadastro
    {
        public FrmPadraoCadastro()
        {
            InitializeComponent();
        }

        public bool VisibilidadeBotaoSalvar
        {
            set { btnSalvar.Visible = value; }
        }
        public bool VisibilidadeBotaoNovo
        {
            set { btnNovo.Visible = value; }
        }
        public bool VisibilidadeBotaoDeletar
        {
            set { btnRemover.Visible = value; }
        }
        public bool VisibilidadeBotaoCancelar
        {
            set { btnCancelar.Visible = value; }
        }

        public void EventoCancelar(EventHandler e)
        {
            btnCancelar.Click += e;
        }

        public void EventoDeletar(EventHandler e)
        {
            btnRemover.Click += e;
        }

        public void EventoFecharForms(FormClosedEventHandler e)
        {
            FormClosed += e;
        }

        public void EventoNovo(EventHandler e)
        {
            btnNovo.Click += e;
        }

        public void EventoSalvar(EventHandler e)
        {
            btnSalvar.Click += e;
        }
    }
}
