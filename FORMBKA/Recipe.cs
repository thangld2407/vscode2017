using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMBKA
{
    class Recipe
    {
        private int totalKhoiLuong;
        private int xiMang;
        private int cat;
        private int troBay;
        private int khoang;
        private int pg1;
        private int pg2;
        private int pg3;


        public Recipe(
            int totalKhoiLuong, int xiMang, int cat, int troBay, int khoang, int pg1, int pg2, int pg3
            )
        {
            this.totalKhoiLuong = totalKhoiLuong;
            this.xiMang = xiMang;
            this.cat = cat;
            this.troBay = troBay;
            this.khoang = khoang;
            this.pg1 = pg1;
            this.pg2 = pg2;
            this.pg3 = pg3;
        }

    }
}
