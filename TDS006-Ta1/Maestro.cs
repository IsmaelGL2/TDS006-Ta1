
namespace TDS006_Ta1
{
    class Maestro : Docente
    {

        public string[] asignaturas = new string[5];

        public string[] Estudiantes = new string[50];

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
