using System;

namespace PlayerPerks
{
    class Program
    {
        [Flags]
        enum GamePerks
        {
            WaterBreathing=1,
            stealth=1<<1,
            AutoHeal=1<<2,
            DoubleJump=1<<3
        }
        static void Main(string[] args)
        {
            string f="";
            GamePerks myPerks= GamePerks.AutoHeal | GamePerks.WaterBreathing|
                             GamePerks.stealth|GamePerks.DoubleJump;
            myPerks ^=GamePerks.AutoHeal;
            myPerks ^=GamePerks.WaterBreathing;
            myPerks ^=GamePerks.stealth;
            myPerks ^=GamePerks.DoubleJump;
            for (int i=0; i<args.Length;i++)
            {
            f+=args[i];
            }

            for (int c=0; c<f.Length;c++)
            {
                if (f[c].ToString()=="w")
                {
                    myPerks ^=GamePerks.WaterBreathing;
                }
                else if (f[c].ToString()=="a")
                {
                    myPerks ^=GamePerks.AutoHeal;
                }
                else if (f[c].ToString()=="s")
                {
                    myPerks ^=GamePerks.stealth;
                }
                else if (f[c].ToString()=="d")
                {
                    myPerks ^=GamePerks.DoubleJump;
                }
                else
                {
                    Console.WriteLine($"Unknown perk!");
                    return;
                }
            
            }
            string perk="";
            if ((myPerks & GamePerks.WaterBreathing)== GamePerks.WaterBreathing)
            {
                perk+=" WaterBreathing ";
            }
            if ((myPerks&GamePerks.AutoHeal)== GamePerks.AutoHeal)
            {
                perk+=" AutoHeal ";
            }
            if ((myPerks&GamePerks.stealth)== GamePerks.stealth)
            {
                perk+=" Stealth ";
            }
            if ((myPerks&GamePerks.DoubleJump)== GamePerks.DoubleJump)
            {
                perk+=" DoubleJump ";
            }
            if (perk=="")
            {
                Console.WriteLine($"No perks at all!");
                return;
            }
            Console.WriteLine (perk);

            if (((myPerks&GamePerks.stealth)==GamePerks.stealth) 
                    &((myPerks&GamePerks.DoubleJump)==GamePerks.DoubleJump))
            {
                Console.WriteLine("Silent jumper!");
            }
            if ((myPerks&GamePerks.AutoHeal)!=GamePerks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
