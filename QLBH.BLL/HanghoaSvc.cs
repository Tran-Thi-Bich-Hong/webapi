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

    public class HanghoaSvc : GenericSvc<HanghoaRep, Hanghoa>
    {
        private HanghoaRep hanghoaRep;
        #region -- Overrides --

        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }
        public HanghoaSvc(){
            hanghoaRep = new HanghoaRep();

        }
        #endregion
       
    }
}
