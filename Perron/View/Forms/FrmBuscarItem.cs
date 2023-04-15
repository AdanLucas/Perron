using System;
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
    public partial class FrmBuscarItem: Form
    {
        public FrmBuscarItem()
        {
            InitializeComponent();
            dgvItem.DoubleClick += EventoGrid;
        }
        public void PopularLista<T>(List<T> lista)
        {
            if (lista != null)
            {
                dgvItem.DataSource = lista;
                dgvItem.Columns["Id"].Visible = false;
                dgvItem.Columns["Ativo"].Visible = false;
            }
        }
        public T GetItemSelecionado<T>()
        {
            try
            {
                return (T)dgvItem.CurrentRow.DataBoundItem;

            }
            catch (Exception ex)
            {

                throw new Exception("Item Não Selecionado");
            }
        }
        public void EventoGrid(object o, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
          
        }
    }
}
