using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        // Get method
        [HttpGet]
        [Route("http://localhost:5000/index")]
        public string Index()
        {
            return "Hello World! How are you ? ";
        }

        public JsonResult Example()
        {
            return Json(someC#Object);
        }

        // with parameters
        // [HttpGet]
        // [Route("template/{Name}")]
        // public IActionResult Method(string Name){
        //     //Method bodt
        // }

        //Post method
        // [HttpPost]
        // [Route("")]
        // public IActionResult Other(){
        //     //Return a view. 
        // }
    }

}