using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS006_Ta1
{
    public abstract class MiembroDeLaComunidad : IComunidadFeactures
    {

        public string Nombre { get; set; }

        public int Telefono { get; set; }

        public string NumeroDeVivienda { get; set; }

        public virtual List<MiembroDeLaComunidad> GetBiembro()
        {
            throw new NotImplementedException();
        }

        public virtual void Eliminar(MiembroDeLaComunidad biembro)
        {
            throw new NotImplementedException();
        }

        public virtual void Guardar(MiembroDeLaComunidad biembro)
        {
            throw new NotImplementedException();
        }

        public virtual void Modificar(MiembroDeLaComunidad biembro)
        {
            throw new NotImplementedException();
        }

    }
}
