using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRACTICAR
{
    internal class Datos
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
        public int n { get; set; }
        public int na { get; set; }
        public int ne{ get; set; }
        public int ni { get; set; }
        public int f { get; set; }




        public Datos(string nombre, string apellidos, int edad, string curso,int n1,int n2,int n3,int n4,int f)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Curso = curso;
           

            
        }

        public static void DatosA(List<Datos> citas)
        {
         
            Console.WriteLine("Ingrese los nombres del estudiante");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos del estudiante");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del estudiante");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el curso:");
            string curso = Console.ReadLine();
            Console.WriteLine("Ingrese primera nota");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            int n2=int.Parse(Console.ReadLine());   
            Console.WriteLine("Ingrese la tercera nota");
            int n3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota");
            int n4=int.Parse(Console.ReadLine());
           
           
            int f= (n1 + n2 + n3 + n4) / 4; ;
            Console.WriteLine("EL PROMEDIO ES:"+f);
            Datos cita = new Datos(nombre, apellidos, edad, curso,n1,n2,n3,n4,f);
            citas.Add(cita);
           
            





        }
       
      
    }
}
