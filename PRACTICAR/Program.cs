// See https://aka.ms/new-console-template for more information
using PRACTICAR;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Datos> citas = new List<Datos>();
        int opcion;

        do
        {
            
            Console.WriteLine("Selecione:");
            Console.WriteLine("1 para crear datos del estudiante");

            Console.WriteLine("2 para finalizar");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Datos.DatosA(citas);
                break;
                case 2:
                   break;
                  


            }
        }while (opcion != 2);
    }

}