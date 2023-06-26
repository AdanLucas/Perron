using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public static class ControllerNotificao
    {

        private static Form _view = new Form();


        public static DialogResult ValidarCampoVazio(ref string campo)
        {
            var result =  _view.ShowDialog();

            if (result == DialogResult.OK)
            {
                campo = _view.Text;

                return DialogResult.OK;
            }
            else if (result == DialogResult.Ignore)
            {
                return DialogResult.Ignore;
            }

            return DialogResult.Cancel;
        }



    }

