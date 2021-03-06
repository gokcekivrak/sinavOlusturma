using Data.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Migrations
{
    [DbContext(typeof(SinavOlusturContext))]
    partial class SinavOlusturContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SınavOluşturma.Entities.Question", b =>
            {
                b.Property<int>("questionId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Answer")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<string>("question")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("selectedFirst")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("selectedFourth")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("selectedSecond")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("selectedThird")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("testId")
                    .HasColumnType("int");

                b.HasKey("questionId");

                b.HasIndex("testId");

                b.ToTable("Questions");

                b.HasData(
                    new
                    {
                        questionId = 1,
                        Answer = "question",
                        IsDeleted = false,
                        question = "question",
                        selectedFirst = "question",
                        selectedFourth = "question",
                        selectedSecond = "question",
                        selectedThird = "question",
                        testId = 1
                    });
            });

            modelBuilder.Entity("sinavOlusturma.Entities.Test", b =>
            {
                b.Property<int>("testId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<string>("content")
                    .IsRequired()
                    .HasColumnType("NVARCHAR(MAX)");

                b.Property<DateTime>("createdDate")
                    .HasColumnType("datetime2");

                b.Property<string>("key")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("title")
                    .IsRequired()
                    .HasColumnType("NVARCHAR(MAX)");

                b.Property<int>("userId")
                    .HasColumnType("int");

                b.HasKey("testId");

                b.ToTable("Tests");

                b.HasData(
                    new
                    {
                        testId = 1,
                        IsDeleted = false,
                        content = "gokcekivrak",
                        createdDate = new DateTime(2021, 7, 4, 13, 11, 17, 118, DateTimeKind.Local).AddTicks(5804),
                        key = "key",
                        title = "gokcekivrak",
                        userId = 1
                    });
            });

            modelBuilder.Entity("sinavOlusturma.Entities.User", b =>
            {
                b.Property<int>("userId")
                    .HasColumnType("int");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<string>("userName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("userPassword")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("userId");

                b.ToTable("Users");

                b.HasData(
                    new
                    {
                        userId = 1,
                        IsDeleted = false,
                        userName = "gokcekivrak",
                        userPassword = "gunes"
                    });
            });

            modelBuilder.Entity("sinavOlusturma.Entities.Question", b =>
            {
                b.HasOne("sinavOlusturma.Entities.Test", "Test")
                    .WithMany("Questions")
                    .HasForeignKey("testId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Test");
            });

            modelBuilder.Entity("sinavOlusturma.Entities.Test", b =>
            {
                b.Navigation("Questions");
            });
#pragma warning restore 612, 618
        }
    }
}
