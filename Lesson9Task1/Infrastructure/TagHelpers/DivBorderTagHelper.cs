using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Lesson9Task1.Infrastructure.TagHelpers
{
    public class DivBorderTagHelper : TagHelper
    {
        public string MyBorderColor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "div", StringComparison.OrdinalIgnoreCase))
            {
                string borderColor = MyBorderColor ?? "black";

                // Добавление класса вместо стиля
                output.Attributes.SetAttribute("class", $"my-bordered-div my-border-{borderColor}");
            }
        }
    }
}
