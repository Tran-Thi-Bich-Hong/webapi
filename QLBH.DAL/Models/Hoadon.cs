using Confluent.Kafka;
using System;
using System.Collections.Generic;

#nullable disable

namespace QLBH.DAL.Models
{
    public partial class Hoadon
    {
       
      

        public int Id { get; set; }
        public int IdNv { get; set; }
        public int Thanhtien { get; set; }
        public int Idkhach { get; set; }

        public virtual User IdNvNavigation { get; set; }
        public virtual Khachhang IdkhachNavigation { get; set; }

        public virtual List<Chitiethoadon> Chitiethoadons { get; set; }

       

    }
}
