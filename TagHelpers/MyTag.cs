﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.TagHelpers
{
    
    public class MyTag : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";    // заменяет тег <timer> тегом <div>
                                       // устанавливаем содержимое элемента
            output.Content.SetContent($"Текущее время: {DateTime.Now.ToString("HH:mm:ss")}");
        }
    }
}
