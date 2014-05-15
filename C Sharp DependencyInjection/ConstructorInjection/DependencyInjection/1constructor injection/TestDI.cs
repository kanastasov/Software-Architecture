using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * <p>TestDI.cs is the tester class of the ConstructorDependencyInjection Project with main method.</p>
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
namespace DependencyInjection
{
    class TestDI
    {
        public static void Main()
        {
            // create a Weapon object
            Weapon myWeapon = new Weapon();
            //create a Warrior (Client) object
            Warrior myWarrior = new Warrior(myWeapon);
            myWarrior.Attack("lame programmers");         
        }
    }
}
