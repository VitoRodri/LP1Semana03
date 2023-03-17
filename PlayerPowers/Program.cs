using System;

namespace PlayerPowers
{
    [Flags]
    enum Powers
    {
        Fly=1,
        XRayVision=1<<1,
        SuperStrength=1<<2
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos jogadores?");
            int n=Int32.Parse(Console.ReadLine());

            Powers [] array= new Powers [n];
            Powers p=Powers.Fly| Powers.XRayVision| Powers.SuperStrength;
            p^=Powers.Fly;
            p^=Powers.XRayVision;
            p^=Powers.SuperStrength;

            for (int i=0; i<n; i++)
            {
                Console.WriteLine($"Jogador {i+1} quantos os poderes?");
                int m=Int32.Parse(Console.ReadLine());
                p=Powers.Fly| Powers.XRayVision| Powers.SuperStrength;
                p^=Powers.Fly;
                p^=Powers.XRayVision;
                p^=Powers.SuperStrength;
                for (int h=0; h<m;h++)
                {
                    Console.WriteLine($"Jogador {i+1} quais os poderes?");
                    string a=Console.ReadLine();
                    if (a=="Fly")
                    {
                        p^=Powers.Fly;
                    }
                    if (a=="XRayVision")
                    {
                        p^=Powers.XRayVision;
                    }
                    if (a=="SuperStrength")
                    {
                        p^=Powers.SuperStrength;
                    }


                }
                array[i]=p;
                
            }
            for (int g=0;g<n;g++)
            {
                Console.WriteLine($"Poderes do jogador {g+1}: {array[g]}");
                if (((array[g]&Powers.Fly)==Powers.Fly)&((array[g]
                        &Powers.SuperStrength)==Powers.SuperStrength))
                {
                    Console.WriteLine($"Flying Radiation !");
                }
            }
        }
    }
}
