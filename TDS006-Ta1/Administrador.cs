
namespace TDS006_Ta1
{
    class Administrador : Docente
    {

        public string Contraseña { get; set; }

        public string Niveldeacceso { get; set; }

        public int Últimoacceso { get; set; }

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
