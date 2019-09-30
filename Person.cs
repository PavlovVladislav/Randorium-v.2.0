using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randorium_v._2._0
{
    class Person
    {
        public string Name = "Person";

        private int healthPoint = 100;
        public int HealthPoint
        {
            get { return healthPoint; }
            set
            {
                if (value < 0)
                    healthPoint = 0;
                else if (value > 100)
                    healthPoint = 100;
                else
                    healthPoint = value;
            }
        }

        Random rand = new Random();

        public int AttackLowRange(int healthPointEnemy)
        {
            int damage = rand.Next(18, 26);

            healthPointEnemy = healthPointEnemy - damage;

            Console.WriteLine(Name + " damage " + damage);

            return healthPointEnemy;
        }

        public int AttackHighRange(int healthPointEnemy)
        {
            int damage = rand.Next(10, 36);

            healthPointEnemy = healthPointEnemy - damage;

            Console.WriteLine(Name + " damage " + damage);

            return healthPointEnemy;
        }

        public int Healing()
        {
            int healing = rand.Next(18, 26);

            HealthPoint = HealthPoint + healing;

            Console.WriteLine(Name + " healing " + healing);

            return HealthPoint;
        }

    }
}
