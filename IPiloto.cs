using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSabado22.Interfaces
{
    interface IPiloto
    {
        string Nombre { get; set;  }
        int Edad { get; set;  }
        string TipoLicencia { get; set; }//tipo, A,B, C, M.

        void MostrarInformacion();
    }
}
