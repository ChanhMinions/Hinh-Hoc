using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class HinhTron : Hinhhoc
    {

        public HinhTron(float r)
        {
            R = r;
        }

        public const float PI = 3.14f;

        public float R {get; set;}

        public override float chuVi()
        {
            return base.chuVi() + R *2 * PI;
        }

        public override float dienTich()
        {
            return base.dienTich() + R*R * PI;
        }
    }
}
