//sayıyı kendisinden başlayıp 10 katına kadar kurduğumuz bir fonkisyon

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

Console.Write("Please enter the number");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++) // (int i = 1; i < 11; i++) bu ikisinin kullanımıda aynı sonucu vericektir 
{

    Console.WriteLine(n + " x " + i + " = " + (n * i));

}