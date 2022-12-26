using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superreduce
{
	internal class Program
	{
		static string myfunction(string s)
		{
			//string Result;
			//int a;
			for (int i = 0; i < s.Length - 1; i++)
			{
				if (s[i] == s[i + 1])
				{
					// a = i;
					//s.Remove(s[i]);
					s = s.Remove(i, 2);
					//i = -1;
				}

			}
			if (s == " ")
			{
				//Console.WriteLine("Empty String");
				return ("Empty String");
			}
			else
			{
				//Console.WriteLine(s);
				return s;
			}

		}

		static void Main(string[] args)
		{
			string s = "aaakknuuuuumzebbb";           
			string result = myfunction(s);

			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}

