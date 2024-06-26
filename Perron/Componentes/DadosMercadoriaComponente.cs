﻿using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Componentes
{
    

    public partial class DadosMercadoriaComponente : UserControl
    {
        public Action AtualiarTela { get; set; }
        public IngredienteModel Ingrediente { get; set; }
        public EventHandler EventoAdicionarDadosIngrediente { get; set; }
        public EventHandler EventoRemoverIngrediente { get; set; }
        public EventHandler EventoRemoverDadosIngrediente { get; set; }

        public DadosMercadoriaComponente(IngredienteModel ingrediente)
        {
            InitializeComponent();
            Ingrediente = ingrediente;
            ConfigurarDataGridView();
            SetarDadosTela();
            DelegarEventos();
            
        }

        #region Privados
        private void DelegarEventos()
        {
            this.menuAdicionarDados.Click += AdicionarDados;
            this.menuRemover.Click += RemoverIngrediente;
            this.menuRemoverDados.Click += RemoverDados;
            AtualiarTela += AtulizarDados;
            this.dgvDadosIngrediente.DoubleClick += AdicionadoValordadosIngrediente;
        }
        private void SetarDadosTela()
        {
            if (Ingrediente != null)
            {
                this.txtDescricao.Text = Ingrediente.Mercadoria.Descricao;
                this.txtUnidadeMedida.Text = Ingrediente.Mercadoria.DescricaoTipoMedida;
                this.dgvDadosIngrediente.DataSource = null;
                this.dgvDadosIngrediente.DataSource = Ingrediente.DadosIngrediente;

            }
        }
        private void ConfigurarDataGridView()
        {
            dgvDadosIngrediente.AutoGenerateColumns = false;
            dgvDadosIngrediente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDadosIngrediente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDadosIngrediente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDadosIngrediente.DefaultCellStyle.SelectionBackColor = Color.Green;
            dgvDadosIngrediente.DefaultCellStyle.SelectionForeColor = Color.Black;

            var descricaoCell = new DataGridViewTextBoxColumn();
            descricaoCell.Name = "Tamanho Cadastrado";
            descricaoCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descricaoCell.DataPropertyName = "DescricaoTamanho";
            descricaoCell.ReadOnly = true;
            descricaoCell.HeaderText = "Tamanho Cadastrado";
            descricaoCell.Frozen = false;

            dgvDadosIngrediente.Columns.Add(descricaoCell);

            var quantidadeoCell = new DataGridViewTextBoxColumn();
            quantidadeoCell.Name = "Quantidade Utlizado";
            quantidadeoCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantidadeoCell.DataPropertyName = "Quantidade";
            quantidadeoCell.ReadOnly = false;
            quantidadeoCell.HeaderText = "Quantidade";
            quantidadeoCell.Frozen = false;

            dgvDadosIngrediente.Columns.Add(quantidadeoCell);

        }
        private void RemoverIngrediente(object sender, EventArgs e)
        {

            if (EventoRemoverIngrediente != null)
                EventoRemoverIngrediente(this, EventArgs.Empty);
        }
        private void AdicionarDados(object sender, EventArgs e)
        {

            if (EventoAdicionarDadosIngrediente != null)
                EventoAdicionarDadosIngrediente(Ingrediente, EventArgs.Empty);
        }
        private void RemoverDados(object sender, EventArgs e)
        {


        }
        private void AtulizarDados()
        {
            SetarDadosTela();
        }
        private void ValidarEAlteraVisiblidade(IngredienteModel ingrediente)
        {
            if (ingrediente.Equals(this.Ingrediente)) this.Visible = true;
                                                                    else this.Visible = false;
        }
        private void AdicionadoValordadosIngrediente(object sender,EventArgs args)
        {
            if (Ingrediente.DadosIngrediente == null || Ingrediente.DadosIngrediente.Count <= 0) 
                return;

            var dadosIngrediente = dgvDadosIngrediente.CurrentRow.DataBoundItem as DadosIngredienteModel;

            dadosIngrediente.Quantidade = InformandoValorComponente.ObterValor();

            this.AtulizarDados();
        }
        #endregion

        #region Eventos Publicos
        public void EventoNotificao(object sender , KeyEventArgs e)
        {

            IngredienteModel ingrediente = sender as IngredienteModel;


            switch (e.KeyCode)
            {
                case Keys.Select:
                    ValidarEAlteraVisiblidade(ingrediente);
                    break;

                case Keys.Clear:
                    this.Dispose();
                    break;


                case Keys.C:
                    break;


                case Keys.D:
                    break;
            }
            
        }



        #endregion
    }
}
