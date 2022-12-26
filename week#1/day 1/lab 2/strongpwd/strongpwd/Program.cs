using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace strongpwd
{
    internal class Program
    {

        public static string CheckPassword(int passLength, string password, string pattren)
        {
            string pattern = @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[!@#$%^&*()-+]).{6,6}$";
            if (password.Length != passLength)
                return "Password Lenght is not 6";
            else if (Regex.Match(password, pattern).Success)
                return "Password is Correct. Lenght: 6";
            else
                return "Invalid Password";
        }
        public static void Main(string[] args)
        {
   
                
                Console.WriteLine("Please Enter your Password\n" +
                    "Make sure your password satisfies the following criteria:" +
                    "\nIts length is at least 6.\n" +
                    "It contains at least one digit.\n" +
                    "It contains at least one lowercase English character.\n" +
                    "It contains at least one uppercase English character.\n" +
                    "It contains at least one special character.The special characters are: |/=?.'<>_,!@#$%^&*()-+");
               
            
            Console.WriteLine();
            Console.Write("Password: ");
            string input = Console.ReadLine();
            Console.WriteLine(CheckPassword(6, input, ""));
           
            Console.ReadKey();
            Console.ReadLine();
        }



    }
}



