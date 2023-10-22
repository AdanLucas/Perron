using Model.Model;
using Perron.View.Forms;
using Services.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.TelaBusca
{
    public abstract class TelaBuscaBase
    {
        #region Propriedades
        
        public bool MultiSelecao { set { multiSelecao = value; } }

        private List<EntidadeBuscaModel> ListaGrid;
        private List<object> ListaEnidade;
        private DataGridView DataItem = new DataGridView();
        private FrmBuscarItem _view = new FrmBuscarItem();
        private ServiceTelaBuscaDinamico _service;

        private bool multiSelecao { get; set; }

        #endregion

        #region Construtor
        public TelaBuscaBase(Type tipo)
        {
            _service = new ServiceTelaBuscaDinamico(tipo);
            ConfigurarGrid();
            _view.Painel.Controls.Add(DataItem);
            DataItem.Dock = DockStyle.Fill;
            DataItem.KeyDown += EventoFechar;
            _view.EventoBusca += EventoFiltrandoBusca;
        }
        #endregion
        
        #region Metodos Privados
        private void ConfigurarGrid()
        {
            DataItem.AutoGenerateColumns = false; ;
            DataItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataItem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataItem.DefaultCellStyle.SelectionBackColor = Color.Green;
            DataItem.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (multiSelecao)
            {
                var ckCell = new DataGridViewCheckBoxColumn();
                ckCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                ckCell.DataPropertyName = "Selecionado";
                ckCell.Width = 20;
                ckCell.ReadOnly = false;
                ckCell.Frozen = false;
                ckCell.Name = "Selecionado";
                ckCell.HeaderText = "";
                DataItem.Columns.Add(ckCell);
            }


            var textoCell = new DataGridViewTextBoxColumn();
            textoCell.Name = "Descrição";
            textoCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            textoCell.DataPropertyName = "Descricao";
            textoCell.ReadOnly = true;
            textoCell.Name = "Descricao";
            textoCell.Frozen = false;

            DataItem.Columns.Add(textoCell);



            ListaEnidade = _service.ObterTodos() as List<object>;

            IniciarListaBusca();

            DataItem.DataSource = ListaGrid;

        } 
        #endregion

        

        #region Eventos
        private void EventoFiltrandoBusca(object sender,EventArgs args)
        {
            var texto = sender.ToString();

            if(texto.Equals(""))
                DataItem.DataSource = ListaGrid;

                         else
                             DataItem.DataSource = ListaGrid.Where(busca=>busca.Descricao.Contains(texto));
        }
        private void EventoFechar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                _view.DialogResult = DialogResult.OK;
                _view.Close();
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                _view.DialogResult = DialogResult.Cancel;
                _view.Close();
            }
        }
        #endregion

        #region Metodos Protected
        protected abstract EntidadeBuscaModel CriandoListaGrid(object Entidade);

        private void IniciarListaBusca()
        {
            ListaGrid = ListaEnidade.Select(ent=> CriandoListaGrid(ent)).ToList();
        }

        private object ObterMultiSelecao()
        {
            var lista = new List<object>();

            for (int i = 0; i < DataItem.Rows.Count; i++)
            {
                EntidadeBuscaModel entidade  = DataItem.Rows[i].DataBoundItem as EntidadeBuscaModel;

                if(entidade.Selecionado)
                {
                    lista.Add(entidade.DataItem);
                }
            }

            return lista;

        }
        private object ObterSelecaoUnica()
        {
            for (int i = 0; i < DataItem.Rows.Count; i++)
            {
                if (DataItem.Rows[i].Selected)
                {
                    EntidadeBuscaModel entidade = DataItem.Rows[i].DataBoundItem as EntidadeBuscaModel;

                    return entidade.DataItem;
                }
                return null;

            }
            return null;
        }

        public object ObterItemSelecionado()
        {
            try
            {
                if (_view.ShowDialog() == DialogResult.OK)
                {
                    if (multiSelecao)
                      return  ObterMultiSelecao();

                                else
                                    return ObterSelecaoUnica();

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

    }
}
