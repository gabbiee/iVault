using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVault.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class iVaultDbContext : IdentityDbContext<User>
    {
     
        public iVaultDbContext()
            : base("iVaultConnection", throwIfV1Schema: false)
        {
        }

        public static iVaultDbContext Create()
        {
            return new iVaultDbContext();
        }
    }
}
