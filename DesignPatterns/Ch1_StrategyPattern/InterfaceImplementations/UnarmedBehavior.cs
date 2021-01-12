using Ch1_StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_StrategyPattern.InterfaceImplementations
{
    /// <summary>
    /// public implementation of the WeaponBehavior interface
    /// </summary>
    public class UnarmedBehavior : WeaponBehavior
    {
        /// <summary>
        /// Public UnarmedBehavior constructor to create an instance of the concrete class
        /// </summary>
        public UnarmedBehavior()
        {

        }

        /// <summary>
        /// UseWeapon method necessary to satisfy implementation requirements
        /// </summary>
        public void UseWeapon()
        {
            //The behavior unique to this implementation of the WeaponBehavior interface
            Console.WriteLine(" punches the enemy with their fists.");
        }
    }
}
