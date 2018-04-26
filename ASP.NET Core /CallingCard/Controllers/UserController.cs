using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        [Route("{first_name}/{last_name}/{age}/{fav_color}")]
        public JsonResult DisplayUserInfo(string first_name, string last_name, int age, string fav_color)
        {
            var user = new {
                FirstName = first_name,
                LastName = last_name,
                Age = age,
                FavoriteColor = fav_color
            };
            return Json(user);
        }
    }
}