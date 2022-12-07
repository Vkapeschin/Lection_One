int a = 2;
int b = 22;
int c = 9;
int d = 3;
int e = 28;

int max = a;

if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.WriteLine(max);