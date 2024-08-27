using Oop;
using System.Security.Principal;
account obj = new account();

obj.nhapthongtin();
obj.nhapthongtin(2);

obj.MaSo = 12;
obj.Name = "tan";
account[] list = new account[5];

for (int i = 0; i < list.Length; i++)
{
    list[i] = new account();
    list[i].nhapthongtin();
    list[i].Name = "test";
}

for (int i = 0; i < list.Length; i++)
{
    list[i].Hienthi();
}


// tostring

Console.WriteLine(obj.ToString());
for (int i = 0; i < list.Length; i++)
{
    Console.WriteLine(list[i].ToString());
}