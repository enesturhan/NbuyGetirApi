using NbuyGetir.Common.Uri;
using NbuyGetir.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NbuyGetir.Domain.Models
{
    public class Product :AuditableEntity
    {
       

        public string   Name { get;private set; }
        public decimal UnitPrice { get;private set; }
        public decimal ListPrice { get;private set; }
      
        public int Stock { get; set; }

        public decimal DiscountedListPrice { get; private set; }

        public string Description { get; set; } //10*1

        public string PictureUrl { get; set; }
        //indirimli olup olmadıgını saklamayacagız zate  bu elimie bu property tarafından indirimli ürün olup olmadıgını bıluyoruz ürün indirimli mi
        //sadece get oldugu icin set olmadıgı icin veri tabanına atma
        public bool IsDiscounted { get
            {
                return DiscountedListPrice < ListPrice ? true : false;
            } }
        public bool IsStockInCriticalLevel { get
            {
                return Stock < 10 ? true : false;
            }
        }

        public Product(string name, decimal unitPrice, decimal listPrice, double discountAmount, int stock, string description, string pictureUrl,decimal disCountedListPrice)
        {
            SetName(name);
            SetPrice(unitPrice, listPrice, disCountedListPrice);
            SetDescription(description);
            SetStock(stock);
        
        }
        //eğer bos ise default ürüne ait bir url verelim
        public void SetPicture(string pictureUrl)
        {
          

            if (!UrlHelper.IsUrl(pictureUrl))
            {
                throw new Exception("resim yolu dogru formatta degil");
            }
            if (string.IsNullOrEmpty(pictureUrl))
            {
                PictureUrl = "default-product.jpeg";
            }
            else
            {
                PictureUrl = pictureUrl.Trim();
            }
         

        }
    
        private void SetStock(int stock)
        {
            if (stock < 0)
            {
                throw new Exception("stok değeri 0dan kucuk olamaz");

            }

            Stock = stock;

        }
        /// <summary>
        /// stoklama islemi ürünün envantere girilme işlemii
        /// </summary>
        public void StockIn(int quantity)
        {
            if (quantity <= 0)
            {
                throw new Exception("stoga girilecek rünü adeti 0 ve daha düsük olamaz");
            }
            Stock += quantity;

        }
        public void StockOut(int quantity)
        {
            if (quantity <0)
            {
                throw new Exception("0 dan kücük bir değer stok tan düsülemez");

            }
            if (IsStockInCriticalLevel)
            {
                //kritik stok seviyesindeki bir ürün siparis edildi diye bir mesaj atalım.
            }
            if (quantity > Stock)
            {
                //hatalı kayıt gonderme islemi
                throw new Exception("stocktan düsülen miktar stock değerinden fazla olamaz");

            }
            Stock -= quantity;
        }



        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("ürün ismi bos gecilemez");
            }
            Name = name.Trim();
        }


        public void SetDescription(string desciription)
        {
            if (string.IsNullOrEmpty(desciription)){
                throw new Exception("ürün acıklamasını doludurnuz");

            }
            if (desciription.Length < 50)
            {
                throw new Exception("Maximum 50 karakter girilir");

            }

            Description = desciription.Trim();

        }

        /// <summary>
        /// ürüne ait fiyatların değisimini bu method ile yapacagız
        /// </summary>
        /// <param name="unitPrice"></param>
        /// <param name="listPrice"></param>
        /// <param name="discounListPrice"></param>
        public void SetPrice(decimal unitPrice,decimal listPrice,decimal discounListPrice)
        {
            if (unitPrice > listPrice)
            {
                throw new Exception("birim fiyat liste fiyatından büyük olamaz");

            }
            if(unitPrice<=0 || listPrice <= 0 || discounListPrice<=0)
            {
                throw new Exception("ürün fiyatı veya ürün satıs fiyatı negatif değer alamaz ve inidirmli satıs fiyatı 0 dan kucuk olamaz");
            }

            if (discounListPrice > listPrice)
            {
                throw new Exception("İNDİRİMLİ fiyat satıs fiyatından fazla olamaz");

            }
            if (discounListPrice < unitPrice)
            {
                throw new Exception("İndirimli satıs fiyatı birim fiyattan kucuk olamaz");

            }
            ListPrice = listPrice;
            UnitPrice = unitPrice;
            DiscountedListPrice = discounListPrice;

                
        }
        /// <summary>
        /// bu method ile bir ürününü satıs fiyatına belirli bir oranda inidirm ypaılır indirim oranı güncellenir sadece program tarafında discount list price tutaacagız bu indiriml fiyatımız olucaktır.
        /// unit price 11
        /// listprice 13
        /// discountedlist preice 12.5
        /// </summary>
        /// <param name="discountAmount"></param>
        public void DescreacePrice(decimal newPrice) //ürünün satıs fiyatına indirim ypa.
        {

            if (newPrice > ListPrice)
            {
                throw new Exception("İndirimli fiyat liste fiyatından büyük olamaz");
            }


            if (newPrice <= UnitPrice)
            {
                throw new Exception("indirimli fiyat birim fiyatından kucuk olamaz");

            }
            DiscountedListPrice = newPrice;
            

            //indirim uygula eventi fırlatacagız
            //bu ürünü favorisine eklyen ler mail atsın ürünün fiyatı düstü maili
        }
        /// <summary>
        /// ürünün fiyatı güncellenirse diye yapılıcak
        /// </summary>
        /// <param name="newListPrice"></param>
        /// <param name="newDiscountedListPrice"></param>
        public void IncreasePrice(decimal newListPrice ,decimal newDiscountedListPrice)
        {
            if (newListPrice < ListPrice)
            {
                throw new Exception("yeni fiyat liste fiyatından kucuk olamaz");
            }
            if (newDiscountedListPrice > newListPrice)
            {
                throw new Exception("indirimli fiyat yeni liste fiyatından büyük olamaz");
            }
            ListPrice = newListPrice;
            DiscountedListPrice = newDiscountedListPrice;

            //zamlı ürünleri event olarak fırlatabilirz.
        }
       

    }
}
