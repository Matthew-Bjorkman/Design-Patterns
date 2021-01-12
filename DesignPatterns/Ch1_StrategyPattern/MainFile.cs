using Ch1_StrategyPattern.Inheritors;
using Ch1_StrategyPattern.AbstractClasses;
using Ch1_StrategyPattern.Interfaces;
using Ch1_StrategyPattern.InterfaceImplementations;
using System;

namespace Ch1_StrategyPattern
{
    class MainFile
    {
        static void Main(string[] args)
        {
            Character character = new Fighter();

            character.Fight();

            WeaponBehavior weaponBehavior = new SwordBehavior();
            character.SetWeapon(weaponBehavior);

            character.Fight();

            character = new Rogue();

            character.Fight();

            weaponBehavior = new BowBehavior();
            character.SetWeapon(weaponBehavior);

            character.Fight();

        }
    }
}
