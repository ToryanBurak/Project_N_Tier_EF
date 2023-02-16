using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.MAP.Options
{
    //Bizim Veritabanında ayarlamaları yapmamızı sağlayan sınıf EntityTypeConfiguration isimli
    //generic sınıftır.Kendisi EF kütüphanesi içerisinde bulunur...
    public abstract class BaseMap<T>:EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            //Ortak ayarlamaları yapacağımız kısım

            Property(x => x.ModifiedDate).HasColumnName("Veri_Güncelleme_Tarihi").HasColumnType("datetime2");
            Property(x => x.DeletedDate).HasColumnName("Veri_Silme_Tarihi").HasColumnType("datetime2");
            Property(x => x.Status).HasColumnName("Durum").IsOptional();
            Property(x => x.InstertedDate).HasColumnName("Veri_Yaratma_Tarihi").HasColumnType("datetime2");
        }
    }
}
