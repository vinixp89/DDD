using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;

namespace Api.Data.mapping
{
    public class UserMap : IEntityTyperConfiguration<UserEntities>{
       

       public void Configure(EntityTyperBuilder<UserEntities> builder){

        builder.ToTable("User");

        builder.HasKey(p => p.Id);
        builder.HasIndex (p => p.Email)
                .IsUnique();
        builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(60);

        builder.Property( u => u.Email)
                .HasMaxLength(100);
       }
    }
  
};