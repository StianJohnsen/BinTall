// See https://aka.ms/new-console-template for more information
using BinTallLibrary;

BinTall numb1 = new BinTall(15);
BinTall numb2 = new BinTall("dwadwa");

BinTall numb3 = numb1 + numb2;
BinTall numb4 = numb1 + 2;
BinTall numb5 = 2 + numb1;
BinTall numb6 = numb2 - 2;
BinTall numb7 = -2 + numb2;
BinTall numb8 = numb1 * 2;
BinTall numb9 = 2 * numb1;

Console.WriteLine("numb3: " + numb3);
Console.WriteLine();
Console.WriteLine("numb4: " + numb4);
Console.WriteLine();
Console.WriteLine("numb5: " + numb5);
Console.WriteLine();
Console.WriteLine("numb6: " + numb6);
Console.WriteLine();
Console.WriteLine("numb7: " + numb7);
Console.WriteLine();
Console.WriteLine("numb8: " + numb8);
Console.WriteLine();
Console.WriteLine("numb9: " + numb9);