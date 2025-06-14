using System;

namespace RegistroEstudiante
{
    /// <summary>
    /// Representa los datos básicos de un estudiante.
    /// </summary>
    public class Estudiante
    {
        // Atributos
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        
        // Array para manejar hasta tres teléfonos
        public string[] Telefonos { get; set; }

        /// <summary>
        /// Constructor que inicializa los datos del estudiante y su array de teléfonos.
        /// </summary>
        public Estudiante(int id, string nombres, string apellidos, string direccion)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = new string[3]; // reserva espacio para 3 números
        }

        /// <summary>
        /// Agrega o actualiza un teléfono en la posición indicada (0‑2).
        /// </summary>
        public void AgregarTelefono(int indice, string numero)
        {
            if (indice < 0 || indice >= Telefonos.Length)
                throw new ArgumentOutOfRangeException(nameof(indice), "Índice de teléfono inválido.");
            Telefonos[indice] = numero;
        }

        /// <summary>
        /// Muestra por consola todos los datos del estudiante.
        /// </summary>
        public void MostrarDatos()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre Completo: {Nombres} {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  [{i+1}] {Telefonos[i] ?? "(no asignado)"}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creación de un objeto Estudiante
            var estudiante = new Estudiante(
                id: 12345,
                nombres: "María",
                apellidos: "González",
                direccion: "Av. Siempre Viva 742"
            );

            // Agregar tres teléfonos
            estudiante.AgregarTelefono(0, "0998‑123‑456");
            estudiante.AgregarTelefono(1, "0987‑654‑321");
            estudiante.AgregarTelefono(2, "0965‑111‑222");

            // Mostrar por pantalla
            estudiante.MostrarDatos();

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}


