using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
        public Product Product { get; set; }

        public void OnGet(string name, decimal? price)
        {
            if (!string.IsNullOrEmpty(name) && price > 0)
            {
                Product = new Product
                {
                    Name = name,
                    Price = price.Value
                };
            }
        }
    }
}
