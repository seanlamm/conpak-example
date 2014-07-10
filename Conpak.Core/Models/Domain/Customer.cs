using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conpak.Core.Data;

namespace Conpak.Core.Models.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime LastModifiedDateTime { get; set; }

        public static Customer Get(DataContext context, Guid id)
        {
            return context.Query<Customer>("select * from Customer where Id = @Id",
                    new { Id = id }
                    ).FirstOrDefault();
        }
    }
}
