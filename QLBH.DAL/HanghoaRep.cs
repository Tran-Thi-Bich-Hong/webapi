using QLBH.Common.DAL;
using QLBH.Common.Rsp;
using QLBH.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBH.DAL
{
    public class HanghoaRep : GenericRep<dbblContext, Hanghoa>
    {
        #region -- Overrides --

        public override Hanghoa Read(int id)
        {
            var res = All.FirstOrDefault(p => p.IdHh == id);
            return res;
        }


        public int Remove(int id)
        {
            var m = base.All.First(i => i.IdHh == id);
            m = base.Delete(m);
            return m.IdHh;
        }

        #endregion
        #region -- Methods --
        public SingleRsp LayhhbyId(int id)
        {
            var res = new SingleRsp();
            res.Data = All.Where(x => x.IdHh == id).Select(x => x.Giahang);
            return res;
        }
        #endregion



    }
}

