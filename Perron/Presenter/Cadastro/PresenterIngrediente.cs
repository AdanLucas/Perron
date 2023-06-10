using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterIngrediente : PresenterPadrao , IPresenterEngrediente
    {
        private readonly IViewCadastroIngrediente _view;
        private readonly IServiceEngrediente _service;
        private EngredienteModel _engrediente;
       
        public PresenterIngrediente(IViewCadastroIngrediente view,IServiceEngrediente service) : base(view)
        {
            _view = view;
            _view.Show();
            _service = service;
            DelegarEventos();
        }


        #region metodos Privados
        private void DelegarEventos()
        {
            _view.EventoGrid(EventoGrid);
            _view.EventoCancelar(EventoCancelar);
            _view.EventoDeletar(EventoDeletar);
            _view.EventoNovo(EventoNovo);
            _view.EventoSalvar(EventoSalvar);
        }
        private void SetEngrediente()
        {
            _engrediente.Descricao = _view.DescricaoIngrediente;

        }
        private void SetEngredienteTela()
        {
            _view.DescricaoIngrediente = _engrediente.Descricao;
        }
        private void AtivarIngredienteInativo(EngredienteModel _engrediente)
        {
            if (_engrediente.Ativo == false)
            {
                if(MessageBox.Show("Deseja Ativa a Mercadoria?", "Ativar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _engrediente.Ativo = true; 
                }
            }
        }

        private void ValidarDadosEngrediente()
        {
            bool ret = true;

            string Erro="";

            if(_engrediente.Descricao == "")
            {   
                ret = false;
                Erro += "Infome Uma Decsricao Para o Engrediente;\n";

            }

            if (!ret)
                throw new Exception(Erro);
        }
        
             #endregion


        #region Metodos Publicos
        #endregion


    
        #region Eventos Privados
        private void EventoGrid(object o, EventArgs e)
        {
            if (_view.IngredienteSelecionado != null)
            {
                SetEngredienteTela();
            }
        }
        public void EventoNovo(object o, EventArgs e)
        {
            AlterarStatusTela(EStatusCadastroTela.Novo);
            _engrediente = new EngredienteModel();
            _engrediente.Ativo=true;

        }
        public void EventoSalvar(object o, EventArgs e)
        {
            try
            {

                SetEngrediente();
                ValidarDadosEngrediente();
                AtivarIngredienteInativo(_engrediente);
                _service.Salvar(_engrediente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EventoDeletar(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void EventoCancelar(object o, EventArgs e)
        {
            AlterarStatusTela(EStatusCadastroTela.Inicio);
        }
        

        #endregion

        #region Metodos Publicos

        #endregion





    }
}
