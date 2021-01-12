using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1_StrategyPattern.Interfaces
{
    /// <summary>
    /// Ambigous WeaponBehavior interface that allows for ambigous use and concrete implementation
    /// </summary>
    public interface WeaponBehavior
    {
        /// <summary>
        /// Abstract method header to override with specific behaviors
        /// </summary>
        public void UseWeapon();
    }
}
