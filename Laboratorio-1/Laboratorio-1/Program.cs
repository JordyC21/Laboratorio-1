using Microsoft.SqlServer.Server;
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
            //a.El estudiante trabajara de forma individual.
            //b.El estudiante deberá elaborar una aplicación en C#.
            //c.El programa tendrá que tener estructuras de control. Elaborar una aplicación de consola
            //con los siguientes datos:


            // 1.Se ingresarán 3 datos nombres, edad, departamento y municipio.
            //2.Los municipios deberán estar en lasados al departamento seleccionado.
            //3.Al darle agregar el dato se guardarán en un arregló.
            //4.Recorrer el arreglo y mostrar la edad.
            //d.Subir proyecto a su respectivo GitHub.
            //e.Entrega enlace en Classroom

            Persona persona = new Persona();
            persona.RegistroCliente();

            Console.WriteLine(persona.GetInformacion());
            Console.ReadLine();
          
        }  
    }
}
