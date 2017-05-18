using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PusherServer;
using System.Net;
using System.Threading.Tasks;

namespace pusherasp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<ActionResult> Pushermessage(String message)
        {
            var options = new PusherOptions();
            options.Cluster = "XXX_CLUSTER";
            var pusher = new Pusher("XXX_APP_ID", "XXX_APP_KEY", "XXX_APP_SECRET", options);
            ITriggerResult result = await pusher.TriggerAsync("asp_channel", "asp_event", new { message = message, name = "Anonymous" });
           
            return new HttpStatusCodeResult((int)HttpStatusCode.OK);

        } 
    }
}