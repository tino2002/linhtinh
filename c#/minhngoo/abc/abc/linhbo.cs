using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class linhbo : nguoilinh
    {
        int _maso, _mau, _dan;
        string _ten;
        public int maso { get => _maso; set => _maso = value; }
        public string ten { get => _ten; set => _ten = value; }
        public int mau { get => _mau; set => _mau = value; }
        public int dan { get => _dan; set => _dan = value; }

        public void dichuyen()
        {
            Console.WriteLine("nguoi linh di chuyen");
        }
        public void phongthu()
        {
            Console.WriteLine("nguoi linh phong thu");
        }
        public void tancong()
        {
            Console.WriteLine("nguoi linh tan cong");
        }

    }
}
