// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int a = 10;
//Console.Write("Nhap a = ");
//a = int.Parse(Console.ReadLine());
//Console.WriteLine("Gia tri a (loi) = ",a);
//Console.WriteLine("Gia tri a = " + a.ToString());
//Console.WriteLine("Gia tri a = {0}", a);

//Console.Write("Nhap b = ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Gia tri a = {0}, b = {1}", a, b);
//int c = a + b;
//Console.WriteLine("Gia tri {0} + {1} = {2}", a,b,c);
Console.Write("Nhap so tien vay: ");
long a = long.Parse(Console.ReadLine());
Console.Write("Nhap so nam vay: ");
int b = int.Parse(Console.ReadLine());
double r = 0;
if (a < 5000) r = 0;
else if (a <= 100000) r = 10.5;
else if (a <= 250000) r = 10;
else if (a <= 500000) r = 9.5;
else r = 9;
double c = (double)((a * b * r) / 100);
Console.WriteLine("Tong so tien phai tra la: {0}", a + c);