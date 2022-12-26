using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Birthday_Cake
{
    internal class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            
            int count = 0;
            int max = 0;
            foreach (var candle in candles)
            {
                
                int num = candle;
                if (num > max)
                {
                    max = num;
                    count = 1;
                }
                else if (max == num)
                {
                    count++;
                }
            }
            return count;
        }


        public static void Main(string[] args)
        {
            List<int> ar = new List<int> {3,2,2,2,1,3,3};
           
            int result = birthdayCakeCandles(ar);
            
            
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
    }
    

