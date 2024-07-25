using MeetingApp.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        // localhost
        // localhost/home
        // localhost/home/index
        public IActionResult Index()
        {
            int saat = 10;
            
           // ViewBag.selamlama = saat>12 ? "İyi Günler":"Günaydın";
           // ViewBag.UserName = "Yasir"; 

            ViewData["Selamlama"] =  saat>12 ? "İyi Günler":"Günaydın";
            int UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();

            // ViewData["UserName"] = "Yasir";


            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul Kongre Merkezi",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople =  UserCount
            };
            return View(meetingInfo);    
        }

    }
}