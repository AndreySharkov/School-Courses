using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }        
    }

    class Sword : Weapon
    {
        public int BladeLength { get; set; }

        public Sword(string name, int damage, int bladeLength)
            : base(name, damage)
        {
            BladeLength = bladeLength;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} slashes with blade length {BladeLength} inches and deals {Damage} damage!");
        }
    }

    class Bow : Weapon
    {
        public int Range { get; set; }

        public Bow(string name, int damage, int range)
            : base(name, damage)
        {
            Range = range;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} shoots an arrow up to {Range} meters and deals {Damage} damage!");
        }
    }

    class Gun : Weapon
    {
        public int Ammo { get; set; }

        public Gun(string name, int damage, int ammo)
            : base(name, damage)
        {
            Ammo = ammo;
        }

        public void Attack()
        {
            if (Ammo > 0)
            {
                Ammo--;
                Console.WriteLine($"{Name} fires a bullet and deals {Damage} damage! Ammo left: {Ammo}");
            }
            else
            {
                Console.WriteLine($"{Name} is out of ammo!");
            }
        }
    }

    

}
