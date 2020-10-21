//using entityFramework.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFramework
{/*veri tabanına c# ile sorgu ataması yapıyorum aslında*/
   public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                 return context.products.ToList();
            }
        }
        public List<Product> GetByName(string key) //isme göre arar
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.products.Where(p => p.Name.Contains(key)).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal Price) //fiyat göre arar
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.products.Where(p => p.UnitPrice>=Price).ToList();
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.products.Add(product);/*bunu yazmak yerine soyle de yazabilirim;
                                 var entity = context.Entry(product);
                entity.State = EntityState.Added;              */
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /*benim gönderdiğim prdocuct u vt deki prod ile eşitliyor*/
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                /*benim gönderdiğim prdocuct u vt deki prod ile eşitliyor*/
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        /*public Product GetById(int Id)//ıd ye göre arama yapar
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = context.products.FirstOrDefault(p => p.Id == Id);
                return result;
            }
        }*/
    }/*public List<Product> GetByUnitPrice(decimal min,decimal max) //fiyat aralıgı sorgusudur
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList();
            }
        }*/
}
