using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Volkau_Html_Intro.Models;
using Volkau_Html_Intro.Extensions;

namespace Volkau_Html_Intro.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;

        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}