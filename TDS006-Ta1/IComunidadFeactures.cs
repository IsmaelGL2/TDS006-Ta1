using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS006_Ta1
{
    public interface IComunidadFeactures
    {
        List<MiembroDeLaComunidad> GetBiembro();

        void Guardar(MiembroDeLaComunidad biembro);

        void Eliminar(MiembroDeLaComunidad biembro);

        void Modificar(MiembroDeLaComunidad biembro);

    }
}
