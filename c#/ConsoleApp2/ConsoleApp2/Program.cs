// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] lst = new int[10];
lst[0] = 10;
lst[1] = 4;
Console.WriteLine("Nhap {0} phan tu", lst.Length);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Nhap phan tu thu {0}:", i + 1);
    lst[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("in danh sach");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("phan tu thu {0}: {1}", i + 1, lst[i]);

}
int tong = 0;
for (int i = 0; i < 10; i++)
{
    tong += lst[i];
}
Console.WriteLine("Tong danh sach = {0}", tong);
// check xem x co trong list k
int x = 0;
Console.WriteLine("Nhap x = ");
x = int.Parse(Console.ReadLine());
int slxhx = 0;
for (int i = 0; i < 10; i++)
{
    if (x == lst[i]) slxhx++;
   
}
if (slxhx == 0) Console.WriteLine("Khong xuat hien x");
else Console.WriteLine("so lan xuat hien x la: {0}", slxhx);