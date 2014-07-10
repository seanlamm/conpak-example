using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Conpak.Core.Common;
using Conpak.Core.Data;
using Conpak.Core.Models.Domain;

namespace Conpak.Core.Queries
{
    public class ComplexCustomerQuery
    {
        public DataContext Context { get; set; }

        public ComplexCustomerQuery(DataContext context)
        {
            Context = context;
        }

        public Guid Id { get; set; }

        public Customer Get()
        {
            var sql = ResourceHelper.ReadEmbeddedResource("Conpak.Core.Queries.ComplexCustomerQuery.sql");
            return Context.Query<Customer>(sql,
                   new { Id = Id }
                   ).FirstOrDefault();
        }
    }
}
