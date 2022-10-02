using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2022
{
    internal class Fist : IWeapon
    {

        public double Damage { get; set; }
        public Fist()
        {
 
            Damage = 1;
        }
        public void Attack()
        {
            Console.WriteLine($"Из за отсутствия оружия, главный герой ударил кулаком врага, нанеся ему {Damage} урона");

           
        }

    }
}
