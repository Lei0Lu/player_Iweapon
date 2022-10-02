using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2022
{
    public class Player
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public IWeapon Weapon { get; set; }


        //public void AttackPlayer(Player target)
        //{
        //    Weapon.Attack();
        //    target.Health -= Weapon.Damage;
        //}
        public void Life()
        {
            if (Health <= 0) Console.WriteLine($"{Name} мертв");
            else;
        }


        public void Action( Player have)
        {
            Random rnd = new Random();
            for (bool i = false; i == false;)
            {
                Console.WriteLine($"{Name}\n 0 - ударить, 1- попытаться выхватить {have.Weapon.Name}");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 0)
                {
                    Console.WriteLine("первый атакует второго");
                    Weapon.Attack();
                    have.Health -= Weapon.Damage;
                    i = true;
                }
                else if (action == 1)
                {


                    int value = rnd.Next(0, 10);
                    if (value <= 4)
                    {
                        Console.WriteLine($"{Name} отобрал {have.Weapon.Name} у противника");
                        Weapon = have.Weapon;
                        have.Weapon = new Fist();
                       
                    }
                    else
                    {
                        Console.WriteLine($"{Name} попытался отобрать {have.Weapon.Name} у противника, но без результатно");
                    }

                    i = true;
                }
                else
                {
                    Console.WriteLine($"Такого действия нет, попробуйте еще раз");
                    i = false;
                }
            }
        }






    }
}
