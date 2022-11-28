using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace Assignments
{
    internal class Program
    {



         public static void Main(string[] args)
        {


        }
        public static string Convert(int i)
        {
            // TODO
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1, "one");
            dic.Add(2, "two");
            dic.Add(3, "three");
            dic.Add(4, "four");
            dic.Add(5, "five");
            if (dic.ContainsKey(i)) { return dic[i]; }
            else return "nope";
        }
    }

}
