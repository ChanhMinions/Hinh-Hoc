using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class HinhCn : Hinhhoc
    {
        public HinhCn() { }

        public HinhCn(float chieuDai, float chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public float ChieuDai { get; set; }
        public float ChieuRong { get; set; }

        public override float chuVi()
        {
            return base.chuVi() + (ChieuDai + ChieuRong) *2;
        }

        public override float dienTich()
        {
            return base.dienTich() + (ChieuDai * ChieuRong);
        }


    }
}
