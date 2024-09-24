using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_SEPTIEMBRE_GAREIS_ALEJANDRO
{
    internal class LogicaPrincipal
    {
        public MascotaServicio servicio;
        public void CrearMascota()
        {
            try
            {
                //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Nombre de la mascota: ");
                var nombre = Console.ReadLine();
//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Especie: ");
                var especie = Console.ReadLine();
//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Raza: ");
                var raza = Console.ReadLine();
//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Edad: ");
                var edad = int.Parse(Console.ReadLine());
//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Nombre del propietario: ");
                var nombrePropietario = Console.ReadLine();
//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Teléfono del propietario: ");
                var telefonoPropietario = Console.ReadLine();
//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Email del propietario: ");
                var emailPropietario = Console.ReadLine();
//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.Write("Dirección del propietario: ");
                var direccionPropietario = Console.ReadLine();

                var propietario = new Propietario
                {
                    Nombre = nombrePropietario,
                    Telefono = telefonoPropietario,
                    Email = emailPropietario,
                    Direccion = direccionPropietario
                };

                var mascota = new Mascota
                {
                    Nombre = nombre,
                    Especie = especie,
                    Raza = raza,
                    Edad = edad,
                    Propietario = propietario
                };

                var resultado = servicio.CrearMascota(mascota);
                //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.WriteLine($"Mascota llamada {resultado.Nombre} creada correctamente");
            }
            catch (Exception ex)
            {
                //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void EliminarMascota()
        {
            //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
            Console.Write("Ingrese el ID de la mascota a eliminar: ");
            var id = int.Parse(Console.ReadLine());

//CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
            Console.Write("Motivo de eliminación: ");
            var motivo = Console.ReadLine();

            try
            {
                servicio.EliminarMascota(id, motivo);
               //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.WriteLine("Mascota eliminada correctamente.");
            }
            catch (Exception ex)
            {
                //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void ListarMascotas()
        {
            var mascotas = servicio.ObtenerTodasLasMascotas();
            if (mascotas.Count == 0)
            {
                //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                Console.WriteLine("No hay mascotas registradas.");
            }
            else
            {
                foreach (var mascota in mascotas)
                {
                    //CORRECCION: NUNCA EN LA LÓGICA DE NEGOCIO UN CONSILE.WRITE!!
                    Console.WriteLine($"ID: {mascota.Id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}, Raza: {mascota.Raza}, Edad: {mascota.Edad}");
                }
            }
        }
    }
}