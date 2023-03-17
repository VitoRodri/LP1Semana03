using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the vertical dimension of the array");
            int v=Int32.Parse( Console.ReadLine() );
            Console.WriteLine("Write the horizontal dimension of the array");
            int h=Int32.Parse( Console.ReadLine());

            float [,] matrix= new float [v,h];

            for (int i=0; i<matrix.GetLength(0); i++ )
            {
                for (int j=0; j<matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Write the value of matrix[{i+1},{j+1}]");
                    float f=float.Parse(Console.ReadLine());
                    matrix[i,j]=f;
                }
            } 
        }
    }
}
