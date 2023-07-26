using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anam.BoletasAduanales._2.Modelos.Interfaces
{
    public interface ICatalogo
    {
        int Id { get; }
        string Nombre { get; }
        string Descripcion { get; }
    }
}
