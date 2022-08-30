using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class SolutionThree
    {
      static int numberThree()
     {
        int solution(string s1, string s2)
        
            int counter = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int d = 0; d < s2.Length; d++)
                {
                    if( s1[i] == s2[d])
                    {
                        s2 = s2.Remove(d, 1);
                        counter++;
                        break;
                    }
                }
            } 
         return counter;
         }     
    }
}
 
  
       
    
