using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Components
{
    public class TimerViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return $"Текущее время: {DateTime.Now.ToString("hh:mm:ss")}";
        }
    }
}
