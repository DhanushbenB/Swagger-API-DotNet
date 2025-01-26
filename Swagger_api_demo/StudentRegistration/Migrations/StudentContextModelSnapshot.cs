﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRegistration.StudentDBContext;

#nullable disable

namespace StudentRegistration.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentRegistration.StudentModels.StudentModel", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentId"), 1L, 1);

                    b.Property<string>("studentDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studentId");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
