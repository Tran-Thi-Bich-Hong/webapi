using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLBH.BLL;
using QLBH.Common.Req;
using QLBH.Common.Rsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HanghoaController : ControllerBase
    {
        private HanghoaSvc hanghoaSvc;
        public HanghoaController(){
            hanghoaSvc = new HanghoaSvc();
        }
       
    }
}
