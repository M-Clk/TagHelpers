using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("button",Attributes ="bs-button-color",ParentTag="form")]
    //Parent tag ile bu bu tag helper sadece form icinde yazilirsa calisacaktir.
    //button yazarak bu attribute un sadece button etiketi icin calismasini sagladik. Boylece kendi yazdigimiz attribute u tek etiket ile sinirlamis olduk.
    public class ButtonTagHelper:TagHelper
    {
        
        public string BsButtonColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
        }
    }
}
