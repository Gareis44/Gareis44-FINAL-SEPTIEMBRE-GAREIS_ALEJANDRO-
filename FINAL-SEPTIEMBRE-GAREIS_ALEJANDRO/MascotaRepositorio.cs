using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_SEPTIEMBRE_GAREIS_ALEJANDRO
{
    //CORRECCION: MAL DIVIDIDO LOS PROYECTOS.
    internal class MascotaRepositorio
    {
        private List<Mascota> mascotas = new List<Mascota>();

        public Mascota Crear(Mascota mascota)
        {
            mascota.Id = mascotas.Count + 1;
            mascotas.Add(mascota);
            return mascota;
        }

        public Mascota ObtenerPorId(int id)
        {
            return mascotas.FirstOrDefault(m => m.Id == id && !m.EstaEliminado);
        }

        public List<Mascota> ObtenerTodas()
        {
            return mascotas.Where(m => !m.EstaEliminado).ToList();
        }

        public void EliminarLogico(int id, string motivo)
        {
            var mascota = ObtenerPorId(id);
            if (mascota != null)
            {
                mascota.EstaEliminado = true;
                mascota.MotivoEliminacion = motivo;
                mascota.FechaEliminacion = DateTime.Now;
            }
        }
    }
}