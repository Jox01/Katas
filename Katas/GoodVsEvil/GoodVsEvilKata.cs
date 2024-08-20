using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
namespace Katas.GoodVsEvil
{
    //Input:
    //The function will be given two parameters.Each parameter will be a string of multiple integers separated by a single space.Each string will contain the count of each race on the side of good and evil.
    //    The first parameter will contain the count of each race on the side of good in the following order:

    //Hobbits, Men, Elves, Dwarves, Eagles, Wizards.
    //The second parameter will contain the count of each race on the side of evil in the following order:

    //Orcs, Men, Wargs, Goblins, Uruk Hai, Trolls, Wizards.
    //All values are non-negative integers.The resulting sum of the worth for each side will not exceed the limit of a 32-bit integer.

    //Output:
    //Return "Battle Result: Good triumphs over Evil" if good wins, "Battle Result: Evil eradicates all trace of Good" if evil wins, or "Battle Result: No victor on this battle field" if it ends in a tie.

    public static class GoodVsEvilKata
    {
        public static string GoodVsEvil(int[] goods, int[]evils)
        {
            int goodsValue = SumArmy(goods);
            int evilsValue = SumArmy(evils);

            if (goodsValue > evilsValue) return "Battle Result: Good triumphs over Evil";
            if (evilsValue > goodsValue) return "Battle Result: Evil eradicates all trace of Good";

            return "Battle Result: No victor on this battle field";

        }

        private static int SumArmy(int[] army) 
        {
            int sum = 0;
            foreach (int i in army) 
            {
                sum += i;
            }

            return sum;
        }
    }
}
