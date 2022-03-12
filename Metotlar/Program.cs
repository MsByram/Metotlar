using System;

namespace Metotlar
{
    class Metotlar
    {
        static void Main(string[] args)
        {

            string[] Sepet = new string[] { };

            Product product1 = new Product();
            product1.productName = "Tuz";
            product1.productExplanation = "Kaya tuzu";
            product1.productPrice = 45;

            Product product2 = new Product();
            product2.productName = "Saf Tuz";
            product2.productExplanation = "Kristal Tuz";
            product2.productPrice = 0.80 ;

            Product[] products = new Product[] { product1, product2 };


            //type safe -- tip güvenliği
            foreach (var product in products)
            {
                
                Console.WriteLine("Ürün Fiyatı:"+product.productPrice + " : " 
                    + "Ürün Adı:"  + product.productName + " : " + 
                    "Ürün Açıklaması:"+product.productExplanation);
                Console.WriteLine("**************");

            }

            Console.WriteLine("********Metotlar*********");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

        }
    }
}
