using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.AtribulteClasses
{
    public class AtributoTipoBusca : Attribute
    { 
       public Type Tipo { get; set; }
    }
    
}
