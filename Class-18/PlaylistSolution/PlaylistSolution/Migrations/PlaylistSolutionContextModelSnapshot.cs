﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PlaylistSolution.Models;
using System;

namespace PlaylistSolution.Migrations
{
    [DbContext(typeof(PlaylistSolutionContext))]
    partial class PlaylistSolutionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlaylistSolution.Models.Playlist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("PlaylistSolution.Models.PlaylistsSongs", b =>
                {
                    b.Property<int>("playlistID");

                    b.Property<int>("songID");

                    b.HasKey("playlistID", "songID");

                    b.HasIndex("songID");

                    b.ToTable("PlaylistSongs");
                });

            modelBuilder.Entity("PlaylistSolution.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<string>("Name");

                    b.Property<int>("ReleaseYear");

                    b.HasKey("ID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("PlaylistSolution.Models.PlaylistsSongs", b =>
                {
                    b.HasOne("PlaylistSolution.Models.Playlist", "Playlist")
                        .WithMany()
                        .HasForeignKey("playlistID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlaylistSolution.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("songID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
