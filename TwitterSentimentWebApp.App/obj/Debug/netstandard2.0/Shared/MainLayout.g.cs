#pragma checksum "G:\cdesktop\TwitterSentiment-master\TwitterSentimentWebApp\TwitterSentimentWebApp.App\Shared\MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17df2a6d0f2b7ecc1340fd16870d61024b8dda36"
// <auto-generated/>
#pragma warning disable 1591
namespace TwitterSentimentWebApp.App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using TwitterSentimentWebApp.App;
    using TwitterSentimentWebApp.App.Shared;
    public class MainLayout : BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "main");
            builder.AddContent(2, "\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "container-fluid");
            builder.AddContent(5, "\n        ");
            builder.AddContent(6, Body);
            builder.AddContent(7, "\n    ");
            builder.CloseElement();
            builder.AddContent(8, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
