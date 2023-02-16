using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanıcılar");
            HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);
            Property(x => x.UserName).HasColumnName("Kullanıcı_İsmi").IsRequired();
            Property(x => x.Password).HasColumnName("Şifre").IsRequired();
        }
    }
}
