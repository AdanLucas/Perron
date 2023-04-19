using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public static class ExAEntity
    {
        public static void AtivarCadastroInativo(this Aentity cadastro)
        {
            if (cadastro.Ativo == false)
            {
                if (MessageBox.Show("O Cadastro Está Inativa, Deseja Ativar?", "Cadastro Inativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cadastro.Ativo = true;
                }

            }
        }
    public static bool InativarCadastro(this Aentity cadastro)
    {
        if (cadastro.Ativo == true)
        {

            if (MessageBox.Show("Deseja Inativar o Cadastro ?", "Inativar Cadastro ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return cadastro.Ativo = false;
            }

        }

        return cadastro.Ativo;
    }


}

