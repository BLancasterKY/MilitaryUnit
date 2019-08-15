using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class HeavyMachineGuns : Weapons
    {
        public override void TypeOfWeaponry()
        {
            Console.WriteLine(" Heavy Machine Guns");
            Console.WriteLine("--------------------\n");
        }
        public void M2A1(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The M2A1 is a {RateOfFire} machine gun that uses {ammo} ammo and sounds like {sound}\n");

        }
        public void MK19(string RateOfFire, string ammo, string sound)
        {
            Console.WriteLine($"The MK19 is a {RateOfFire} grenade launcher that fires {ammo} grenades and sounds like {sound}\n");
        }
        public override void WeaponConditions()
        {
            Console.WriteLine("  M2A1 Machine Gun Conditions");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Condition 1: (Full load) Round in chamber, rounds on cartridge stop, feed tray cover closed, bolt forward, safety on.");
            Console.WriteLine("Condition 2: (Half load) Chamber empty, rounds on cartridge stop, feed tray cover closed, bolt forward, safety on.");
            Console.WriteLine("Condition 3: Chamber empty, rounds on feed pawl, feed tray cover closed, bolt forward, safety on.");
            Console.WriteLine("Condition 4: Chamber empty, no rounds on feed pawl, feed tray cover closed, bolt forward, safety on.\n");
        }
        public override void WeaponConditions2()
        {
            Console.WriteLine(" MK19 Grenade Launcher Conditions");
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Condition 1: Bolt locked to the rear, round on face of bolt, feed tray cover closed, safety on.");
            Console.WriteLine("Condition 2: Chamber empty, rounds on postioning block, bolt forward, feed tray cover closed, safety off.");
            Console.WriteLine("Condition 3: Chamber empty,  rounds on feed pawls, bolt forward, feed tray cover closed, safety off.");
            Console.WriteLine("Condition 4: Chamber empty, no rounds on feed pawl, feed tray cover closed, bolt forward, feed tray cover closed, safety on.\n");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
