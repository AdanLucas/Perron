using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Perron.Componentes
{
    public partial class SelecaoTipoPessoa : UserControl
    {

        public ETipoPessoa TipoPessoaSetado { get { return _tipoPessoaSetado; } }
        public ETipoPessoa TipoPessoaSelecionado { get { return GetTipoPessoa(); } set { SetTipoPessoa(value); } }


        private Dictionary<ETipoPessoa, CheckBox> _checkBoxes = new Dictionary<ETipoPessoa, CheckBox>();
        private ETipoPessoa _tipoPessoaSetado { get; set; }
        public bool HabilitarComponentes { set { habilitarDesabilitarComponentes(value); } }
        public event EventHandler EventoAlterandoTipoPessoa;
        public event EventHandlerGenerico<ETipoPessoa> EventoAlterandoTipoPessoaSelecionado;
        public event EventHandlerGenerico<ETipoPessoa> EventoRemovendoTipoPessoa;
        public void RemoverCheck()
        {
            foreach (var item in _checkBoxes)
            {
                item.Value.Checked = false;
            }
        }
        public void AlterarComportamentoCadastro(EComportamentoTela comporamento)
        {
            switch (comporamento)
            {
                case EComportamentoTela.Inicio:

                    this.Visible = false;

                    break;


                case EComportamentoTela.ItemSelecionado:

                    this.Visible = true;

                    break;


                case EComportamentoTela.Cadastrando:

                    this.Visible = true;

                    break;


            }
        }
        public SelecaoTipoPessoa(Panel painel, ETipoPessoa tipos)
        {
            _tipoPessoaSetado = tipos;
            InitializeComponent();
            SetarComponenteTelaTipoTela(tipos);
            painel.Controls.Add(this);
            this.Dock = DockStyle.Fill;
        }
        private ETipoPessoa GetTipoPessoa()
        {
            ETipoPessoa tipoPessoa = new ETipoPessoa();

            foreach (var item in _checkBoxes)
            {

                if (item.Value.Checked == true)
                {
                    tipoPessoa |= item.Key;
                }

            }
            return tipoPessoa;
        }
        private void SetTipoPessoa(ETipoPessoa tipo)
        {
            foreach (var item in _checkBoxes)
            {
                if (tipo.HasFlag(item.Key))
                {
                    item.Value.Checked = true;
                }
            }
        }
        private void SetarComponenteTelaTipoTela(ETipoPessoa tipo)
        {
            ETipoPessoa[] value;

            if (tipo.HasFlag(ETipoPessoa.Pessoa))
            {
                value = (ETipoPessoa[])Enum.GetValues(typeof(ETipoPessoa));

            }
            else
            {
                value = _tipoPessoaSetado.GetArrayItemEnum<ETipoPessoa>();
                int qnt = value.Where(t => !t.HasFlag(ETipoPessoa.Pessoa)).Count();

                if (qnt <= 1)
                    this.Visible = false;

            }

            this.Width = 20;

            foreach (var item in value)
            {
                if (item != ETipoPessoa.Pessoa)
                {
                    var ckTipo = new CheckBox();
                    ETipoPessoa _tipo = item;
                    ckTipo.Dock = DockStyle.Left;
                    ckTipo.Name = Enum.GetName(typeof(ETipoPessoa), _tipo);
                    ckTipo.Text = Enum.GetName(typeof(ETipoPessoa), _tipo);
                    ckTipo.Width = ckTipo.Text.Length * 10;
                    pnElemento.Width += ckTipo.Width;
                    pnElemento.Controls.Add(ckTipo);
                    ckTipo.CheckedChanged += this.NotificarEventoTipoPessoal;
                    _checkBoxes.Add(_tipo, ckTipo);
                }
            }
            this.Width += pnElemento.Width;
        }
        private void habilitarDesabilitarComponentes(bool status)
        {
            foreach (var item in _checkBoxes)
            {
                item.Value.Enabled = status;
            }
        }
        public ETipoPessoa PegarTipoPeloNome(string nome)
        {
            ETipoPessoa[] value = (ETipoPessoa[])Enum.GetValues(typeof(ETipoPessoa));

           return value.Where(en=>en.GetNomeItem() == nome).FirstOrDefault();

        }
        private void NotificarEventoTipoPessoal(object o, EventArgs e)
        {

            if (EventoAlterandoTipoPessoa != null)
                     EventoAlterandoTipoPessoa(o, EventArgs.Empty);

            //var ck = (CheckBox)o;

                //if (!ck.Checked && EventoRemovendoTipoPessoa != null)
                //    EventoRemovendoTipoPessoa(o, new EventArgsGenerico<ETipoPessoa> { Item = PegarTipoPeloNome(ck.Name) });

                //if (EventoAlterandoTipoPessoaSelecionado != null)
                //    EventoAlterandoTipoPessoaSelecionado(o, new EventArgsGenerico<ETipoPessoa> { Item = GetTipoPessoa() });
        }

    }
}
