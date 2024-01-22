using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        Data data = new Data();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            data.Num1 = int.Parse(Request.Form["num1"]);
            data.Num2 = int.Parse(Request.Form["num2"]);
            data.Operation = char.Parse(Request.Form["operation"]);

            if (data.Operation.ToString() == "+")
            {
                data.Result = data.Num1 + data.Num2;
            }
            else if(data.Operation.ToString() == "-")
            {
                data.Result = data.Num1 - data.Num2;
            }
            else if (data.Operation.ToString() == "/")
            {
                data.Result = data.Num1 / data.Num2;
            }
            else
            {
                data.Result = data.Num1 * data.Num2;
            }
            return View("Result", data);
        }


        public IActionResult Result()
        {
            return View();
        }

    }
}
