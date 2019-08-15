using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class HighExplosive : Weapons
    {
        public override void TypeOfWeaponry()
        {
            Console.WriteLine(" High Explosive");
            Console.WriteLine("-----------------\n");
        }
        public void M203(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The M203 is a {RateOfFire} weapon that fires {ammo} grenades and sounds like {sound}\n");
        }
        public void M32A1(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The M32A1 is a {RateOfFire} grenade launcher that fires {ammo} grenades and sounds like \n{sound}\n{sound}\n{sound}\n");
        }
        public override void WeaponConditions()
        {
            Console.WriteLine(" M203 Grenade Launcher Conditions");
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Condition 1: Round in chamber, barrel closed, safety on.");
            Console.WriteLine("Condition 2: Does not apply.");
            Console.WriteLine("Condition 3: Does not apply");
            Console.WriteLine("Condition 4: Chamber empty, barrel closed, safety on.\n");
        }
        public override void WeaponConditions2()
        {
            Console.WriteLine(" M32A1 Grenade Launcher Conditions");
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Condition 1: Rounds in cylinder, cylinder closed, safety on.");
            Console.WriteLine("Condition 2: Does not apply.");
            Console.WriteLine("Condition 3: Does not apply");
            Console.WriteLine("Condition 4: No rounds in cylinder, cylinder closed, safety on.\n");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
