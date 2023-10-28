using Perron.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class TipoUnidadeMedidaController
    {
        private readonly UCTipoMedida _view;

        public EUnidadeMedida TipoUnidadeMedida { get { return _eUnidadeMedida; } set {_eUnidadeMedida = value;} }
        public bool HabilitarComponetes { set { HabilitarDesabilitarComponetes(value); } }
        private EUnidadeMedida _eUnidadeMedida { get {return GetTipoUnidadeMedida();}set { SetTipoUnidadeMedida(value); } }
        public  event EventHandler EventoTrocaDeTipoMedida;
        public TipoUnidadeMedidaController(Panel painel)
        {
            painel.Controls.Add(_view = new UCTipoMedida());
            _view.Dock = DockStyle.Fill;

            _view.ckKg.CheckedChanged += EventoCkKg;
            _view.ckUn.CheckedChanged += EventoCkUn;
        }

        private EUnidadeMedida GetTipoUnidadeMedida()
        {
            if (_view.ckKg.Checked)
                return EUnidadeMedida.Kg;

            else if(_view.ckUn.Checked)
                     return EUnidadeMedida.Un;

            else
                return EUnidadeMedida.Nd;


        }
        private void SetTipoUnidadeMedida(EUnidadeMedida tipo)
        {
            if (tipo.Equals(EUnidadeMedida.Un))
            {
                _view.ckUn.Checked = true;
                _view.ckKg.Checked = false;

            }
            else if (tipo.Equals(EUnidadeMedida.Kg))
            {
                _view.ckUn.Checked = false;
                _view.ckKg.Checked = true;
            }
            else
            {
                _view.ckUn.Checked = false;
                _view.ckKg.Checked = false;

            }
        }
        private void HabilitarDesabilitarComponetes(bool habilitar)
        {
            _view.ckKg.Enabled = habilitar;
            _view.ckUn.Enabled = habilitar;
        }
        private void NotificarEventoTrocaDeTipoMedida()
        {
            if (EventoTrocaDeTipoMedida != null)
                        EventoTrocaDeTipoMedida(this, new EventArgs());
        }
        private void EventoCkUn(Object o ,EventArgs e)
        {
            if (_view.ckUn.Checked)
                     _view.ckKg.Checked = false;

            NotificarEventoTrocaDeTipoMedida();
        }
        private void EventoCkKg(Object o, EventArgs e)
        {
            if (_view.ckKg.Checked)
                     _view.ckUn.Checked = false;

            NotificarEventoTrocaDeTipoMedida();
        }
    }
}

