using System;
using System.Data;

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
        Console.WriteLine("Todo publico: cualquier hora");
        Console.WriteLine("+13: 6:00 a 22:00");
        Console.WriteLine("+18: 22:00 a 5:00");

        Console.WriteLine("Duracion por tipo:");
        Console.WriteLine("Peliculas: 60 - 180 minutos");
        Console.WriteLine("Series: 20 - 90 minutos por episodio");
        Console.WriteLine("Documentales: 30 - 120 minutos");
        Console.WriteLine("Eventos en vivo: 30 - 240 minutos");

        Console.WriteLine("Produccion");
        Console.WriteLine("Baja: solo todo publico o +13");
        Console.WriteLine("Media o Alta: cualquier clasificacion");

    }

    static void  MostrarEstadisticas()
    {
        Console.WriteLine("Estadisticas del sistema");
        Console.WriteLine("Total de contenidos evaluados: " + total);
        Console.WriteLine("Publicados: " + publicados);
        Console.WriteLine("Rechazados: " + rechazados);
        Console.WriteLine("En revision: " + revision);

       if (total > 0)
        {
            int porcentaje = (publicados * 100) / total;
            Console.WriteLine("Porcentaje de aprobacion: " + porcentaje + "%");

        }


    }

   

}