#pragma checksum "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\Pages\Components\TemplateParametersWithContext\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13380634bb2f9585261c814f710f40dc6b5f01e4"
// <auto-generated/>
#pragma warning disable 1591
namespace Masterthesis.UI.Pages.Components.TemplateParametersWithContext
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Masterthesis.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\_Imports.razor"
using Masterthesis.UI.Shared;

#line default
#line hidden
#nullable disable
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, 
#nullable restore
#line 1 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\Pages\Components\TemplateParametersWithContext\Counter.razor"
    CurrentCountDisplay(currentCount)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\Pages\Components\TemplateParametersWithContext\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\Pages\Components\TemplateParametersWithContext\Counter.razor"
       
    [Parameter]
    public RenderFragment<int> CurrentCountDisplay { get; set; }

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount = currentCount + 1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
