using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuGiaBao.Models
{
    public class Giohang
    {
        Model1 db = new Model1();
        public int id { get; set; }
        [Display(Name = "Mã lịch chiếu")] public string malich { get; set; }
        [Display(Name = "Mã phim")] public string maphim { get; set; }
        [Display(Name = "Tên phim")] public string tenphim { get; set; }

        [Display(Name = "Giá")] public Double gia { get; set; }
        [Display(Name = "Số lượng")] public int iSoluong { get; set; }
        [Display(Name = "Thành tiền")] 
        public Double dThanhtien
        {
            get { return iSoluong * gia; }
        }
       public Giohang(string id)
        {
            malich = id;
            LichChieu lich = db.LichChieux.Single(n => n.malich == malich);
            tenphim = lich.Phim.tenphim;
            gia = double.Parse(lich.gia.ToString());
            iSoluong = 1;
        }

        public Giohang(int id)
        {
            this.id = id;
        }
    }
}