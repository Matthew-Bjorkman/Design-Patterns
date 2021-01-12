using Ch1_StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_StrategyPattern.InterfaceImplementations
{
    /// <summary>
    /// public implementation of the WeaponBehavior interface
    /// </summary>
    public class SwordBehavior : WeaponBehavior
    {
        /// <summary>
        /// Public SwordBehavior constructor to create an instance of the concrete class
        /// </summary>
        public SwordBehavior()
        {

        }

        /// <summary>
        /// UseWeapon method necessary to satisfy implementation requirements
        /// </summary>
        public void UseWeapon()
        {
            //The behavior unique to this implementation of the WeaponBehavior interface
            Console.WriteLine(" slashes the enemy with their sword.");
        }
    }
}
