using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Concrete.EntityFramework.Mapping
{
	public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(a => a.questionId);
            builder.Property(a => a.questionId).ValueGeneratedOnAdd();
            builder.Property(a => a.testId).IsRequired();
            builder.Property(a => a.question).IsRequired();
            builder.Property(a => a.selectedFirst).IsRequired();
            builder.Property(a => a.selectedSecond).IsRequired();
            builder.Property(a => a.selectedThird).IsRequired();


            builder.Property(a => a.selectedFourth).IsRequired();
            builder.Property(a => a.Answer).IsRequired();

            builder.HasOne<Test>(q => q.Test).WithMany(a => a.Questions).HasForeignKey(b => b.testId);
            builder.ToTable("Questions");

            builder.HasData(new Question
            {
                questionId = 1,
                testId = 1,
                question = "question",
                IsDeleted = false,
                selectedFirst = "question",
                selectedSecond = "question",
                selectedThird = "question",
                selectedFourth = "question",
                Answer = "question",

            }); 

        }
    }
}
