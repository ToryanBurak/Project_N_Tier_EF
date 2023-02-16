using Project.ENTITIES.Enu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class BaseEntity
    {
       
            public int ID { get; set; }
            public DateTime InstertedDate { get; set; }
            public DateTime? ModifiedDate { get; set; }
            public DateTime? DeletedDate { get; set; }
            public DataStatus Status { get; set; }

            public BaseEntity()
            {
                InstertedDate = DateTime.Now;
                Status = DataStatus.Inserted;
            }
        
    }
}
