#pragma checksum "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6890531cb8076561fd2fc453f4466f52e961a87b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TemperatureReader.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace TemperatureReader.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\_ViewImports.cshtml"
using TemperatureReader;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6890531cb8076561fd2fc453f4466f52e961a87b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4cb6e9faa2fe91e30946f437fe39be391bddd57", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
  
    ViewData["Title"] = "Temperature Reader";

    String chartTitle = "Temperature chart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
 foreach (var data in Model.temperatureStatisticsList)
{
    Model.sampleTime = data.SampleTime;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<meta http-equiv=\"refresh\" content=\"5\">\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Temperature logger</h1>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6890531cb8076561fd2fc453f4466f52e961a87b4371", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['corechart'] });
		google.charts.setOnLoadCallback(drawChart); function drawChart() {
	    var data = google.visualization.arrayToDataTable(
		    [['Time', 'Temperature'],
");
#nullable restore
#line 25 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
             foreach (var temperature in Model.temperatureStatisticsList)
            {
                if (temperature.TemperatureUnit == "Celsius         ")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                     foreach (var data in Model.temperatureList) {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("[\'");
#nullable restore
#line 30 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                       Write(data.TimeStampo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', ");
#nullable restore
#line 30 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                          Write(data.Celsius);

#line default
#line hidden
#nullable disable
                WriteLiteral("],");
#nullable restore
#line 30 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                     
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                     
                }
                else
                {
                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                      foreach (var data in Model.temperatureList) {
                     

#line default
#line hidden
#nullable disable
                WriteLiteral("[\'");
#nullable restore
#line 36 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                        Write(data.TimeStampo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', ");
#nullable restore
#line 36 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                           Write(data.Fahrenheit);

#line default
#line hidden
#nullable disable
                WriteLiteral("],");
#nullable restore
#line 36 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                         
                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                      
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\t    ]);\r\n\t    var options = {\r\n\t\t    title: \'");
#nullable restore
#line 42 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
               Write(chartTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n\t\t    curveType: \'function\',\r\n\t\t    pointsVisible: false,\r\n\t\t    lineWidth: 2,\r\n\t\t    legend: \'none\',\r\n\t\t\thAxis: { title: \'Time\' },\r\n");
#nullable restore
#line 48 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
             foreach (var data in Model.temperatureStatisticsList) {
				Model.chartUnit = data.TemperatureUnit;
			}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t    vAxis: { title: \'");
#nullable restore
#line 51 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                        Write(Model.chartUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' },
		    width: '100%', height: '100%',
		    chartArea: { width: '90%', height: '60%' }
	    };
	        var chart = new google.visualization.LineChart(document.getElementById('line_chart'));
	            chart.draw(data, options);
		}
    </script>

    <div class=""container-fluid lead"">
        <div id=""line_chart"" style=""width: 1000px; height: 600px""></div>
    </div>

    <input type=""submit"" value=""Change Temperature Unit"" id=""submitButton"" />

    <table align=""right"">
        <tbody>
");
#nullable restore
#line 68 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
             foreach (var temperature in Model.temperatureStatisticsList)
            {
                if (temperature.TemperatureUnit == "Celsius         ")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr> <th> Average Temperature </th> <td align=\"right\"> ");
#nullable restore
#line 72 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                      Write(temperature.AverageCelsius);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8451;</td> </tr>\r\n                    <tr> <th> Minimum Temperature </th> <td> <td align=\"right\"> ");
#nullable restore
#line 73 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                           Write(temperature.MinCelsius);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8451;</td> </tr>\r\n                    <tr> <th> Maximum Temperature </th> <td> <td align=\"right\"> ");
#nullable restore
#line 74 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                           Write(temperature.MaxCelsius);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8451;</td> </tr>\r\n");
#nullable restore
#line 75 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr> <th> Average Temperature </th> <td> <td align=\"right\"> ");
#nullable restore
#line 78 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                           Write(temperature.AverageFahrenheit);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8457;</td> </tr>\r\n                    <tr> <th> Minimum Temperature </th> <td> <td align=\"right\"> ");
#nullable restore
#line 79 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                           Write(temperature.MinFahrenheit);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8457;</td> </tr>\r\n                    <tr> <th> Maximum Temperature </th> <td> <td align=\"right\"> ");
#nullable restore
#line 80 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                                                                           Write(temperature.MaxFahrenheit);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8457;</td> </tr>\r\n");
#nullable restore
#line 81 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>

    <div style=""width:275px;height:200px;overflow:auto;"">

        <table align=""left"" border=""1"" width=""250"">
            <thead>
                <tr>
                    <th> TimeStamp </th>
                    <th> Celsius </th>
                    <th> Fahrenheit </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 98 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                 foreach (var temperature in Model.temperatureList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 101 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                        Write(temperature.TimeStampo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" hh:mm:ss</td>\r\n                        <td> ");
#nullable restore
#line 102 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                        Write(temperature.Celsius);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8451;</td>\r\n                        <td> ");
#nullable restore
#line 103 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                        Write(temperature.Fahrenheit);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &#8457;</td>\r\n                    </tr>\r\n");
#nullable restore
#line 105 "C:\Users\hnv91\OneDrive\Skrivebord\Fag\Høst 2020\Systems and control laboratory\Industry 4-0 lab\asp\vs-asp\TemperatureReader\TemperatureReader\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591