﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserProfileMap:BaseMap<AppUserProfile>
    {
        public AppUserProfileMap()
        {
            ToTable("Profiller");
            Property(x => x.FirstName).HasColumnName("İsim").IsRequired();
            Property(x => x.LastName).HasColumnName("Soy_İsim").IsRequired();
        }
    }
}
