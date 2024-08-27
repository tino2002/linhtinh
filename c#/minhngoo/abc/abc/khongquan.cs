using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class khongquan : nguoilinh
    {
        int _maso, _mau, _dan;
        string _ten;
        public int maso { get => _maso; set => _maso = value; }
        public string ten { get => _ten; set => _ten = value; }
        public int mau { get => _mau; set => _mau = value; }
        public int dan { get => _dan; set => _dan = value; }

        public void dichuyen()
        {
            Console.WriteLine("khong quan di chuyen");
        }
        public void phongthu()
        {
            Console.WriteLine("khong quan phong thu");
        }
        public void tancong()
        {
            Console.WriteLine("khong quan tan cong");
        }

    }
}
