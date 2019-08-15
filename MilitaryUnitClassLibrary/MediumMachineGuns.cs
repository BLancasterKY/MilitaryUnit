using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MediumMachineGuns : Weapons
    {
        public override void TypeOfWeaponry()
        {
            Console.WriteLine(" Medium Machine Guns");
            Console.WriteLine("---------------------\n");
        }
        public void M240B(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The M240B is a {RateOfFire} weapon which uses {ammo} ammo and sounds like {sound}\n");
        }
        public void M60(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The M60 is America's machine gun and is a guest of honor on this list.\n" +
                $"It is very similar to the M240. It is a {RateOfFire} weapon which uses {ammo} ammo and sounds like {sound}\n");
        }
        public override void WeaponConditions()
        {
            Console.WriteLine(" Medium Machine Gun Weapon Conditions");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Condition 1: Rounds on feed tray, feed tray cover closed, bolt locked to the rear, safety on.");
            Console.WriteLine("Condition 2: Does not apply.");
            Console.WriteLine("Condition 3: Chamber empty, rounds on feed tray, feed tray cover closed, bolt forward, safety off.");
            Console.WriteLine("Condition 4: Chamber empty, no rounds on feed tray, feed tray cover closed, bolt forward, safety off.\n");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
