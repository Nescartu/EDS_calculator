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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fileinput")]
    public partial class ImportFile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "F:\C_sharp\2021_12_27\EDS_calculator\blazor-google-chartsV2\blazor-google-charts\Pages\ImportFile.razor"
       
    public string ProfilePicDataUrl { get; set; }

    private async Task OnInputFileChanged(InputFileChangeEventArgs inputFileChangeEvent)
    {
        var file = inputFileChangeEvent.File;

        var buffer = new byte[file.Size];
        await file.OpenReadStream().ReadAsync(buffer);

        ProfilePicDataUrl = $"data:image/png;base64,{Convert.ToBase64String(buffer)}";

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
