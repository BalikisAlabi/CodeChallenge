using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class SolutionOne
    {
        static int numberThree()
        {
            string paragraph = ("Bob hit a ball, the Ball flew far after it was hit.");
            string banned = "three";
            string unbanned = "two"; 
            for(int i = 0; i < string paragraph.Length; i++)
            {
                if (unbanned > 1 && unbanned < 3)
                {
                    return unbanned.Tolowwercase();
                }
            }
        }
    }
}