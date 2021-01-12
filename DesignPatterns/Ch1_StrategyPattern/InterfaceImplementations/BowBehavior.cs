using Ch1_StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_StrategyPattern.InterfaceImplementations
{
    /// <summary>
    /// public implementation of the WeaponBehavior interface
    /// </summary>
    public class BowBehavior : WeaponBehavior
    {
        /// <summary>
        /// Public BowBehavior constructor to create an instance of the concrete class
        /// </summary>
        public BowBehavior()
        {

        }

        /// <summary>
        /// UseWeapon method necessary to satisfy implementation requirements
        /// </summary>
        public void UseWeapon()
        {
            //The behavior unique to this implementation of the WeaponBehavior interface
            Console.WriteLine(" shoots the enemy with their bow.");
        }
    }
}
