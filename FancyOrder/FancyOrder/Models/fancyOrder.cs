using DogNet.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyOrder.Models
{
    [RepositoryEntity(DefaultConnName = "db")]
    [PetaPoco.TableName("order")]
    [PetaPoco.PrimaryKey("ID", autoIncrement = true)]

    public class fancyOrder : Repository<fancyOrder>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Number { get; set; }

        public string Remark { get; set; }

        public string Service { get; set; }

        public string Standard { get; set; }
        public string OrderTime { get; set; }
        public DateTime InputTime { get; set; }

        public string type { get; set; }
    }
}