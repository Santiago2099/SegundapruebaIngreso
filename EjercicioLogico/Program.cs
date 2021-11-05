using System;

namespace EjercicioLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato , sumadiagonal1 = 0, sumadiagonal2 = 0, resta = 0;
            Console.Write("Porfavor ingrese de cuanto quiere que sea la matriz:");
            dato = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[dato, dato];
            for(int i = 0; i < dato; i++)
            {
                for (int j = 0; j < dato; j++)
                {
                    Console.Write("Porfavor ingrese numeros para llenar la matriz: ["+i+","+j+"]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Asi es la matriz que construyo:");
            for (int o = 0; o < dato; o++)
            {
                for (int u = 0; u < dato; u++)
                {
                    if(o == u)
                    {
                        sumadiagonal1 = matriz[o, u] + sumadiagonal1;
                    }
                    if (o+u == dato-1)
                    {
                        sumadiagonal2 = matriz[o, u] + sumadiagonal2;
                    }
                    Console.Write("[" + matriz[o, u] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("La suma de la primera diagonal es:"+ sumadiagonal1);
            Console.WriteLine("La suma de la segunda diagonal es:" + sumadiagonal2);
            resta = sumadiagonal2 - sumadiagonal1;
            Console.WriteLine("Y la resta de las 2 sumas es:" + resta);
            Console.ReadKey();
        }
    }
}
