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
            float m=0f;
            float a=0f;

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
            for (int g=0; g<matrix.GetLength(0); g++)
            {
                for (int y=0;y<matrix.GetLength(1);y++)
                {
                    m=m+matrix[g,y];
                }
                Console.WriteLine($"A soma da linha {g+1} é {m}");
                m=0;
            }
            for (int l=0;l<matrix.GetLength(1);l++)
            {
                for (int k=0; k<matrix.GetLength(0);k++)
                {
                   a=a+matrix[k,l]; 
                }
                Console.WriteLine($"A soma da coluna {l+1} é {a}");
                a=0;
            }
        }
    }
}
