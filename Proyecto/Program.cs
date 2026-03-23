using System;
using System.ComponentModel.DataAnnotations;
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

    static void Evaluar()
    {
        string tipo, clasificacion, produccion;
        int duracion, hora;

        total++;

        Console.WriteLine("Nuevo Contenido");


        do
        {
            Console.Write("Tipo (pelicula, serie, documental, evento en vivo): ");
            tipo = Console.ReadLine().ToLower();

        } while(tipo != "pelicula" && tipo != "serie" && tipo != "documental" && tipo != "evento en vivo");

        do
        {
            Console.Write("Duracion: ");

        } while (!int.TryParse(Console.ReadLine(), out duracion));


        do
        {
            Console.Write("Clasificacion (todo publico, +13, +18): ");
            clasificacion = Console.ReadLine().ToLower();
        } while (!int.TryParse(Console.ReadLine(), out hora) || hora < 0 || hora > 23);


        do
        {
            Console.Write("Hora (0-23): ");
        } while (!int.TryParse(Console.ReadLine(), out hora) || hora < 0 || hora > 23 );

        do
        {
            Console.Write("Produccion (baja, media, alta): ");
            produccion = Console.ReadLine().ToLower();
        } while (produccion != "baja" && produccion != "media" && produccion != "alta");

        bool valido = true;
        string motivo = "";

        if (clasificacion == "+13" && (hora < 6 || hora > 22))
        {
            valido = false;
            motivo = "Horario no permitido para +13. ";

        }

        if (clasificacion == "+18" && (hora >= 22 || hora <= 5))
        {
            valido = false;
            motivo += "Horario no permitido para +18. ";
        }
        

        if (valido)
        {
            if (tipo == "pelicula")
            {
                valido = false;
                motivo = "Duracion no permitida para pelicula";
            }

        }

        else if (tipo == "serie")
        {
            if ( duracion < 20 || duracion > 90)
            {
                valido = false;
                motivo = "Duracion no permitida para serie";
            }
        }

        else if (tipo == "documental")
        {
            if (duracion < 30 || duracion > 120)
            {
                valido = false;
                motivo = "Duracion no permitida para documental";
            }
        }

        else
        {
            if (duracion <30 || duracion > 240)
            {
                valido = true;
                motivo = "Duracion no perimitida para envento en vivo";

            }
        }

       
        if (!valido)
        {
            Console.WriteLine("Resultado: Rechazado");
            Console.WriteLine("Motivo: " + motivo);
            rechazados++;
            return;
        }

        string impacto = "Bajo";

        if (produccion == "alta" || duracion > 120 || (hora >= 20 && hora <= 23))
        {
            impacto = "Alto";
        }

        else if (produccion == "media" || (duracion >= 60 && duracion <= 120))
        {
            impacto = "Medio";
        }

        if(impacto == "Alto")
        {
            Console.WriteLine("Resultado: En Revision");
            revision++;
        }

        else
        {
            Console.WriteLine("Resultado: Publicado");
        
                
        }
    }

   
   
   

}