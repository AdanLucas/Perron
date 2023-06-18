using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ScriptBase.Constraint
{
    public class FK_Preco_Tamanho : IScriptConstraint
    {
        public string NomeConstraint => "FK_Preco_Tamanho";

        public string Script => $@"ALTER TABLE [dbo].[Preco]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IDTamanho])
    					           REFERENCES [dbo].[Tamanho] ([Id])
    					           ALTER TABLE [dbo].[Preco] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
