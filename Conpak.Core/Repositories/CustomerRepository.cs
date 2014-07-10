using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conpak.Core.Data;
using Conpak.Core.Models.Domain;

namespace Conpak.Core.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(Guid id);
    }
    public class CustomerRepository: ICustomerRepository
    {
        public DataContext Context { get; set; }

        public CustomerRepository(DataContext context)
        {
            Context = context;
        }

        public Customer Get(Guid id)
        {
            return Context.Query<Customer>("select * from Customer where Id = @Id",
                    new { Id = id }
                    ).FirstOrDefault();
        }
    }
}
