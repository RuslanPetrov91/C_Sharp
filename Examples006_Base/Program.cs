int a1 = 5;
int a2 = 4;
int a3 = 3;
int a4 = 8;
int a5 = 1;
int a6 = 6;

int max = a1;

if (a1 > max) max = a1;
if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (a4 > max) max = a4;
if (a5 > max) max = a5;
if (a6 > max) max = a6;

Console.Write("max = ");
Console.WriteLine(max);