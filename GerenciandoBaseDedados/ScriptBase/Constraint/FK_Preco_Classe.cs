using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ScriptBase.Constraint
{
    public class FK_Preco_Classe : IScriptConstraint
    {
        public string NomeConstraint => "FK_Preco_Classe";

        public string Script => $@"ALTER TABLE [dbo].[Sabor]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdClasse])
    					REFERENCES [dbo].[Classe] ([Id])
    					ALTER TABLE [dbo].[Sabor] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
