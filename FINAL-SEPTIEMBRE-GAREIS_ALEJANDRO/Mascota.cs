using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_SEPTIEMBRE_GAREIS_ALEJANDRO
{
    internal class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public Propietario Propietario { get; set; }
        public List<HistorialMedico> HistorialMedico { get; set; } = new List<HistorialMedico>();
        //CORRECCIÓN: USAS DOS PROPIEDADES PARA LO MISMO, PODES USAR SOLO LA FECHA DE ELIMINACION.
        public bool EstaEliminado { get; set; } = false;
        public string MotivoEliminacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
