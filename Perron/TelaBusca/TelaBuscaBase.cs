using Model.Model;
using Perron.View.Forms;
using Services.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        
        
        private List<EntidadeBuscaModel> ListaGrid;
        private EntidadeBuscaModel entidadeSelecionado { get; set; }
        private FrmBuscarItem _view = new FrmBuscarItem();
        private ServiceTelaBuscaDinamico _service;

        private bool multiSelecao { get; set; }

        #endregion

        #region Construtor
        public TelaBuscaBase(Type tipo)
        {
            _service = new ServiceTelaBuscaDinamico(tipo);
            _view.Painel.Controls.Add(_view.DataItem);
            _view.DataItem.Dock = DockStyle.Fill;
            _view.EventoBusca += EventoFiltrandoBusca;
            this.ConfigurarGrid();

        }
        #endregion
        
        #region Metodos Privados
        private void ConfigurarGrid()
        {
            _view.DataItem.AutoGenerateColumns = false; 
            _view.DataItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _view.DataItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _view.DataItem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _view.DataItem.DefaultCellStyle.SelectionBackColor = Color.Green;
            _view.DataItem.DefaultCellStyle.SelectionForeColor = Color.Black;

            var textoCell = new DataGridViewTextBoxColumn();
            textoCell.Name = "Descricao";
            textoCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            textoCell.DataPropertyName = "Descricao";
            textoCell.ReadOnly = true;
            textoCell.HeaderText = "Descrição";
            textoCell.Frozen = false;

            _view.DataItem.Columns.Add(textoCell);

            ListaGrid = _service.ObterTodos();

            _view.DataItem.DataSource = ListaGrid;

        }
        private void ConfiguracaoMultiSelecaoGrid()
        {
            _view.DataItem.KeyDown += EventoFechar;

            var ckCell = new DataGridViewCheckBoxColumn();
            ckCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            ckCell.DataPropertyName = "Selecionado";
            ckCell.Width = 20;
            ckCell.ReadOnly = false;
            ckCell.Frozen = false;
            ckCell.Name = "Selecionado";
            ckCell.HeaderText = "";
            _view.DataItem.Columns.Add(ckCell);
        }
        private void ConfiguraSelecaoUnicaGrid()
        {
            _view.DataItem.DoubleClick += EventoDoubleClickDataGridView;
        }
        #endregion




        #region Eventos
        private void EventoDoubleClickDataGridView(object sender,EventArgs args)
        {
            this.entidadeSelecionado = ((DataGridView)sender).CurrentRow.DataBoundItem as EntidadeBuscaModel;

            _view.DialogResult = DialogResult.OK;
            _view.Close();
        }
        private void EventoFiltrandoBusca(object sender,EventArgs args)
        {
            var texto = sender.ToString().ToUpper();

            if(texto.Equals(""))
                _view.DataItem.DataSource = ListaGrid;

            else
            {
                var Filtrado = ListaGrid.Where(busca => busca.Descricao.ToUpper().Contains(texto)).ToList();
                _view.DataItem.DataSource = Filtrado;
            }
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

        private List<T> ObterMultiSelecao<T>()
        {
            var lista = new List<T>();

            for (int i = 0; i < _view.DataItem.Rows.Count; i++)
            {
                EntidadeBuscaModel entidade  = _view.DataItem.Rows[i].DataBoundItem as EntidadeBuscaModel;

                if(entidade.Selecionado)
                {
                    lista.Add((T)entidade.DataItem);
                }
            }

            return lista;

        }
        
        public List<T> ObterSelecaoMultipla<T>()
        {
            try
            {
                this.ConfiguracaoMultiSelecaoGrid();

                if (_view.ShowDialog() == DialogResult.OK)
                {
                    return ObterMultiSelecao<T>();
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
        public T ObterSelecionado<T>()
        {
            try
            {
                this.ConfiguraSelecaoUnicaGrid();

                if (_view.ShowDialog() == DialogResult.OK)
                {
                    return (T)entidadeSelecionado.DataItem;
                }
                return default;

            }
            catch (Exception)
            {

                throw;
            } 
        }


        #endregion

    }
}
