﻿using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterMercadoria : PresenterPadrao, IPresenterMercadoria
    {
        private readonly IViewCadastroMercadoria _view;
        private readonly IServiceMercadoria _service;
        

        private MercadoriaModel _mercadoria;
        private List<MercadoriaModel> ListaMercadoriaCadastrados;
        public PresenterMercadoria(IViewCadastroMercadoria view, IServiceMercadoria service) : base(view)
        {
            _view = view;
            _view.Show();
            this.ConfigurarGrid(_view.DgvMercadoria);
            _service = service;
            DelegarEventos();
            base.ComportamentoAtual = EComportamentoTela.Inicio;
            SetListaMercadoriaCadastrado(EStatusCadastro.Todos);
            _view.SelecaoTipoMedida.DataSource = EUnidadeMedida.Nd.GetArrayItemEnum();
            _view.SelecaoTipoMercadoria.DataSource = ETipoMercadoria.None.GetArrayItemEnum();
            
        }


        

        #region metodos Privados

        #region override
        
        protected override void AlterarStatusCadastroExibidos(EStatusCadastro status)
        {
            SetListaMercadoriaCadastrado(status);
            FiltrarListaPorNome(_view.TxtDescricao.Text);
        }
        protected override void AlterandoComportamentoTela()
        {
            if (ComportamentoAtual.HasFlag(EComportamentoTela.Inicio))
                _view.EventoBuscar += EventoBucarPorDescricao;

            else
                _view.EventoBuscar -= EventoBucarPorDescricao;
        }
        protected override void ComportamentoInicioTela()
        {
            _view.SetarTamanhoMaximoTela();
            _view.SelecaoTipoMedida.Enabled = false;
            _view.SelecaoTipoMercadoria.Enabled = false;
            SetListaMercadoriaCadastrado(EStatusCadastro.none);
            EstadoInicial();
        }
        protected override void ComportamentoCadastrando()
        {
            _view.SetarTamanhoDaTelaReduzido();
            _view.SelecaoTipoMedida.Enabled = true;
            _view.SelecaoTipoMercadoria.Enabled = true;
            _view.TxtDescricao.Text = "";
        }
        protected override void ComportamentoItemSelecionado()
        {
            _view.SelecaoTipoMedida.Enabled = true;
            _view.SelecaoTipoMercadoria.Enabled = true;
        }
        #endregion


        private void DelegarEventos()
        {
            _view.EventoGrid(EventoGrid);

        }
        private MercadoriaModel GetDadosMercadoria()
        {
            _mercadoria.Descricao = _view.TxtDescricao.Text;
            _mercadoria.TipoMedida = _view.SelecaoTipoMedida.SelectedItem as EUnidadeMedida?;
            _mercadoria.TipoMercadoria = _view.SelecaoTipoMercadoria.SelectedItem as ETipoMercadoria?;

            return _mercadoria;
        }
        private void SetMercadoria(MercadoriaModel mercadoria)
        {
            _mercadoria = mercadoria;
            _mercadoria = _view.MercadoriaSelecionado;
            _view.TxtDescricao.Text = _mercadoria.Descricao;
            _view.SelecaoTipoMedida.SelectedItem = _mercadoria.TipoMedida;
            _view.SelecaoTipoMercadoria.SelectedItem = _mercadoria.TipoMercadoria;
        }
        private void ConfigurarGrid(DataGridView view)
        {
            view.AutoGenerateColumns = false;
            view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view.DefaultCellStyle.SelectionBackColor = Color.Green;
            view.DefaultCellStyle.SelectionForeColor = Color.Black;


            var columDescricao = new DataGridViewTextBoxColumn();
            columDescricao.Name = "Descrição Mercadoria";
            columDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columDescricao.DataPropertyName = "Descricao";
            columDescricao.ReadOnly = true;
            columDescricao.Frozen = false;
            view.Columns.Add(columDescricao);

            var columDescricaoUnidadeMedida = new DataGridViewTextBoxColumn();
            columDescricaoUnidadeMedida.Name = "Descrição Unidade Medida";
            columDescricaoUnidadeMedida.DataPropertyName = "DescricaoTipoMedida";
            columDescricaoUnidadeMedida.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columDescricaoUnidadeMedida.ReadOnly = true;
            columDescricaoUnidadeMedida.Frozen = false;
            view.Columns.Add(columDescricaoUnidadeMedida);

            var columDescricaoTipoMercadoria = new DataGridViewTextBoxColumn();
            columDescricaoTipoMercadoria.Name = "Descrição Tipo Mercadoria";
            columDescricaoTipoMercadoria.DataPropertyName = "DescricaoTipoMercadoria";
            columDescricaoTipoMercadoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columDescricaoTipoMercadoria.ReadOnly = true;
            columDescricaoTipoMercadoria.Frozen = false;
            view.Columns.Add(columDescricaoTipoMercadoria);

        }
        private void AtivarMercadoriaInativo(MercadoriaModel _engrediente)
        {
            if (_engrediente.Ativo == false)
            {
                if (MessageBox.Show("Deseja Ativa a Mercadoria?", "Ativar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _engrediente.Ativo = true;
                }
            }
        }
        private void ValidarDadosMercadoria()
        {
            bool ret = true;

            string Erro = "";

            if (_mercadoria.Descricao == "")
            {
                ret = false;
                Erro += "Infome Uma Decsricao Para o mercadoria;\n";

            }
            if (_mercadoria.TipoMedida == 0)
            {
                ret = false;
                Erro += "Selecione a Unidade de Medida Do mercadoria;\n";
            }

            if (!ret)
                throw new Exception(Erro);
        }
        private void EstadoInicial()
        {
            _mercadoria = new MercadoriaModel();
            _mercadoria.Ativo = true;
            _view.TxtDescricao.Text = null;
            _view.SelecaoTipoMercadoria.SelectedItem = EUnidadeMedida.Nd;
            _view.SelecaoTipoMercadoria.SelectedItem = ETipoMercadoria.None;
        }
        private void SetListaMercadoriaCadastrado(EStatusCadastro status)
        {
            var Lista = _service.GetListaMercadoriaCadastrados();


            switch (status)
            {
                case EStatusCadastro.none:
                    ListaMercadoriaCadastrados = new List<MercadoriaModel>();
                    break;
                    ;
                case EStatusCadastro.Todos:
                    ListaMercadoriaCadastrados = Lista;
                    break;
                case EStatusCadastro.Ativo:
                    ListaMercadoriaCadastrados = Lista.Where(l => l.Ativo == true).ToList();
                    break;

                case EStatusCadastro.Inativo:
                    ListaMercadoriaCadastrados = Lista.Where(l => l.Ativo == false).ToList();
                    break;

                default:
                    break;
            }


        }
        private void FiltrarListaPorNome(string Descricao)
        {
            if ((ListaMercadoriaCadastrados != null || ListaMercadoriaCadastrados.Count > 0) && (!ComportamentoAtual.Equals(EComportamentoTela.Novo) || (!ComportamentoAtual.Equals(EComportamentoTela.Cadastrando))))
            {
                if (String.IsNullOrEmpty(Descricao))
                {
                    _view.PopularGridIngredientes(ListaMercadoriaCadastrados);
                }
                else
                {
                    _view.PopularGridIngredientes(ListaMercadoriaCadastrados.Where(l => l.Descricao.Contains(Descricao)).ToList());
                }
            }
        }
        #endregion

        #region Eventos Privados
        private void EventoGrid(object o, EventArgs e)
        {
            if (_view.MercadoriaSelecionado != null)
            {
                _mercadoria = _view.MercadoriaSelecionado;
                SetMercadoria(_mercadoria);
                base.ComportamentoAtual = EComportamentoTela.ItemSelecionado;
            }
        }
        private void EventoBucarPorDescricao(object o, EventArgs e)
        {
            FiltrarListaPorNome(_view.TxtDescricao.Text);
        }


        #region Evento override
        protected override void EventoNovo(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Novo;
        }
        protected override void EventoSalvar(object o, EventArgs e)
        {
            try
            {
                _mercadoria =  GetDadosMercadoria();
                ValidarDadosMercadoria();
                AtivarMercadoriaInativo(_mercadoria);
                _service.Salvar(_mercadoria);
                base.ComportamentoAtual = EComportamentoTela.Inicio;
                base.MessageDeSucesso($"Mercadoria {_mercadoria.Descricao} Cadastrado com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void EventoRemover(object o, EventArgs e)
        {
            if (MessageBox.Show($"Deseja Remover o Mercadoria {_mercadoria.Descricao} ??", "Remover??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mercadoria.Ativo = false;
                _service.Salvar(_mercadoria);
                ComportamentoAtual = EComportamentoTela.Inicio;
            }

        }
        protected override void EventoCancelar(object o, EventArgs e)
        {
            base.ComportamentoAtual = EComportamentoTela.Inicio;
        }
        #endregion

        #endregion








    }
}
