using System;
using System.Collections.Generic;

#nullable disable

namespace QLBH.DAL.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public int Idkhachhang { get; set; }
        public string Tenkh { get; set; }
        public string Ngaysinh { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
