using QLBH.Common.BLL;
using QLBH.Common.Req;
using QLBH.Common.Rsp;
using QLBH.DAL;
using QLBH.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.BLL
{
    public class ChitietHoadonSvc : GenericSvc<ChitietHoaDonRep, Chitiethoadon>
    {
        private ChitietHoaDonRep chitietHoaDonRep;
        public ChitietHoadonSvc()
        {
            chitietHoaDonRep = new ChitietHoaDonRep();
        }
        #region -- Overrides --
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }
        #endregion
        #region -- Methods --
        public SingleRsp Themhoadon(HoadonReq hoadonReq)
        {
            var res2 = new SingleRsp();
            Chitiethoadon chitiethoadon = new Chitiethoadon();
            chitiethoadon.ChitietId = hoadonReq.MaHoaDon;
            chitiethoadon.HanghoaId = hoadonReq.MaHangHoa;
            chitiethoadon.Soluong = hoadonReq.SoLuong;
            res2 = chitietHoaDonRep.Themhoadon(chitiethoadon);
            return res2;
        }
       
        #endregion
    }
}
