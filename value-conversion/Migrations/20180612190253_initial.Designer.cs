﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using value_conversion;

namespace valueconversion.Migrations
{
    [DbContext(typeof(ThemeContext))]
    [Migration("20180612190253_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("value_conversion.Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("TitleColor")
                        .IsRequired();

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");

                    b.HasData(
                        new { ThemeId = 1, Name = "MSDN", TitleColor = "AliceBlue" },
                        new { ThemeId = 2, Name = "TechNet", TitleColor = "DarkCyan" },
                        new { ThemeId = 3, Name = "EF", TitleColor = "Purple" },
                        new { ThemeId = 4, Name = "Personal", TitleColor = "LightBlue" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
