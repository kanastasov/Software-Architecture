using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * <p>Punish.cs is a concreate class that implement the Weapons interface and overrides the Hit method. InterfaceInjection Project.</p>
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
    class Punish : Weapons
    {
       /** overide the hit method from the Weapons interface
         * @param target the target for the punish
         */
        public void Hit(string target)
        {
            Console.WriteLine("Punish {0}, until they learn OOP Principles", target);
        }
    }
    
}
