using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcLoginReg.Models
{
    public class UsersContext: DbContext
    {
        public UsersContext(): base("dbUserEntries")
        {

        }
        public DbSet<User> Users { get; set; }
    }

}