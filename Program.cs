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
        //     System.Console.WriteLine();
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
        //             System.Console.WriteLine();
        //             System.Console.WriteLine("Pulsa enter para continuar...");
        //             Console.ReadLine();
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
        //             System.Console.WriteLine();
        //             System.Console.WriteLine("Pulsa enter para continuar...");
        //             Console.ReadLine();
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
        //             System.Console.WriteLine("Quieres cambiar la reserva a otra habitacion? (S/N)");
        //             string userModify = Console.ReadLine();
        //             if (userModify != "N")
        //             {
        //                 goto case 2;
        //             }
        //             break;
        //         case 4:
        //             System.Console.WriteLine("Cerrando programa...");
        //             break;
        //         default: 
        //             System.Console.WriteLine("No has introducido ningun numero valido!");
        //             break;
        //     }
        //     System.Console.WriteLine();
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

        // int totalVentas = 0;

        // for (int i = 0; i < ventas.GetLength(0); i++)
        // {
        //     int totalSec = 0;
            
        //     for (int j = 0; j < ventas.GetLength(1); j++)
        //     {
        //         totalSec += ventas[i,j];
        //         totalVentas += ventas[i,j];
        //     }

        //     Console.WriteLine($"VENTAS SECCION {i}: {totalSec}");
        // }
        // Console.WriteLine($"TOTAL VENTAS: {totalVentas}");

        // 4. En un colegio, se lleva un registro de la asistencia de los estudiantes en diferentes
        // clases a lo largo de la semana. La información se presenta en una matriz de la
        // siguiente manera:

        bool[,] asistencia = {
        { true, false, true, true, false },
        { true, true, true, true, true },
        { false, false, true, true, false },
        { true, true, true, false, true },
        { true, false, true, false, true }
        };

        // Donde true indica que el estudiante asistió a la clase y false indica que el estudiante
        // no asistió. Codifica un programa en C# que permita al usuario ingresar el número de
        // estudiante y el día de la semana, y el programa debe mostrar si el estudiante asistió o
        // no a esa clase.

        // int userNum, weekDay;

        // System.Console.Write("Numero del estudiante: ");
        // userNum = Convert.ToInt32(Console.ReadLine());
        
        // System.Console.Write("Numero del dia de la semana: ");
        // weekDay = Convert.ToInt32(Console.ReadLine());

        // if (asistencia[userNum - 1, weekDay - 1])
        // {
        //     Console.WriteLine("El alumno asistio a clase");
        // }
        // else
        // {
        //     Console.WriteLine("El alumno NO asistio a clase");
        // }

        // 5. Explica el funcionamiento de este programa:

        int[][] matriz = { // Declara la variable matriz y agrega valores
            new int[] { 1, 1, 1 },
            new int[] { 1 },
            new int[] { 1, 1, 2 }
        };
        for (int i = 0; i < 3; i++) // Bucle para recorrer las filas de la matriz
        {
            int sumaFila = 0; // Guarda valores de las filas
            int sumaColumna = 0; // Guardar valores de las columnas
            for (int j = 0; j < matriz[i].Length; j++) // Bucle para recorrer los valores de la fila
            {
                System.Console.WriteLine(i < matriz[j].Length);
                if (i < matriz[j].Length) // Si el indice de fila es menor a la longitud de la matriz con el indice de la columna
                {
                    sumaFila += matriz[i][j]; // Suma valor al sumaFila
                }
                if (j < matriz[i].Length && i < matriz[j].Length) // La condicion de antes + indice de la columna es menor a la longitud de la matriz con indice de fila
                {
                    sumaColumna += matriz[i][j]; // Suma valor al sumaFila
                }
            }
            Console.WriteLine("Suma de fila: " + sumaFila);
            Console.WriteLine("Suma de columna: " + sumaColumna); // Printa los valores
        }
        
        // Un problema de este codigo es que si la fila tiene menor longitud a la columna, hay valores de la columna
        // que se pierden porque el bucle no lo recorre.

        // Otro problema es que al no cumplir la condicion "i < matriz[j].Length", no suma ni las filas ni columnas.

    }
}