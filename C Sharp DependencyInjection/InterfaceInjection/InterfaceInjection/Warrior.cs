﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * <p>Warrior.cs is the clientclass of the InterfaceInjection Project.</p>
 *
 * <p>This program is part of the solution for the ICA for Software Architectures in Teesside
 * University.</p>
 *
 * <p>TestDI 2014-SOLUTION is free software: you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or (at your
 * option) any later version.</p>
 *
 * <p>This program is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more
 * details.</p>
 *
 * <p>You should have received a copy of the GNU General Public License along
 * with this program. If not, see http://www.gnu.org/licenses/.</p>
 *
 * <p>Copyright Kiril Anastasov L1087591@live.tees.ac.uk 11-May-2014 </p>
 */


namespace InterfaceInjection
{
    class Warrior
    {
        /**@param myWeapon is responsible for setting the weapon type
         */
        Weapons myWeapon;

        /** default Warrior constructor that takes no arguments
         */
        public Warrior()
        {
            //this.myWeapon = myWeapon;
            // this.myWeapon = new Weapons();
            // this.myWeapon = new Weapon();
        }

        
        /** setWeapon is a setter method responsible for setting the Weapons obj
         * @param myWeapon the weapon to be used
         */
        public void setWeapon(Weapons myWeapon)
        {
            this.myWeapon = myWeapon;
        }

        /** Attack is responsible for Attacking and is inovked from the TestDI class
        * @target the target that will be attacked.
        */
        public void Attack(string target)
        {
            this.myWeapon.Hit(target);
        }
    }

}
