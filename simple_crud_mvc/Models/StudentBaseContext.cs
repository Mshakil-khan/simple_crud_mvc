using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace simple_crud_mvc.Models

{
    public class StudentBaseContext:DbContext
    {
        public DbSet<Studentdata> Students2 { get; set; }

    }
}