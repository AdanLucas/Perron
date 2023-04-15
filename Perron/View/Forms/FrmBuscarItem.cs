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
        public T GetItemSelecionado
        {
            get
            {
                try
                {
                    return (T).CurrentRow.DataBoundItem;
                }
                catch
                {
                    return default(T);
                }
            }

          
        }

        public void EventoGrid(object o, EventArgs e)
        {
            if()
          
        }
    }
}
