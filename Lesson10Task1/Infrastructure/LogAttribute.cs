using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace Lesson10Task1.Infrastructure
{
    public class LogAttribute: ActionFilterAttribute
    {
        private string dateTimeNow;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            dateTimeNow = DateTime.Now.ToString("HH-mm-ss-fff");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            string message = $"Метод {context.ActionDescriptor.DisplayName} начал выполнятся {dateTimeNow}, а закончился свою работу {DateTime.Now.ToString("HH-mm-ss-fff")}";
            StreamWriter streamWriter = new StreamWriter("App_Data/log.txt", true);
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }
    }
}
