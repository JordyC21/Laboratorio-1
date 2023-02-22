using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace Laboratorio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string nombre;
            //string apellido;
            //int edad;
            //string departamento;
            //string municipio; 


            //void RegistroCliente()
            //{
            //  Console.ForegroundColor = ConsoleColor.Red;
            //  Console.WriteLine("********************************************");
            //  Console.WriteLine("Por favor ingrese sus nombres por favor.\n");
            //  nombre = Console.ReadLine();
            //  Console.WriteLine("Por favor le solicitamos que ponga sus apellidos\n");
            //  apellido = Console.ReadLine();
            //  Console.WriteLine("¿Por favor digita el departamento de donde vives?\n");
            //  int opcionDepartamento = int.Parse(Console.ReadLine());
            //  Console.WriteLine("" +
            //      "1- Chalatenango\n" +
            //      " 2- San Salvador\n" +
            //      " 3- Santa Ana\n" +
            //      " 4- Sonsonate\n" +
            //      " 5- La libertad\n" +
            //      " 6- San vicente\n" +
            //      " 7- Morazan\n" +
            //      " 8- La Unión\n" +
            //      " 9- San Miguel\n" +
            //      " 10- Cabañas\n" +
            //      " 11- Ahuachapan\n" +
            //      " 12- La libertad\n" +
            //      " 13- San Vicente\n" +
            //      " 14- Cuscatlan\n");
            //  if (opcionDepartamento > 14 || opcionDepartamento <= 0)
            //  {
            //      Console.WriteLine($"La opcion ingresada = {opcionDepartamento} no se encuentra en la lista, Por favor vuelve a seleccionar un Depatamento valido\n");
            //      return;
            //  }


            //  Console.WriteLine("Muy bien ahora por favor dime el municipio donde te ubicas\n");
            //  int opcionMunicipio;



            Persona persona = new Persona();
            persona.RegistroCliente(persona.Nombre,persona.Apellido,persona.Edad, persona.Departamento, persona.Municipio);
            


          
        }  
    }
}
