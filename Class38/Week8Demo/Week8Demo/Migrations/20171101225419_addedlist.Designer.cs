﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Week8Demo.Data;

namespace Week8Demo.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20171101225419_addedlist")]
    partial class addedlist
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Week8Demo.Models.TaskList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("TaskList");
                });

            modelBuilder.Entity("Week8Demo.Models.TodoItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsComplete");

                    b.Property<int>("ListId");

                    b.Property<string>("Task");

                    b.Property<int?>("TaskListID");

                    b.HasKey("Id");

                    b.HasIndex("TaskListID");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("Week8Demo.Models.TodoItems", b =>
                {
                    b.HasOne("Week8Demo.Models.TaskList")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskListID");
                });
#pragma warning restore 612, 618
        }
    }
}
