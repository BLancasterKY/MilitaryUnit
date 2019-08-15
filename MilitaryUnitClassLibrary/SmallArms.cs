using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class SmallArms : Weapons
    {
        public override void TypeOfWeaponry()
        {
            Console.WriteLine(" Small Arms");
            Console.WriteLine("------------\n");
        }
        public void M4(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The M4 is a {RateOfFire} weapon which uses {ammo} ammo and sounds like {sound}\n");
        }
        public void IAR(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The M27 IAR is a {RateOfFire} weapon which uses {ammo} ammo and sounds like {sound}\n");
        }
        public override void WeaponConditions()
        {
            Console.WriteLine(" Small Arms Weapon Conditions");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Condition 1: Magazine inserted, round in chamber, bolt forward, safety on, ejection port cover closed.");
            Console.WriteLine("Condition 2: Does not apply.");
            Console.WriteLine("Condition 3: Magazine inserted, chamber empty, bolt forward, safety on, ejection port cover closed.");
            Console.WriteLine("Condition 4: Magazine removed, chamber empty, bolt forward, safety on, ejection port cover closed.\n");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
