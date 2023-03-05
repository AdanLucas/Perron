using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public class dtoCell<T>: DataGridViewCell
    {
        T Item { get; set; }
    }

