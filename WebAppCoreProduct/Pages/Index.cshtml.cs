using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {

     /*  public bool IsCorrect { get; set; } = true;
        public Product Product { get; set; }
        public string MessageRezult { get; private set; }*/


        /*public string Name { get; set; }
        public decimal? Price { get; set; }
        public bool IsCorrect { get; set; } = true;*/


      /*  public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }
        */

        public void OnGet()
        {
            //MessageRezult = "��� ������ ����� ���������� ������";
        }
       






        /*  public void OnGet(string name, decimal? price)
          {
              Product = new Product();
              if (price == null || price < 0 || string.IsNullOrEmpty(name))
              {
                  IsCorrect = false;
                  return;
              }
              Product.Price = price;
              Product.Name = name;

              var result = price * (decimal?)0.18;
              MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";

          }

          */





        /*  if (price == null || price < 0 || string.IsNullOrEmpty(name))
          {
              IsCorrect = false;
              return;
          }
          Price = price;
          Name = name;*/



        //https://localhost:���_����/Index?name=Tomato&price=31



    }
    }

