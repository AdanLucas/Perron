using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class EngredienteModel : Aentity
{
    [Required(ErrorMessage = "Descrição é Obrigatório")]
    public string Descricao { get; set; }
    public EUnidadeMedida TipoMedida { get; set; }

    public string DescricaoTipoMedida { 
        get
        {
            return TipoMedida.GetDescription();      
        } 
    
    }

}

