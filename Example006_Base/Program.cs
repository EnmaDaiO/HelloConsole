﻿int a = 1;
int b = 4;
int c = 2;
int d = 6;
int e = 8;

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = b;
if (d>max) max = d;
if (e>max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
