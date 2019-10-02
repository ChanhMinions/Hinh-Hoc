using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class HinhVuong : HinhCn
    {
   

        public float Canh { get; set; }

        public HinhVuong(float canh)
        {
            Canh = canh;
        }

        public override float chuVi()
        {
            return Canh *4;
        }

        public override float dienTich()
        {
            return Canh * Canh;
        }
    }
}
