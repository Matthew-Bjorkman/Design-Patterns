using Ch1_StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_StrategyPattern.AbstractClasses
{
    /// <summary>
    /// Abstract class with both abstract and concrete properties/variables/methods, implementable by other classes
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// The private WeaponBehavior property for the abstract class.
        /// </summary>
        private WeaponBehavior _weaponBehavior;

        /// <summary>
        /// An abstract method signature that is similar in behavior to an interface method signature
        /// </summary>
        public abstract void Fight();

        /// <summary>
        /// An abstract Set method for WeaponBehavior.
        /// </summary>
        /// <param name="weaponBehavior">The ambigous WeaponBehavior parameter that allows a concrete set</param>
        public abstract void SetWeapon(WeaponBehavior weaponBehavior);
            
    }
}
