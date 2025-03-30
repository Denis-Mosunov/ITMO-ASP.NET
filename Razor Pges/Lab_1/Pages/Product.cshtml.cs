using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        public string? MessageRezult { get; private set; }
        public Product Product { get; set; } = new();

        public void OnPost(string name, decimal? price)
        {
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
                return;
            }

            var result = price * 0.18m;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}