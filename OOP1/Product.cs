using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet
    internal class Product
    {
        //ürün ıd numarası
        public int Id { get; set; }
        //ürün kategorisi
        public int CategoryId { get; set; }
        //ürün ismi
        public string ProductName { get; set; }
        //ürün birim fiyatı
        public double UnitPrice { get; set; }
        //ürün stok adedi
        public int UnitsInStock { get; set; }

        //CRUD= Create, Read, Update, Delete = Programlamada oluşturma, okuma, güncelleme ve silme
        
    }
}
