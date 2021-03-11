using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> getAll()
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                return context.Products.ToList();
            }
        }
        public List<Product> getByName(string key)
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();//veritabanından sorgu yapıyor
            }
        }
        public List<Product> getByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }
        public List<Product> getByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList();
            }
        }
        public Product getById(int id)
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                var result = context.Products.SingleOrDefault(p => p.Id == id);
                return result;
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                //context.Products.Add(product);//başka yöntem
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())//using kullanırsak nesneyi işi bittikten sonra bellekten boşaltıyoruz
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
