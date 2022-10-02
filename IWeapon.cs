using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2022
{
    public interface IWeapon
    {
        double Damage { get; set; }
        void Attack();
    }
}
