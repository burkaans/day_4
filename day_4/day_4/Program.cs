using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainigais = 3;

            // <
            // >
            // ==
            // !=

            if(mainigais < 5)
            {
                Console.WriteLine("mazaks");
            }
            else
            {
                Console.WriteLine("lielaks");
            }

            string mainigais2 = "si ir virkne";

            if (mainigais2 == "si ir virkne")
            {
                Console.WriteLine("vienads");
            }
            else
            {
                Console.WriteLine("nav vienads");
            }

            mainigais = Convert.ToInt16("45");
            int a = 5 + mainigais;
            Console.WriteLine(a);


            int mainigais3;
           string ievade = Console.ReadLine();
            mainigais3 = Convert.ToInt16(ievade);
            if(mainigais3 > 5)

            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("#");
            }

            int mainigais4;
            string ievade2 = Console.ReadLine();
            mainigais4 = Convert.ToInt16(ievade2);
            if (mainigais4 > 6)
            {
                Console.WriteLine("kluda");
            }
            else
            {
                if(mainigais4 == 6)
                {
                    Console.WriteLine("Tas ir sessturis");
                }
                else
                {
                    if(mainigais4 == 5)
                    {
                        Console.WriteLine("piecsturis");
                    }
                    else
                    {
                        if(mainigais4 == 4)
                        {
                            Console.WriteLine("cetrsturis");
                        }
                        else
                        {
                            if (mainigais4 == 3)
                            {
                                Console.WriteLine("trissturis");
                            }
                            else
                            {
                                if(mainigais4 < 3)
                                {
                                    Console.WriteLine("kluda");
                                }
                            }
                        }
                    }
                }
            }

            switch (mainigais4)
            {
                case 3:
                    Console.WriteLine("trijsturis");
                    break;
                case 4:
                    Console.WriteLine("cetrsturis");
                    break;
                case 5:
                    Console.WriteLine("piecsturis");
                    break;
                default:
                    Console.WriteLine("kluda!");
                    break;
            }
            Console.ReadLine();
                
                
        }
    }
}
