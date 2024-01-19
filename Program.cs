internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Una sala de cine ha vendido las siguientes localidades:

            // FILA0 (3): 1 1 1
            // FILA1 (4): 1 0 1 1
            // FILA2 (5): 0 0 1 1 1
            // FILA3 (5): 1 1 1 1 1
            // FILA4 (5): 0 1 0 1 1

        // Codifica un programa que calcule el total de localidades vendidas (1) y el total de
        // localidades disponibles (0)

        // int totalVendidas = 0;
        // int totalDisponibles = 0;

        // int[][] rows = {
        //     new int[] {1, 1, 1},
        //     new int[] {1, 0, 1, 1},
        //     new int[] {0, 0, 1, 1, 1},
        //     new int[] {1, 1, 1, 1, 1},
        //     new int[] {0, 1, 0, 1, 1}
        // };

        // foreach (int[] row in rows)
        // {
        //     foreach (int slot in row)
        //     {
        //         if (slot == 1)
        //         {
        //             totalVendidas += 1;
        //         }
        //         else
        //         {
        //             totalDisponibles += 1;
        //         }
                
        //     }
        // }

        // Console.WriteLine($"total vendidas: {totalVendidas}");
        // Console.WriteLine($"total disponibles: {totalDisponibles}");


        // 2. El software de un hotel tiene un sistema de reservas con una matriz:

        string[][] hotel = {
            new string[] { "O", "X", "X", "X", "X" },
            new string[] { "X", "X", "X", "O", "X" },
            new string[] { "X", "X", "X", "X", "X" },
            new string[] { "X", "O", "X", "X", "X" },
            new string[] { "X", "X", "X", "X", "X" },
            new string[] { "O", "X", "X", "X", "X" },
            new string[] { "X", "O", "X", "X" },
            new string[] { "X", "X", "X" }
        };

        // Codifica un programa en c# con las siguientes opciones:

        //     - Mostrar habitaciones disponibles
        //     - Reservar habitaciones (únicamente se pueden reservar las libres (O))
        //     - Modificar o borrar reserva.

        // int userSelect, userFloor, userDoor;
        
        // do
        // {
        //     System.Console.WriteLine("Escribe un numero para elegir:");
        //     System.Console.WriteLine("1: Mostrar habitaciones disponibles");
        //     System.Console.WriteLine("2: Reservar habitaciones");
        //     System.Console.WriteLine("3: Modificar o borrar reserva");
        //     System.Console.WriteLine("4: Cerrar programa");
        //     System.Console.Write("Tu eleccion: ");
        //     userSelect = Convert.ToInt32(Console.ReadLine());

        //     switch (userSelect)
        //     {
        //         case 1:
        //             System.Console.WriteLine("HABITACIONES DISPONIBLES:");
        //                 for (int i = 0; i < hotel.Length; i++)
        //                 {
        //                     for (int j = 0; j < hotel[i].Length; j++)
        //                     {
        //                         if (hotel[i][j] == "O")
        //                         {
        //                             Console.WriteLine($"Piso {i} | Puerta {j}");
        //                         }
        //                     }
        //                 }
        //             break;
        //         case 2:
        //             System.Console.WriteLine("Que habitacion quieres reservar:");
        //             System.Console.Write("Piso: ");
        //             userFloor = Convert.ToInt32(Console.ReadLine());
        //             System.Console.Write("Puerta: ");
        //             userDoor = Convert.ToInt32(Console.ReadLine());

        //             for (int i = 0; i < hotel.Length; i++)
        //             {
        //                 for (int j = 0; j < hotel[i].Length; j++)
        //                 {
        //                     if (i == userFloor && j == userDoor)
        //                     {
        //                         if (hotel[i][j] == "O")
        //                         {
        //                             hotel[i][j] = "X";
        //                             Console.WriteLine($"Piso {i} | Puerta {j} RESERVADA!");
        //                         }
        //                         else
        //                         {
        //                             Console.WriteLine($"Piso {i} | Puerta {j} ESTA OCUPADA!");
        //                         }
        //                     }
        //                 }
        //             }

        //             break;
        //         case 3:
        //             System.Console.WriteLine("Que reserva quieres borrar:");
        //             System.Console.Write("Piso: ");
        //             userFloor = Convert.ToInt32(Console.ReadLine());
        //             System.Console.Write("Puerta: ");
        //             userDoor = Convert.ToInt32(Console.ReadLine());

        //             for (int i = 0; i < hotel.Length; i++)
        //             {
        //                 for (int j = 0; j < hotel[i].Length; j++)
        //                 {
        //                     if (i == userFloor && j == userDoor)
        //                     {
        //                         if (hotel[i][j] == "X")
        //                         {
        //                             hotel[i][j] = "O";
        //                             Console.WriteLine($"RESERVA EN Piso {i} | Puerta {j} ! BORRADA!");
        //                         }
        //                         else
        //                         {
        //                             Console.WriteLine($"Piso {i} | Puerta {j} NO TIENE NINGUNA RESERVA!");
        //                         }
        //                     }
        //                 }
        //             }
        //             break;
        //         case 4:
        //             System.Console.WriteLine("Cerrando programa...");
        //             break;
        //         default: 
        //             System.Console.WriteLine("No has introducido ningun numero valido!");
        //             break;
        //     }
        // } while (userSelect != 4);
        
    
        // 3. Una tienda de comestibles ha registrado las ventas de productos en diferentes
        // secciones de la tienda. La información se presenta en una matriz de la siguiente
        // manera:

        int[,] ventas = {
            { 10, 5, 8, 12 },
            { 7, 15, 20, 10 },
            { 5, 3, 6, 8 },
            { 12, 8, 10, 18 },
            { 6, 10, 15, 7 }
        };

        // Cada número en la matriz representa las ventas diarias de un producto en una
        // sección específica. Codifica un programa en C# que calcule el total de ventas y
        // muestre el total de ventas por sección (Cada línea es una sección).

        int totalVentas = 0;

        for (int i = 0; i < ventas.GetLength(0); i++)
        {
            int totalSec = 0;
            
            for (int j = 0; j < ventas.GetLength(1); j++)
            {
                totalSec += ventas[i,j];
                totalVentas += ventas[i,j];
            }

            Console.WriteLine($"VENTAS SECCION {i}: {totalSec}");
        }
        Console.WriteLine($"TOTAL VENTAS: {totalVentas}");

        // 4. En un colegio, se lleva un registro de la asistencia de los estudiantes en diferentes
        // clases a lo largo de la semana. La información se presenta en una matriz de la
        // siguiente manera:

        // bool[,] asistencia = {
        // { true, false, true, true, false },
        // { true, true, true, true, true },
        // { false, false, true, true, false },
        // { true, true, true, false, true },
        // { true, false, true, false, true }
        // };

        // Donde true indica que el estudiante asistió a la clase y false indica que el estudiante
        // no asistió. Codifica un programa en C# que permita al usuario ingresar el número de
        // estudiante y el día de la semana, y el programa debe mostrar si el estudiante asistió o
        // no a esa clase.

        // 5. Explica el funcionamiento de este programa:

        // int[][] matriz = {
        //     new int[] { 1, 1, 1 },
        //     new int[] { 1},
        //     new int[] { 1, 1, 2 }
        // };
        // for (int i = 0; i < 3; i++)
        // {
        // int sumaFila = 0;
        // int sumaColumna = 0;
        // for (int j = 0; j < matriz[i].Length; j++)
        // {
        // if (i < matriz[j].Length)
        // {
        // sumaFila += matriz[i][j];
        // }
        // if (j < matriz[i].Length && i < matriz[j].Length)
        // {
        // sumaColumna += matriz[i][j];
        // }
        // }
        // Console.WriteLine("Suma de fila: " + sumaFila);
        // Console.WriteLine("Suma de columna: " + sumaColumna);
        // }

    }
}