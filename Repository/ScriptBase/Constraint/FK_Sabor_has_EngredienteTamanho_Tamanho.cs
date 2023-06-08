using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_EngredienteTamanho_Tamanho : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_EngredienteTamanho_Tamanho";

        public string Script => $@"	ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Tamanho])
    					REFERENCES [dbo].[Tamanho] ([Id])
    					ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
