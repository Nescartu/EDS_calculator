#pragma checksum "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c8d37804ce8d3da8b1690dbdfe7d7ef188545b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGoogleCharts.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using BlazorGoogleCharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using BlazorGoogleCharts.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileImport")]
    public partial class Testing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container bg-white mx-auto text-center p-5");
            __builder.AddMarkupContent(2, "<div class=\"display-6\">EDS calculator</div>\r\n\r\n    <div id=\"chart_div\" class=\"card shadow m-5\" style=\"height: 400px;\"></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-inline-block m-4");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor"
                                                  () => PlotRandomXY(cleanDataX.ToArray(), cleanDataY.ToArray())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Write");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.OpenElement(11, "textarea");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor"
                                                () => PlotRandomXY(cleanDataX.ToArray(), cleanDataY.ToArray())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor"
                         Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.OpenElement(17, "textarea");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor"
                                                 () => PlotRandomXY(cleanDataX.ToArray(), cleanDataY.ToArray())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor"
                         Description2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description2 = __value, Description2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-inline-block m-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(24);
            __builder.AddAttribute(25, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 26 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor"
                                                                    OnInputFileChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, " id=\"flpicker\" ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\Testing.razor"
      
    private void PlotData(double[] xs, double[] ys)
    {
        JsRuntime.InvokeVoidAsync("createNewChart", new { xs, ys });
    }




    string dataFromFile;
    public string Description { get; set; } = "nothing here";
    public string Description2 { get; set; } = "nothing here";

    // Variables for filtering, contains clean data for plotting
    public static List<double> cleanDataX = new List<double>();
    public static List<double> cleanDataY = new List<double>();
    public static List<string> cleanText = new List<string>();

    private void PlotRandomXY(double[] xData, double[] yData)
    {
        Description = "";
        Description2 = "";
        foreach (double item in xData)
        {
            Description = Description + item.ToString() + "\n";
        }

        foreach (double item2 in yData)
        {
            Description2 = Description2 + item2.ToString() + "\n";
        }

        PlotData(xData, yData);
    }


    private async Task OnInputFileChanged(InputFileChangeEventArgs inputFileChangeEvent)
    {
        var file = inputFileChangeEvent.File;

        var buffer = new byte[file.Size];
        await file.OpenReadStream().ReadAsync(buffer);

        dataFromFile = System.Text.Encoding.UTF8.GetString(buffer);

        FilterDataNoran(dataFromFile);
    }



    private void FilterDataNoran(string rawData)
    {
        string[] rawDataArray = rawData.Split("\n");
        int i = 0;
        bool spectrum = false;

        foreach (var data in rawDataArray)
        {
            var dataCleaned = data.Trim(new Char[] { ' ', '\n', '\r', '\'' });
            if (dataCleaned.Contains("#SPECTRUM"))
            {
                spectrum = true;
            }
            else if (spectrum) // so the first run with Spectrum in the text is not parsed
            {
                var dataCleanedSpectrum = dataCleaned.Split(",");
                bool isDoubleX = double.TryParse(dataCleanedSpectrum[i], out double doubleElementX);
                bool isDoubleY = double.TryParse(dataCleanedSpectrum[i + 1], out double doubleElementY);
                if (isDoubleX & isDoubleY)
                {
                    cleanDataX.Add(doubleElementX);
                    cleanDataY.Add(doubleElementY);
                }
            }
            else
            {
                cleanText.Add(dataCleaned);
            }
        }

    }



    private List<double> FilterDataThermo(string rawData)
    {
        string[] rawDataArray = rawData.Split(";");

        string[] splitData = new string[rawDataArray.Length];
        List<double> cleanData = new List<double>();
        List<string> cleanText = new List<string>();

        foreach (var data in rawDataArray)
        {
            var dataCleaned = data.Trim(new Char[] { ' ', '\n', '\r', '\'' });
            bool isDouble = double.TryParse(dataCleaned, out double doubleElement);
            if (isDouble)
            {
                cleanData.Add(doubleElement);
            }
            else
            {
                cleanText.Add(dataCleaned);
            }
        }
        return cleanData;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
