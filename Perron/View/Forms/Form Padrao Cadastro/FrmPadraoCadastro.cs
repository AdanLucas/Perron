﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Perron.View.Forms.Form_Padrao_Cadastro
{
    public partial class FrmPadraoCadastro : Form, IViewPadraoCadastro
    {
        protected virtual Size TamanhoTelaReduzida { get { return this.Size; } }
        protected virtual Size TamanhoTelaCheia { get { return this.Size; } }
        public FrmPadraoCadastro()
        {
            InitializeComponent();
            ConfigurarImagemBotao();
            
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
        public bool VisualizarCadastrosAtivo
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
        public bool VisualizarCadastrosInativos
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
        public bool SetarVisiblidadeCKStatus
        {
            set
            {
                SetarVisibilidaCkStatus(value);
            }
        }
        public bool VisibilidadeckAtivo { set { ckAtivo.Enabled = value; } }
        public bool VisibilidadeckInativo { set { ckInativo.Enabled = value; } }

        public Size TamanhoTela { set => this.Size = value; }

        public void RemoverCheck()
        {
            ckInativo.Checked = false;
            ckAtivo.Checked = false;
        }
        public void EventockAtivo(EventHandler e)
        {
            ckAtivo.CheckStateChanged += e;
        }
        public void EventockInativo(EventHandler e)
        {
            ckInativo.CheckStateChanged += e;
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
        private void ConfigurarImagemBotao()
        {
            btnNovo.Image = Properties.Resources.BotaoAdd;
            btnSalvar.Image = Properties.Resources.BotaoOk;
            btnCancelar.Image = Properties.Resources.BotaoCancel;
            btnRemover.Image = Properties.Resources.BotaoRemover;
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemover.BackgroundImageLayout = ImageLayout.Zoom;
            btnNovo.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalvar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void SetarVisibilidaCkStatus(bool status)
        {
            ckAtivo.Visible = status;
            ckInativo.Visible = status;
        }
        public void SetarTamanhoDaTelaReduzido()
        {
            this.Size = TamanhoTelaReduzida;
        }
        public void SetarTamanhoMaximoTela()
        {
            this.Size = this.TamanhoTelaCheia;
        }

    }
}
