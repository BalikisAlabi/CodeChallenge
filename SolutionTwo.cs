using System.Runtime.ExceptionServices;
using System.Buffers;
using System.Collections;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class SolutionTwo
    {
       static int numberTwo()
        {
            bool  [] arr = (5, 6, 8, 11);
            string letter = arr.Tosubstring()
            string first = arr.Substring(0, arr.Length/2);
            string second = arr.Substring(arr.Length/2);
            int firstNumber = 0;
            int SecondNumber = 0
            for (int i = 0; i < first.Length; i++) 
            {
                firstNumber +=first[i];
            } 
            for (int j = 0; j < first.Length; j++)
            {
                secondNumber += second[j];
            } 
          return firstNumber ==secondNumber;
        }
    }
}