using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2022
{
    public class Pistol : IWeapon
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public double Ammo { get; set; }
        public string Name { get; set; }
        public Pistol()
        {
            Health = 100;
            Damage = 6;
            Ammo = 12;
            Name = "Супер пистолет";
        }

        public void Attack()
        {

            if (Ammo <= 0) Console.WriteLine("Ваш магазин пуст! Перезарядитесь");
            if (Health <= 0) Console.WriteLine("Пистолет сломался, купите новый");
            else if (Ammo > 0 && Health > 0)
            {
                Console.WriteLine($"Выхватив из кобуры пистолет, главный герой сделал пару выстрелов во врага, нанеся {Damage} урона");
                Ammo -= 2;
                Console.WriteLine($"Считая патроны, главный герой помнит, что в магазине у него осталось {Ammo} патрон(а)");

                Health -= 2;
            }
        }


    }
}
