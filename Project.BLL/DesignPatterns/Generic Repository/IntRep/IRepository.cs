using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.Generic_Repository.IntRep
{
    public interface IRepository<T> where T:BaseEntity
    {
        //List Commands

        List<T> GetAll(); //Bütün Bilgileri Listelemek
        List<T> GetActive(); //Sadece Aktif Verileri Listelemek
        List<T> GetPassive(); //Sadece Pasif verileri listelemek
        List<T> GetModifiers(); //Sadece güncellenmiş verileri listelemek

        //Modify Commands(Veritabanında bir değişikliğe neden olacak metotlar)

        void Add(T item); //ekleme metodu
        void Delete(T item); //Pasife Çekme Metodu
        void Update(T item);//Veriyi Güncelleme Metodu
        void Destroy(T item);//Veriyi Yok Etme Metodu

        //Linq Expressions

        List<T> Where(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T,object>> exp);

        //Find

        T Find(int id);

    }
}
