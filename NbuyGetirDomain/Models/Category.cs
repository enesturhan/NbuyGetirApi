using NbuyGetir.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Domain.Models
{
    public class Category :Entity
    {
        public string Name { get; set; }
        /// <summary>
        /// ekranda ilk acılısta en üst seviye olan kategorileri listeleyeceğiz bu üst seviye altına eklene alt kategorilerir ise ürünler ile bağlayacağız. ürünler istoplevel olarak isaretlenmemis altına girilecekler.
        /// </summary>
        public bool IsTopLevel { get; private set; } //en üst seviye kategori mi


        private List<Category> _subCategories = new();
        public IReadOnlyCollection<Category> SubCategories => _subCategories;

        private List<Product> _products = new();
        public IReadOnlyCollection<Product> Products => _products;

        public Category(string name, bool isTopLevel=false) 
        {
            SetName(name);
            IsTopLevel = isTopLevel;
        }
        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("kategori bos gecilemez");
            }
        }
        public void AddSubCategory(Category category)
        {
            if (string.IsNullOrEmpty(category.Name))
            {
                throw new Exception("Categori ismi bos gecilemez");
                

            }
            //dısarıdan üst seviye olan bir kategori baska bir kategorinin alt kategorisi olamaz
            if (category.IsTopLevel)
            {
                throw new Exception("top level kategori baska bir kategori altına atılamaz");
            }
            _subCategories.Add(category);
           

        }
        public void AddProduct(Product product)
        {
            //en üst seviye bir kategori degilsse ve aynı zamanda kendi altında bir kategori yoksa en alt kategoridir.
            if (!IsTopLevel && _subCategories.Count()==0)
            {
                _products.Add(product);
            }
        }
    }
}
