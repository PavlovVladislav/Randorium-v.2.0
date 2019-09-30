using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randorium_v._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Person Computer = new Person
            {
                Name = "Computer"
            };
            Person Gamer = new Person
            {
                Name = "Gamer"
            };

            bool gameStart = true;

            while (gameStart)  // Start Game
            {
                int turnAction = rand.Next(1, 3);
                int chooseAction = rand.Next(1, 101);

                if (turnAction == 1) //turn Computer
                {
                    if (Computer.HealthPoint <= 35) // If healt point Computer <=35 chanse of healing is rise
                    {
                        if (chooseAction < 33) // Choose Action 1 ,2 ,3
                        {
                            Gamer.HealthPoint = Computer.AttackLowRange(Gamer.HealthPoint);
                            if (Gamer.HealthPoint == 0)
                            {
                                gameStart = false;
                                Console.WriteLine("Gamer is lose");
                            }
                        }
                        else if (chooseAction >= 33 && chooseAction < 50)
                        {
                            Gamer.HealthPoint = Computer.AttackHighRange(Gamer.HealthPoint);
                            if (Gamer.HealthPoint == 0)
                            {
                                gameStart = false;
                                Console.WriteLine("Gamer is lose");
                            }
                        }
                        else if (chooseAction >= 50 && chooseAction <= 100)
                        {
                            Computer.HealthPoint = Computer.Healing();
                        }
                        else
                            Console.WriteLine("ERROR " + chooseAction);
                    }
                    else if (Computer.HealthPoint > 35)
                    {
                        if (chooseAction < 33) // Choose Action 1 ,2 ,3
                        {
                            Gamer.HealthPoint = Computer.AttackLowRange(Gamer.HealthPoint);
                            if (Gamer.HealthPoint == 0)
                            {
                                gameStart = false;
                                Console.WriteLine("Gamer is lose");
                            }
                        }
                        else if (chooseAction >= 33 && chooseAction < 66)
                        {
                            Gamer.HealthPoint = Computer.AttackHighRange(Gamer.HealthPoint);
                            if (Gamer.HealthPoint == 0)
                            {
                                gameStart = false;
                                Console.WriteLine("Gamer is lose");
                            }
                        }
                        else if (chooseAction >= 66 && chooseAction <= 100)
                        {
                            Computer.HealthPoint = Computer.Healing();
                        }
                        else
                            Console.WriteLine("ERROR " + chooseAction);
                    }
                    
                }

                else if (turnAction == 2) //turn Gamer
                    {

                    if (chooseAction < 33) //Choose Action 1, 2, 3
                    {
                        Computer.HealthPoint = Gamer.AttackLowRange(Computer.HealthPoint);
                        if (Computer.HealthPoint == 0)
                        {
                            gameStart = false;
                            Console.WriteLine("Computer is lose");
                        }
                    }
                    else if (chooseAction >= 33 && chooseAction < 50)
                        {
                        Computer.HealthPoint = Gamer.AttackHighRange(Computer.HealthPoint);
                        if (Computer.HealthPoint == 0)
                        {
                            gameStart = false;
                            Console.WriteLine("Computer is lose");
                        }
                            }
                    else if (chooseAction >= 50 && chooseAction <= 100)
                    {
                        Gamer.HealthPoint = Gamer.Healing();
                    }

                    else
                            Console.WriteLine("ERROR " + chooseAction);
                }
                else
                    Console.WriteLine("ERROR " + turnAction);

                Console.WriteLine("Computer have {0} healt point and Gamer have {1} healt point", Computer.HealthPoint, Gamer.HealthPoint);
            }
            Console.ReadLine();
        }
    }
}
