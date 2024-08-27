// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

int[] lst = new int[10];
lst = new int[] { 10, 4, 5, 4, 6, 7,4,8,3,9,10,11 };
Console.WriteLine("in danh sach");
for (int i = 0; i<10; i++)
{
    Console.WriteLine("Phan tu thu {0}: {1}", i + 1, lst[i]);
}
Console.WriteLine("sap xep danh sach nay");
for (int i = 0; i < 9; i++)
{
    for (int j = i+1; j < 10; j++)
    {
        if (lst[i] < lst[j])
        {
            int tg = lst[i];
            lst[i] = lst[j];
            lst[j] = tg;
        }
    }
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Phan tu thu {0}: {1}", i + 1, lst[i]);
}
int[] a = new int[10];
int[] b = new int[10];
int[] c = new int[10];

a = new int[] { 10, 4, 5, 4, 6, 7, 4, 8, 3, 9,};
b = new int[] { 1, 20, 33,4 , 55,6,7,78,9,101 };
List<int> ca = new List<int>(); 
Console.WriteLine("in danh sach a");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Phan tu thu {0}: {1}", i + 1, a[i]);
}
Console.WriteLine("in danh sach b");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Phan tu thu {0}: {1}", i + 1, b[i]);
}

for (int i = 0; i<10; i++)
{
    for (int j =0; j < 10; j++)
    {
        if (a[i] == b[j])
        {
            ca.Add(a[i]);
        }
    }
}
Console.WriteLine("in danh sach c");
for (int i = 0; i < ca.Count; i++)
{
    Console.WriteLine("Phan tu thu {0}: {1}", i + 1, ca[i]);
}

//phan hop
int n = a.Length + b.Length;
int[] dsC = new int[n];
int soluong = 0;
for (int i = 0; i < a.Length; i++)
{
    if (TonTai(a[i],dsC) == false)
    {
        dsC[soluong] = a[i];
        soluong++;
    }
}
for (int i = 0; i < b.Length; i++)
{
    if (TonTai(b[i], dsC) == false)
    {
        dsC[soluong] = b[i];
        soluong++;
    }
}
bool TonTai(int x, int[] lst)
{
    bool TonTai = false;
    for(int i = 0; i<lst.Length; i++)
    {
        if (x == lst[i])
        {
            TonTai = true;
            break;
        }
    }
    return TonTai;
}
Console.WriteLine("in danh sach c");
for (int i = 0; i < dsC.Length; i++)
{
    Console.WriteLine("Phan tu thu {0}: {1}", i + 1, dsC[i]);
}
