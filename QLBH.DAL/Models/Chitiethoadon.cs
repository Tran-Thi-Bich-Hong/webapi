using System;
using System.Collections.Generic;

#nullable disable

namespace QLBH.DAL.Models
{
    public partial class Chitiethoadon
    {
        public int Id { get; set; }
        public int ChitietId { get; set; }
        public int HanghoaId { get; set; }
        public int Soluong { get; set; }
       
        public virtual Hoadon Hoadon { get; set; }
        public virtual Hanghoa Hanghoa { get; set; }
    }
}
