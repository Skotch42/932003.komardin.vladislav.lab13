#pragma checksum "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaeae2eb5b209af110ab642af218ef06ccf4f608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_QuizResult), @"mvc.1.0.view", @"/Views/Mockups/QuizResult.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaeae2eb5b209af110ab642af218ef06ccf4f608", @"/Views/Mockups/QuizResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Mockups_QuizResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab3.Models.QuizResultModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml"
  
    ViewBag.Title = "Quiz";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Quiz results</h2>\n<h4>Right answers ");
#nullable restore
#line 6 "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml"
             Write(Model.CorrectAnswerCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" out ");
#nullable restore
#line 6 "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml"
                                           Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n<ol>\n");
#nullable restore
#line 8 "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml"
     foreach (var question in Model.Questions) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 9 "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml"
       Write(question.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml"
                            Write(question.UserAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 10 "C:\Users\vlado\OneDrive\Рабочий стол\web\lab13\Lab3\Views\Mockups\QuizResult.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab3.Models.QuizResultModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
