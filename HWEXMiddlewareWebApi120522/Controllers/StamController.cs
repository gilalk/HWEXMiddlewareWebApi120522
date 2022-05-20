using Microsoft.AspNetCore.Mvc;

namespace HWEXMiddlewareWebApi120522.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class StamController
    {
        public string Action1()
        {
            return "Action 1";
        }

        public string Action2()
        {
            return "Action 2";
        }
    }
}
