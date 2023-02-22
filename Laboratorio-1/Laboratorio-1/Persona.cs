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

        // 1. Instrucciones de la Guía Didáctica
        //Los aspectos primordiales sobre los que se debe trabajar en esta parte:
        //a.El estudiante trabajara de forma individual.
        //b.El estudiante deberá elaborar una aplicación en C#.
        //c. El programa tendrá que tener estructuras de control. Elaborar una aplicación de consola
        //con los siguientes datos:
        //1. Se ingresarán 3 datos nombres, edad, departamento y municipio.
        //2. Los municipios deberán estar en lasados al departamento seleccionado.
        //3. Al darle agregar el dato se guardarán en un arregló.
        //4. Recorrer el arreglo y mostrar la edad.
        //d.Subir proyecto a su respectivo GitHub.
        //e.Entrega enlace en Classroom

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

        public void RegistroCliente(string _nombre, string _apellido, int _edad, string _departamento, string _municipio)
        {
            this.Nombre = _nombre;
            this.Apellido = _apellido;
            this.Edad = _edad;
            this.Departamento = _departamento;
            this.Municipio = _municipio;


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************************************");
                Console.WriteLine("\nPor favor ingrese sus nombres por favor.");
                nombre = Console.ReadLine();
                Console.WriteLine("\nPor favor le solicitamos que ponga sus apellidos");
                apellido = Console.ReadLine();
                Console.WriteLine("\n¿Por favor digita el departamento de donde vives?");




            string[] Opciones = { "Chalatenango", "San Salvador", "Santa Ana", "Sonsonate", "La libertad", "San vicente" };//

            string[] MuniChalatenango = { "Agua Caliente", "Arcatao", "Azacualpa", "Cascasque", "Chalatenango", "Citala" };//

            string[] MuniSanSalvador = { "Antiguo Cuscatlan", "Santa Tecla", "Apopa", "Ciudad delgado", "Ilopango", "San Marcos" };//

            string[] MuniSantaAna = { "El Congo", "El Porvenir", "Massahuat", "Metapan", "San Antonio Pajonal", "Santa Rosa Guachipilin" };//

            string[] MuniSonsonate = { "Acajutla", "Armenia", "Caluco", "Izalco", "Cuisnahuat", "Nahulingo" };//

            string[] MuniLaLibertad = { "Antiguo Cuscatlan", "Chiltiupan", "Ciudad Arce", "Colon", "Comasagua", "Jayaque" };//

            string[] MuniSanVicente = { "Apastepeque", "Guadalupe", "San Cateyatano", "San Lorenzo", "San Sebastian", "Santa clara" };//
            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.WriteLine($"{i+1}-{Opciones[i]}");
            }

            int opcionDepartamento = int.Parse(Console.ReadLine());
            if (opcionDepartamento > 14 || opcionDepartamento <= 0)
                {

                Console.WriteLine($"La opcion ingresada = {opcionDepartamento} no se encuentra en la lista, Por favor vuelve a seleccionar un Depatamento valido\n");
                Console.WriteLine("¿Por favor digita el departamento de donde vives?\n");
                for (int i = 0; i < MuniChalatenango.Length; i++)
                {
                    Console.WriteLine($"{i + 1}-{MuniChalatenango[i]}");
                    
                }


            }
            else
            {
                switch (opcionDepartamento)
                {
                    #region#DEPARTAMENTOS
                    case 1:
                        WriteLine("Elegiste la opcion 1");
                        Departamento = "Chalatenango";
                        Console.WriteLine("\nMuy bien ahora por favor dime el municipio donde te ubicas \n");
                        for (int i = 0; i < MuniChalatenango.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}-{MuniChalatenango[i]}");

                        }
                        Municipio = MuniChalatenango[opcionMunicipio - 1];

                        break;
                    case 2:
                        WriteLine("Elegiste la opcion 2");
                        Departamento = "San Salvador";
                        Console.WriteLine("\nMuy bien ahora por favor dime el municipio donde te ubicas \n ");
                        for (int i = 0; i < MuniSanSalvador.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}-{MuniSanSalvador[i]}");

                        }
                        Departamento = MuniChalatenango;

                        break;
                    case 3:
                        WriteLine("Elegiste la opcion 3");
                        Departamento = "Santa Ana";
                        Console.WriteLine("\nMuy bien ahora por favor dime el municipio donde te ubicas \n ");

                        for (int i = 0; i < MuniSantaAna.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}-{MuniSantaAna[i]}");

                        }

                        break;
                    case 4:
                        WriteLine("Elegiste la opcion 1");
                        Departamento = "Sonsonate";
                        Console.WriteLine("\nMuy bien ahora por favor dime el municipio donde te ubicas \n ");

                        for (int i = 0; i < MuniSonsonate.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}-{MuniSonsonate[i]}");

                        }
                  
                        break;
                    case 5:
                        WriteLine("Elegiste la opcion 1");
                        Departamento = "La Libertad";
                        Console.WriteLine("\nMuy bien ahora por favor dime el municipio donde te ubicas \n ");

                        for (int i = 0; i < MuniLaLibertad.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}-{MuniLaLibertad[i]}");

                        }

                  
                        break;
                    case 6:
                        WriteLine("Elegiste la opcion 1");
                        Departamento = "San Vicente";
                        Console.WriteLine("\nMuy bien ahora por favor dime el municipio donde te ubicas \n");
                        for (int i = 0; i < MuniSanVicente.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}-{MuniSanVicente[i]}");

                        }

        
                        break;

                    default:
                        break;
#endregion
                }
            }

            int opcionMunicipio;
            



        }

    }
}
