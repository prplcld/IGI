using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Components
{
    public class DateViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return $"Текущая дата: {DateTime.Now.ToString("dddd, MMM dd yyyy")}";
        }
    }
}
