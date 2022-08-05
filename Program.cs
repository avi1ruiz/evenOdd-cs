bool ctrl = true;

do {
    Console.Write("En que número estás pensando entre 0 y 1000?");
    string? respuesta = Console.ReadLine();

    if( respuesta?.ToUpper() == "FINALIZAR") {
    
        ctrl = false;
    
    } else {
        
        try
        {

            int num = int.Parse(respuesta ?? string.Empty);

            if (num <= 1000 && num >= 0){

                if ( (num % 2) == 0 || num == 0 ) {

                    Console.WriteLine("¡Es un número par! ¿puedes añadir otro?\n");

                } else {

                    Console.WriteLine("¡Es un número impar! ¿puedes añadir otro?\n");

                }

            } else {

                Console.WriteLine("Numero fuera de rango");

            }
             
        }
        catch (System.FormatException)
        {

            Console.WriteLine("No has ingresado un respuesta valida");

        }

    }

} while (ctrl);

Console.WriteLine("Ha finalizado el programa");
