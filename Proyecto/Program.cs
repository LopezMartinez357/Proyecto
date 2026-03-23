using System;

class program
{
    static int total = 0;
    static int publicados = 0;
    static int rechazados = 0;
    static int revision = 0;

    static void Main()
    {

        int opcion;

        do
        {
            Console.WriteLine("Selecciones una opcion: ");
            Console.WriteLine("1. Evaluar contenido");
            Console.WriteLine("2. Mostrar reglas");
            Console.WriteLine("3. Mostrar estadisticas");
            Console.WriteLine("4. Reiniciar estadisticas");
            Console.WriteLine("5. Salir");


            while (!int.TryParse(Console.ReadLine(), out opcion))
            {

                Console.Write("Ingrese un numero valido: ");

            }

            switch (opcion)
            {
                case 1:
                    Evaluar();
                    break;

                case 2:
                    MostrarReglas();
                    break;

                case 3:
                    MostrarEstadisticas();
                    break;

                case 4:
                    total = 0;
                    publicados = 0;
                    rechazados = 0;
                    revision = 0;
                    Console.WriteLine("Estadisticas reiniciadas");
                    break;

                case 5:
                    Console.WriteLine("Saliendo del Sistema");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            } 

        } while (opcion != 5) ;


    }

    static void MostrarReglas()
    {

        Console.WriteLine("Reglas del sistema");
        Console.WriteLine("Clasifiacion y horario:");
    }


}