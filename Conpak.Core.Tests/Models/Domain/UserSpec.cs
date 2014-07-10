using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using Conpak.Core.Models.Domain;

namespace Conpak.Core.Tests.Models.Domain
{
    [TestFixture]
    public class UserSpec
    {
        [Test]
        public void Insert()
        {
            var user = new User()
                       {
                           FirstName = "John",
                           LastName = "Doe",
                           Email = "john.doe@test.com",
                           Address = "123 Main ST",
                           City = "New York",
                           State = "NY"

                       };


        }
    }
}
