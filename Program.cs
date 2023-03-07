using System.Collections.Generic;
using System;

var colorsArr = new string[] { "red-" };
List<string> colors = new List<string>();
Console.WriteLine(colors.Count);
colors.Add("RED");
colors.Add("BLACN");
colors[5] = "ORANE";

Colors.RemoveAt(3);
Console.WriteLine(colors.Count);
for (int i = 0; i < colors.Count; i++)
{
    Console.WriteLine(colors[1]);
}
