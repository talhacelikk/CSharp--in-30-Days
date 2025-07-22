
// Declare a variable named 'inputString' to hold our input.
// Girişimizi tutmak için 'inputString' adında bir değişken tanımlayalım.
String inputString;

// Read a full line of input from stdin (cin) and save it to our variable, input_string.
// stdin'den (cin) gelen girdinin tamamını okuyup input_string değişkenimize kaydedelim.
inputString = Console.ReadLine();

// Print a string literal saying "Hello, World." to stdout using cout.
// cout kullanarak "Merhaba Dünya." diyen bir dize sabitini standart çıktıya yazdır.
Console.WriteLine("Hello, World.");

// TODO: Write a line of code here that prints the contents of input_string to stdout.
// TODO: input_string'in içeriğini stdout'a yazdıran bir kod satırı yazın.
Console.WriteLine(inputString);

// To print on the same line without moving to the bottom line, use "Write" instead of "WriteLine"
// Alt satıra geçmeden aynı satıra yazdırmak için "WriteLine" yerine "Write" kullanın
Console.Write($"Hello,{inputString}");
