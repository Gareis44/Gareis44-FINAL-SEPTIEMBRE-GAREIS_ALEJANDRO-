using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_SEPTIEMBRE_GAREIS_ALEJANDRO
{
    internal class MascotaServicio
    {
        private MascotaRepositorio repositorio;

        public MascotaServicio(MascotaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Mascota CrearMascota(Mascota mascota)
        {
            if (string.IsNullOrEmpty(mascota.Nombre) || string.IsNullOrEmpty(mascota.Especie) ||
                string.IsNullOrEmpty(mascota.Raza) || mascota.Edad <= 0 || mascota.Propietario == null)
            {
                throw new ArgumentException("Datos de la mascota incompletos o inválidos.");
            }

            return repositorio.Crear(mascota);
        }

        public Mascota ObtenerMascotaPorId(int id)
        {
            return repositorio.ObtenerPorId(id);
        }

        public void EliminarMascota(int id, string motivo)
        {
            if (string.IsNullOrEmpty(motivo))
            {
                throw new ArgumentException("Debe proporcionarse un motivo para la eliminación.");
            }

            repositorio.EliminarLogico(id, motivo);
        }

        public List<Mascota> ObtenerTodasLasMascotas()
        {
            return repositorio.ObtenerTodas();
        }
    }
}
