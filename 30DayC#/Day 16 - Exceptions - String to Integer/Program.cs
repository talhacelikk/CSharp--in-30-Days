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


class Program
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        try
        {
            int num = Convert.ToInt32(s);
            Console.WriteLine(num);
        }
        catch (Exception ex)
        {
            Console.Write("Bad String"+ex);
        }

    }
}
