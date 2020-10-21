//using entityFramework.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFramework
{
   public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                var u=context.products.ToList();
                return u;
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
    }
}
