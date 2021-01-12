using Ch1_StrategyPattern.InterfaceImplementations;
using Ch1_StrategyPattern.AbstractClasses;
using Ch1_StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_StrategyPattern.Inheritors
{
    /// <summary>
    /// Rogue "implements" the character abstract class
    /// </summary>
    public class Hero : Character
    {
        /// <summary>
        /// Public Rogue constructor to create an instance of the concrete class
        /// </summary>
        public Hero()
        {
            _weaponBehavior = new UnarmedBehavior();
        }

        /// <summary>
        /// WeaponBehavior property necessary to satisfy implementation requirements
        /// </summary>
        public WeaponBehavior _weaponBehavior { get; private set; }

        /// <summary>
        /// Fight method necessary to satisfy implementation requirements
        /// </summary>
        public override void Fight()
        {
            //The behavior unique to this implementation of the abstract Character class
            Console.Write("The hero");
            //The ambigous behavior of the WeaponBehavior 
            _weaponBehavior.UseWeapon();
        }

        /// <summary>
        /// SetWeapon method nessecary to satisfy implementation requirements 
        /// <para/>
        /// Acts as a public set to change the WeaponBehavior implementation class at runtime
        /// </summary>
        /// <param name="weaponBehavior">A WeaponBehavior implementation class that can be of the ambigous interface type</param>
        public override void SetWeapon(WeaponBehavior weaponBehavior)
        {
            Console.WriteLine("The hero switches his weapon!");
            _weaponBehavior = weaponBehavior;
        }
    }
}
