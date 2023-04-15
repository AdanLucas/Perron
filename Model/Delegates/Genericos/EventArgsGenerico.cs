using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class EventArgsGenerico<T> : EventArgs
    {
        public  T Item { get; set; }

    }

