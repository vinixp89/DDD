using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Aplication.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Api.Data.mapping;
namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public  DbSet<UserEntities> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options): base(options){}
        protected override void OnModelCreating (ModelBuilder modelBulder){

            base.OnModelCreating(modelBulder);
            modelBulder.Entities<UserEntities>(new UserMap().Configure);

        }    }
}