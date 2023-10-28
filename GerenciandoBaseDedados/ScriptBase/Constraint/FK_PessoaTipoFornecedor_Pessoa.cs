using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ScriptBase.Constraint
{
    public class FK_PessoaTipoFornecedor_Pessoa : IScriptConstraint
    {
        public string NomeConstraint => "FK_PessoaTipoFornecedor_Pessoa";

        public string Script => $@"ALTER TABLE [dbo].[PessoaTipoFornecedor] WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Id])
    					REFERENCES [dbo].[Pessoa] ([Id])
    					ALTER TABLE [dbo].[PessoaTipoFornecedor] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
