#pragma checksum "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\Pages\Components\ChildContent\Alert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35aa57f4c45361c8962cc63ca2b62b7286c1cd2"
// <auto-generated/>
#pragma warning disable 1591
namespace Masterthesis.UI.Pages.Components.ChildContent
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
    public partial class Alert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-primary");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddContent(3, 
#nullable restore
#line 2 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\Pages\Components\ChildContent\Alert.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Alex\Documents\Masterarbeit\Blazor DSL\Sourcecode\Source\Masterarbeit\UI\Pages\Components\ChildContent\Alert.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
