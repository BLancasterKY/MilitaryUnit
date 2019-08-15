using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Weapons
    { 
        public virtual void TypeOfWeaponry()
        {
            Console.WriteLine("  Type ");
            Console.WriteLine("--------");
        }
        public virtual void WeaponConditions()
        {
            Console.WriteLine("Condition 1");
            Console.WriteLine("Condition 2");
            Console.WriteLine("Condition 3");
            Console.WriteLine("Condition 4");
        }
        public virtual void WeaponConditions2()
        {
            Console.WriteLine("Condition 1");
            Console.WriteLine("Condition 2");
            Console.WriteLine("Condition 3");
            Console.WriteLine("Condition 4");
        }
        public void Weaponry()
        {
            Console.WriteLine("This exercise will give a description of weapons used in the Marine Corps infantry using inheritance");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();

            SmallArms sa = new SmallArms();
            sa.TypeOfWeaponry();
            sa.M4("Semi-Automatic", "5.56x45mm", "'Pap Pap'");
            sa.IAR("Fully-Automatic", "5.56x45mm", "'Papapapapap'");
            sa.WeaponConditions();

            MediumMachineGuns mmg = new MediumMachineGuns();
            mmg.TypeOfWeaponry();
            mmg.M240B("Fully-Automatic", "7.62x51mm", "'DaDaDaDaDaDaDaDa'");
            mmg.M60("Fully-Automatic", "7.62x51mm", "'DaDaDaDaDaDa'");
            mmg.WeaponConditions();

            HighExplosive he = new HighExplosive();
            he.TypeOfWeaponry();
            he.M203("Single-Fire", "40mm", "'thoomp... BOOM!'");
            he.M32A1("Multi-Shot", "40mm", "'thoomp... BOOM!'");
            he.WeaponConditions();
            he.WeaponConditions2();

            HeavyMachineGuns hmg = new HeavyMachineGuns();
            hmg.TypeOfWeaponry();
            hmg.M2A1("Fully-Automatic", ".50 Cal.", "'DooDooDooDooDooDoo'");
            hmg.MK19("Fully-Automatic", "40mm", "'BOOM! BOOM! BOOM! BOOM!'");
            hmg.WeaponConditions();
            hmg.WeaponConditions2();
        }
    }
}
