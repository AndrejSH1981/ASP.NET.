using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {

        //public bool IsCorrect { get; set; } = true;
        public Product Product { get; set; }
        public string MessageRezult { get; private set; }
        public string MessageRezult1 { get; private set; }

        /*public string Name { get; set; }
        public decimal? Price { get; set; }
        public bool IsCorrect { get; set; } = true;*/
        //decimal result;
        //decimal resultDiscont;
        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
                return;
            }
            var result = (decimal)(price * (decimal?)0.18);
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;
            //OnPostKeshbackDiscont();
        }

   /*     public void OnPostKeshback(string name, decimal? price, double discont)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
                return;
            }

            var result = price * (decimal?)0.18;
            var resultkeshback = (price * (decimal?)0.18) * (decimal?)0.20;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result} %";
            MessageRezult1 = $"������ {resultkeshback} ";
            Product.Price = price;
            Product.Name = name;
        }*/



        public void OnGet()
        {
            MessageRezult = "��� ������ ����� ���������� ������";
            MessageRezult1 = " � �������� ������ 20% �� ������";
        }

        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();
            var resultDiscont = ((decimal)(price * (decimal?)discont / 100));
            MessageRezult = $"��� ������ {name} � ����� {price} � ������� {discont} % ��������� {resultDiscont}";
            Product.Price = price;
            Product.Name = name;
           // OnPostKeshbackDiscont();
        }

        public void OnPostKeshbackDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();

           var result = (decimal)(price);
           

            var d1 = result;
            

            var resultkeshback = (d1) * (decimal?)0.10;
           MessageRezult = $"��� ������ {name} � ����� {price} ��������� �������� {resultkeshback}";


            Product.Price = price;
            Product.Name = name;
          
        }





        /*public void OnGet()
        {
        }
        */



        }
}
