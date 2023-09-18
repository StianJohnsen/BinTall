// See https://aka.ms/new-console-template for more information
using BinTallLibrary;

BinTall numb1 = new BinTall(15);
BinTall numb2 = new BinTall("11111111");

BinTall numb3 = numb1 + numb2;
Console.WriteLine(numb3);