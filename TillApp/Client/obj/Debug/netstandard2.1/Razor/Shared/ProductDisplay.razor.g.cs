#pragma checksum "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d5eeb4d73cda2991ac1c30e30a017e8e941979"
// <auto-generated/>
#pragma warning disable 1591
namespace TillApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\_Imports.razor"
using TillApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\_Imports.razor"
using TillApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
using TillApp.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class ProductDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                      order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "form-inline");
            __builder.AddAttribute(6, "style", "margin-bottom: 10px;");
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                                                                               async () => await saveOrder()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "p");
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "placeholder", "Order Name Here");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                              order.OrderName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.OrderName = __value, order.OrderName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "p");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "text");
                __builder2.AddAttribute(34, "id", "amount");
                __builder2.AddContent(35, " ");
                __builder2.AddContent(36, 
#nullable restore
#line 17 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                    order.Amount

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(37, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<div class=\"col\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Place Order</button>\r\n        </div>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 30 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
     if (products == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "        ");
            __builder.AddMarkupContent(48, "<tex>Loading...</tex>\r\n");
#nullable restore
#line 33 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
    }
    else if (products.Length == 0)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, " There Are no Products ");
#nullable restore
#line 36 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                            
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "            ");
            __builder.OpenComponent<TillApp.Client.Shared.ProductItem>(51);
            __builder.AddAttribute(52, "EventFromChild", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TillApp.Shared.Models.Item>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TillApp.Shared.Models.Item>(this, 
#nullable restore
#line 42 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                         TriggerFromChild

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(53, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                                               product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "imgSrc", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                                                                    product.ImgSrc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "productName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                                                                                                  product.ProductName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "Price", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 42 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
                                                                                                                                               product.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 43 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\speedTECH\source\repos\TillApp\TillApp\Client\Shared\ProductDisplay.razor"
       
    List<Item> itemsInCart = new List<Item>();
    Product[] products { get; set; }
    Order order = new Order();

    protected override async Task OnInitializedAsync()
    {
        await LoadProducts();
    }

    async Task LoadProducts()
    {
        products = await http.GetJsonAsync<Product[]>("api/products");
    }

    private void TriggerFromChild(Item item)
    {
        StateHasChanged();
        if (itemsInCart.Count == 0)
        {
            itemsInCart.Add(item);
        }
        else
        {
            var itemFromList = itemsInCart.Where(x => x.ProductID == item.ProductID).FirstOrDefault();
            if (itemFromList == null)
            {
                itemsInCart.Add(item);
            }
            else
            {
                if (item.Quantity == 0)
                {
                    itemsInCart.RemoveAll(x => x.ProductID == item.ProductID);
                }
                else
                {
                    itemFromList.Quantity = item.Quantity;
                    var tempProduct = products.Where(x => x.Id == item.ProductID).FirstOrDefault();
                    itemFromList.Cost = tempProduct.Price * item.Quantity;
                }
            }
        }


        order.Amount = itemsInCart.Sum(x => x.Cost);
    }


    private async Task saveOrder()
    {

        order.Items = itemsInCart;
        await http.SendJsonAsync(HttpMethod.Post, "api/orders", order);
        
        navigation.NavigateTo("/", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
