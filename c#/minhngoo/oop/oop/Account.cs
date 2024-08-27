using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class account
    {
        private int _id;
        private string _name = "";
        public void nhapthongtin()
        {
            Console.WriteLine("Nhap du lieu");
            _id = int.Parse(Console.ReadLine());
            _name = Console.ReadLine();
        }
        public void nhapthongtin(int id)
        {
            _id = id;
        }
        // properties
        public int MaSo
        {
            get { return _id; }
            set
            {
                if (value != 0)
                    _id = value;
                else Console.WriteLine("Khong hop le");
            }
        }


        public string Name { get => _name; set => _name = value; }


        public void Hienthi()
        {
            Console.WriteLine("Ma so acocount la (0) va ten la (1) ", _id, _name);
        }
        public override string ToString()
        {
            return String.Format("{0}-{1}", _id, _name);
        }
        public override bool Equals(object? obj)
        {
            if (obj is account)
            {
                account objAccount = (account)obj;
                return (_maso == objAccount)
            }
    }
}