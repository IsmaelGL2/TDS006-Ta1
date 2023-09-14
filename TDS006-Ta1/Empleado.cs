
namespace TDS006_Ta1
{
    class Empleado : MiembroDeLaComunidad
    {
        public int Id { get; set; }
        public string Departamento { get; set; }

        public override void Eliminar(MiembroDeLaComunidad biembro)
        {
            base.Eliminar(biembro);
        }

        public override List<MiembroDeLaComunidad> GetBiembro()
        {
            return base.GetBiembro();
        }

        public override void Guardar(MiembroDeLaComunidad biembro)
        {
            base.Guardar(biembro);
        }

        public override void Modificar(MiembroDeLaComunidad biembro)
        {
            base.Modificar(biembro);
        }

    }
}
