using System;

namespace Assign_01_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            Program calulate = new Program();


            Console.WriteLine("Select any option:");
            int num = int.Parse(Console.ReadLine());
            Program p = new Program();


           
        }
        // public void Go()
        //{

        /*    int num;
            int side1, side2, side3;
        
            do
            {
                Console.WriteLine("Select number to go further:");
                Console.WriteLine("[1. Triangle Dimension   2.Exit ]");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter side 1:");
                        side1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(side1);

                        Console.WriteLine("Enter side 2:");
                        side2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(side2);

                        Console.WriteLine("Enter side 3:");
                        side3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(side3);
                        if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
                        {
                            Console.WriteLine("Traingle can be formed");
                            if (side1 == side2 || side2 == side3 || side1 == side3)
                            {
                                Console.WriteLine("Triangle is isoscales");
                            }
                            else if (side1 == side2 && side2 == side3)
                            {
                                Console.WriteLine("Triangle is Equilateral");
                            }
                            else
                            {
                                Console.WriteLine("Triangle is Scalene");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Traingle can not be formed");
                        }

                            break;

                    case 2:
                        Console.WriteLine("Exit");
                        break;

                    
                }
            } while (num==2);*/

        //}


    }
}
