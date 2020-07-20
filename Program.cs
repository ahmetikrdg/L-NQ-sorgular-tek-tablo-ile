using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EFD.Data.EfCore;

namespace EFD
{
    class Program
    {
        static void Main(string[] args)
        {
            /* tüm müşteri kayıtlarını getiriniz
            using (var db=new NorthwindContext())
            {            
                var customers=db.Customers.ToList();//bütün liste gelir

                foreach(var item in customers){
                    Console.WriteLine(item.FirstName);
                }
            }*/

            /*Tüm müşterilerin firstname ve lastnamei
            using (var db=new NorthwindContext())
            {            
                var Customers=db.Customers.Select(c=>new{
                    c.FirstName,
                    c.LastName
                });
                foreach(var item in Customers){
                    Console.WriteLine(item.FirstName+ " "+item.LastName);
                }
            }*/

            /*Newyorkta yaşayanları isim sırasına göre getir
            using (var db = new NorthwindContext())
            {
                var Customers = db.Customers.Where(i => i.City == "New York")
                .Select(s=>new{s.FirstName,s.LastName});//select yazmasanda olurdu whereden sonra .tolist yapardın forecahde isim soyismi yine alırdın
                foreach (var item in Customers)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }*/
            /* beverage ürünlerine ait tüm ürün ismini getir
            using (var db = new NorthwindContext())
            {
                var Customers = db.Products.Where(i => i.Category == "Beverages")
                .Select(s =>s.ProductName);//burada new onje olarak almana gerek yok çünkü bir kolon alıyosun o yüzden foreachta bile çağırmıyosun dikkat et belli zaten
                foreach (var item in Customers)
                {
                    Console.WriteLine(item);
                }
            }*/
            /* en son eklenen 5 ürün bilgisini alın
            using (var db = new NorthwindContext())
            {
                // var Customers = db.Products.Take(5);
                take dediğimde benden bir sayi bekler 5 dersem en üstten 5 ürünü alır
                dikkat en üstten 5 ürün alıyor ama bunlar benim ilk eklediğim ürünler şimdi tabloyu ters çevirelim

                var Customers = db.Products.OrderByDescending(i=>i.Id).Take(5);

                orderbyla azalan bir şekilde idye göre sıralayalım
                foreach (var item in Customers)
                {
                    Console.WriteLine(item.ProductName);
                }
            }*/

            /* Fiyatı 10 ile 30 arasında olan ürünler
            using (var db = new NorthwindContext())
            {
                var Products = db.Products.
                Where(i => i.ListPrice >=10 && i.ListPrice<=30)
                .Select(i=> new{i.ProductName,i.ListPrice}).ToList();

                foreach (var item in Products)
                {
                    Console.WriteLine(item.ProductName+" - "+item.ListPrice);
                }
            } */

            /*Beverages kategarisindeki tüm ürünlerin ortalama fiyatı nedir?
            using (var db = new NorthwindContext())
            {
                var Customers = db.Products.Where(i => i.Category == "Beverages").Average(i => i.ListPrice);
                Console.WriteLine(Customers);
            }*/

            /* Beverages kategorisinde toplam kaç ürün vardır
            using (var db = new NorthwindContext())
            {
                var Customers = db.Products.Count(i => i.Category == "Beverages");
                Console.WriteLine(Customers);
            }*/

            /*İçinde Tea kelimesi geçen ürünler name ve açıklama alanında
            using (var db = new NorthwindContext())
            {
                var products = db.Products.Where(i => i.ProductName.Contains("Tea")||i.Description.Contains("Tea")).ToList();

                foreach (var item in products)
                {
                    Console.WriteLine(item.ProductName);
                }
                peki büyük küçük harf kısıtlamasını nasıl halledersin? vtde başı büyük ama aramada sen küçükle aradın şöyle yaparsın
                vtdede arama yaparkende yaptığın işlemi küçültürsün 
                                var products = db.Products.Where(i => i.ProductName.ToLower().Contains("Tea".ToLower()));

            }*/


        }
    }
}








