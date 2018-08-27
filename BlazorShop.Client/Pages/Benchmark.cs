﻿using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.RenderTree;

namespace BlazorShop.Client.Pages
{
    [Route("/benchmark")]
    public class DynamicRenderTree : BlazorComponent
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var seq = 0;
            builder.OpenElement(seq, "table");
            builder.OpenElement(++seq, "tbody");

            for (var row = 0; row < 3; row++)
            {
                builder.OpenElement(++seq, "tr");
                for (var col = 0; col < 3; col++)
                {
                    builder.OpenElement(++seq, "td");
                    builder.AddAttribute(++seq, "class", "tictactoe-cell");
                    builder.AddContent(++seq, seq % 2 == 0 ? "X": "O");
                    builder.CloseElement();
                }

                builder.CloseElement();
            }

            builder.CloseElement();
            builder.CloseElement();
        }
    }
}