using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laboratorio_1
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string departamento;
        private string municipio;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Municipio { get => municipio; set => municipio = value; }

        public void RegistroCliente()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.WriteLine("\nPor favor ingrese sus nombres por favor.");
            Nombre = Console.ReadLine();

            Console.WriteLine("\nPor favor le solicitamos que ponga sus apellidos");
            Apellido = Console.ReadLine();

            Console.WriteLine("\nPor favor digita tú edad");
            Edad = int.Parse( Console.ReadLine());

            ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n¿Por favor digita el departamento de donde vives?");
            ResetColor();
            string[] opciones = { "Chalatenango", "San Salvador", "Santa Ana", "Sonsonate", "La Libertad", "San Vicente" };
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{opciones[i]}");
            }

            int opcionDepartamento = int.Parse(Console.ReadLine());
            while (opcionDepartamento > opciones.Length || opcionDepartamento <= 0)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La opcion ingresada = {opcionDepartamento} no se encuentra en la lista, Por favor vuelve a seleccionar un Departamento valido\n");
                ResetColor();
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine($"{i + 1}-{opciones[i]}");
                }
                opcionDepartamento = int.Parse(Console.ReadLine());
            }

            Departamento = opciones[opcionDepartamento - 1];
            Console.WriteLine($"\nEstos son los municipios de {Departamento}\n");

            switch (Departamento)
            {
                case "Chalatenango":
                    string[] muniChalatenango = { "Agua Caliente", "Arcatao", "Azacualpa", "Cascasque", "Chalatenango", "Citala" };
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nElige el municipio :D");
                    ResetColor();
                    for (int i = 0; i < muniChalatenango.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{muniChalatenango[i]}");
                    }
                    int opcionMunicipio = int.Parse(Console.ReadLine());
                    Municipio = muniChalatenango[opcionMunicipio - 1];
                    break;

                case "San Salvador":
                    string[] muniSanSalvador = { "Antiguo Cuscatlan", "Santa Tecla", "Apopa", "Ciudad delgado", "Ilopango", "San Marcos" };
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nElige el municipio :D");
                    ResetColor();
                    for (int i = 0; i < muniSanSalvador.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{muniSanSalvador[i]}");
                    }
                    opcionMunicipio = int.Parse(Console.ReadLine());
                    Municipio = muniSanSalvador[opcionMunicipio - 1];
                    break;

                case "Santa Ana":
                    string[] muniSantaAna = { "El Congo", "El Porvenir", "Massahuat", "Metapan", "San Antonio Pajonal", "Santa Rosa Guachipilin" };
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nElige el municipio :D");
                    ResetColor();
                    for (int i = 0; i < muniSantaAna.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{muniSantaAna[i]}");
                    }
                    opcionMunicipio = int.Parse(Console.ReadLine());
                    Municipio = muniSantaAna[opcionMunicipio - 1];
                    break;

                case "Sonsonate":
                    string[] muniSonsonate = { "Acajutla", "Armenia", "Caluco", "Izalco", "Cuisnahuat", "Nahulingo" };//
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nElige el municipio :D");
                    ResetColor();
                    for (int i = 0; i < muniSonsonate.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{muniSonsonate[i]}");
                        Console.ReadLine();
                    }
                    opcionMunicipio = int.Parse(Console.ReadLine());
                    Municipio = muniSonsonate[opcionMunicipio - 1];
                    break;

                case "La Libertad":
                    string[] muniLaLibertad = { "Antiguo Cuscatlan", "Chiltiupan", "Ciudad Arce", "Colon", "Comasagua", "Jayaque" };//
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nElige el municipio :D");
                    ResetColor();
                    for (int i = 0; i < muniLaLibertad.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{muniLaLibertad[i]}");
                    }
                    opcionMunicipio = int.Parse(Console.ReadLine());
                    Municipio = muniLaLibertad[opcionMunicipio - 1];
                    break;

                case "San Vicente":
                    string[] muniSanVicente = { "Apastepeque", "Guadalupe", "San Cateyatano", "San Lorenzo", "San Sebastian", "Santa clara" };//
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nElige el municipio :D");
                    ResetColor();
                    for (int i = 0; i < muniSanVicente.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{muniSanVicente[i]}");
                    }
                    opcionMunicipio = int.Parse(Console.ReadLine());
                    Municipio = muniSanVicente[opcionMunicipio - 1];
                    break;

                    
            }

            
        }
        public String GetInformacion()
        {
            return "\nNombre: "+ Nombre + "\nApellido: " + Apellido  + "\nEdad: " + Edad + "\nDepartamento: " + Departamento + "\nMunicipio: " + Municipio;
         
        }

    }
}
