
namespace TDS006_Ta1
{
    class Docente : Empleado
    {

        public int sueldo { get; set; }

        public override List<MiembroDeLaComunidad> GetBiembro()
        {
            return base.GetBiembro();
        }

        public override void Guardar(MiembroDeLaComunidad biembro)
        {
            base.Guardar(biembro);
        }

        public override void Eliminar(MiembroDeLaComunidad biembro)
        {
            base.Eliminar(biembro);
        }

        public override void Modificar(MiembroDeLaComunidad biembro)
        {
            base.Modificar(biembro);
        }

    }
}
