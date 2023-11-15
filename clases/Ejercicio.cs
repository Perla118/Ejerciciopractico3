using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciopractico3.clases
{
    internal class Ejercicio
    {
        //Matriz bidimensional de enteros de tamaño 3x3
        public void Ejercicio1()
        {
            int[,] numerosEnteros = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine(numerosEnteros[x, y]);

                }
            }
        }
        //Matriz bidimensional de cadenas de tamaño 2x2
        public void Ejercicio2()
        {
            string[,] matrizColores = { { "Rojo", "Verde" }, { "Azul", "Amarillo" } };

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.WriteLine(matrizColores[x, y]);

                }
            }

        }
        //Matriz bidimensional de números reales (doubles) de tamaño 4x3

        public void SumadeMatriz()
        {
            double[,] numerosReales = {{ 3.6, 2.4, 2.8 },{ 4.5, 1.7, 3.4 },{ 9.9, 12.2, 8.1 },{ 6.8, 14.6, 21.4 }
        };

            ResultadoMatrizConSuma(numerosReales);
        }
        private void ResultadoMatrizConSuma(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double suma = 0;

            for (int x = 0; x < filas; x++)
            {
                for (int z = 0; z < columnas; z++)
                {
                    Console.WriteLine("Valores de la matriz:");
                    Console.WriteLine(matriz[x, z]);
                    suma += matriz[x, z];
                }
            }

            Console.WriteLine($"Suma total: {suma}");
        }
        //Matriz bidimensional de caracteres de tamaño 2x4
        public void MatrizCaracteres()
        {
            char[,] alfabeto = { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' } };

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(alfabeto[x, y].ToString().PadRight(2));
                }
                Console.WriteLine();
            }
        }
    }
}

