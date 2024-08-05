using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce un número: ");
        string input = Console.ReadLine();

        // Verifica que la entrada del usuario es un número válido
        if (int.TryParse(input, out int numeroUsuario))
        {
            if (numeroUsuario < 1)
            {
                Console.WriteLine("Por favor, introduce un número mayor o igual a 1.");
            }
            else
            {
                int contador = 0;
                int i = 1;

                while (i <= numeroUsuario)
                {
                    if (i % 2 == 0)
                    {
                        contador++;
                    }
                    i++;
                }

                Console.WriteLine($"Hay {contador} números pares entre 1 y {numeroUsuario}.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, introduce un número válido.");
        }

        // Mantiene la consola abierta hasta que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

