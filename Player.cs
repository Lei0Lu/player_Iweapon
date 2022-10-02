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


        public void AttackPlayer(Player target)
        {
            Weapon.Attack();
            target.Health -= Weapon.Damage;
        }
        public void Life()
        {
            if (Health <= 0) Console.WriteLine($"{Name} мертв");
            else;
        }
    }
 }
