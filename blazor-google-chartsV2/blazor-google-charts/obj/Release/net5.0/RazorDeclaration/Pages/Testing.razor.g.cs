// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
<<<<<<< HEAD:blazor-google-chartsV2/blazor-google-charts/obj/Release/net5.0/RazorDeclaration/Pages/Testing.razor.g.cs
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileImport")]
    public partial class Testing : Microsoft.AspNetCore.Components.ComponentBase
=======
    public partial class Component : Microsoft.AspNetCore.Components.ComponentBase
>>>>>>> parent of 32057c2 (working version with zoom to share):blazor-google-chartsV2/blazor-google-charts/obj/Debug/net5.0/RazorDeclaration/Pages/Component.razor.g.cs
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
<<<<<<< HEAD:blazor-google-chartsV2/blazor-google-charts/obj/Release/net5.0/RazorDeclaration/Pages/Testing.razor.g.cs
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
=======
>>>>>>> parent of 32057c2 (working version with zoom to share):blazor-google-chartsV2/blazor-google-charts/obj/Debug/net5.0/RazorDeclaration/Pages/Component.razor.g.cs
    }
}
#pragma warning restore 1591
