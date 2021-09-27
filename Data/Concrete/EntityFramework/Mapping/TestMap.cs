using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Concrete.EntityFramework.Mapping
{
	public class TestMap : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(a => a.testId);
            builder.Property(a => a.testId).ValueGeneratedOnAdd();

            builder.Property(a => a.userId).ValueGeneratedNever();

            builder.Property(a => a.title).IsRequired(true);
            builder.Property(a => a.title).HasColumnType("NVARCHAR(MAX)");


            builder.Property(a => a.content).IsRequired();
            builder.Property(a => a.content).HasColumnType("NVARCHAR(MAX)");


            builder.Property(a => a.IsDeleted).IsRequired();

            builder.Property(a => a.createdDate).IsRequired();


            builder.Property(a => a.key).IsRequired();

            builder.ToTable("Tests");

            builder.HasData(new Test
            {
                testId = 1,
                userId = 1,
                IsDeleted = false,
                title = "gokcekivrak",
                content = "gunes",
                key = "key",
                createdDate = DateTime.Now,

            }); ;
        }
    }
}
