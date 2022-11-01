using Examen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Data.Configurations
{
    public class MaisonConfiguration : IEntityTypeConfiguration<Maison>
    {
        public void Configure(EntityTypeBuilder<Maison> builder)
        {
            //builder.....
            //one to many // many to many ...
            builder.HasOne(m => m.type)
           .WithMany(t => t.maisons)
           .HasForeignKey(m => m.typeFk);
        }
    }
}
