// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

int sort = 0;
int[] zahlen = new int[5];
zahlen[0] = 45;
zahlen[1] = 10;
zahlen[2] = 15;
zahlen[3] = 4;

Console.WriteLine(zahlen[1] + ", " + zahlen[2] + ", " + zahlen[3] + ", " + zahlen[4]);

Array.Sort(zahlen);

foreach (int zahl in zahlen)
{
    Console.Write(zahl + " ");
}