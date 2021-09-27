using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Concrete.EntityFramework.Mapping
{
	public class UserMap: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.userId);
            builder.Property(a => a.userId).ValueGeneratedOnAdd();
            builder.Property(a => a.userId).ValueGeneratedNever();
            builder.Property(a => a.userName).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.userPassword).IsRequired(true);

            builder.HasData(new User
            {
                userId = 1,
                userName = "gokcekivrak",
                userPassword = "gunes",
                IsDeleted = false,

            }); ;


        }
    }
}
