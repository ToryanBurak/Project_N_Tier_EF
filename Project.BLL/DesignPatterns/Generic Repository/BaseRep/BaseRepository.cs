using Project.BLL.DesignPatterns.Generic_Repository.IntRep;
using Project.BLL.DesignPatterns.Singleton_Pattern;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.Generic_Repository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;
        public BaseRepository()
        {
            _db = DbTool.DbInstance;  
        }
        //Protected erişim belirtecini vererek bu metodu sadece miras verilen sınıflardan kullanılmasını
        //Sağlamamızın sebebi ilerleyen günlerde bu sınıflar basedeki savei kullanmaktansa kendi save patternlerini oluşturmak isteyebilirler
        //ve ek olarka repository dışından özellikle savei kullanmak isteyen birisi bunu kullanarak sizin yarattığınız
        //Algoritmayı bozabilir...

        protected void Save()
        {
            _db.SaveChanges();
        }
        public void Add(T item)
        {
           _db.Set<T>().Add(item); //Veritabanına git,kendini T'ye göre set et onun ekleme metodunu çalıştır...
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.DeletedDate = DateTime.Now;
            item.Status = ENTITIES.Enu.DataStatus.Deleted;
            Save();
            
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public T Find(int id)
        {
           return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }
        public List<T> GetActive()
        {
            return Where(x => x.Status != ENTITIES.Enu.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetModifiers()
        {
            return Where(x=>x.Status==ENTITIES.Enu.DataStatus.Updated);
        }

        public List<T> GetPassive()
        {
            return Where(x => x.Status == ENTITIES.Enu.DataStatus.Deleted);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp).ToList();
        }
        //<summary>
        /// <summary>
        ///  Geriye List'e cast edilmeye hazır (unboxing) bir sonuc döndürür.
        /// </summary>
        /// <param name="exp">DTO veya Type Argümanları verilebilir.</param>
        /// <returns></returns>
        public void Update(T item)
        {
            item.ModifiedDate= DateTime.Now;
            item.Status=ENTITIES.Enu.DataStatus.Updated;
            T ToBeUpdated = Find(item.ID); //Bize gelen Item'in ID'sini bularak ToBeUpdated değişkenimize attık...
            //Entry Demek DB'de bir güncelleme işlemi yapılacak demektir...
            _db.Entry(ToBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
        
        public List<T> Where(Expression<Func<T, bool>> exp)
        {
           return _db.Set<T>().Where(exp).ToList();

        }
    }
}
