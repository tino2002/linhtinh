using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    public interface nguoilinh
    {

        public int maso { get ; set; }
        public string ten { get; set; }
        public int mau { get; set; }
        public int dan { get ; set; }

        void dichuyen();

        void phongthu();
        void tancong();
    }
}
