﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesTelegramBotApp;

#nullable disable

namespace MoviesTelegramBotApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240917170742_ChangeModelUserPropChatId")]
    partial class ChangeModelUserPropChatId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MoviesTelegramBotApp.Models.Cartoon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Budget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CartoonGenreId")
                        .HasColumnType("int");

                    b.Property<string>("CartoonUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CartoonGenreId");

                    b.ToTable("Cartoons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = "1000000",
                            CartoonGenreId = 1,
                            CartoonUrl = "https://www.youtube.com/watch?v=t0Q2otsqC4I",
                            Description = "Tom and Jerry is a classic cartoon about a never-ending battle between a cat named Tom and a mischievous mouse named Jerry.",
                            ImageUrl = "https://i.pinimg.com/236x/4d/6c/28/4d6c285286e59e8c4c6e4c30470db86f.jpg",
                            Title = "Tom and Jerry"
                        },
                        new
                        {
                            Id = 2,
                            Budget = "2000000",
                            CartoonGenreId = 2,
                            CartoonUrl = "https://www.youtube.com/watch?v=kGngZN_savE",
                            Description = "Oggy and the Cockroaches is a French animated series that follows the chaotic life of a blue cat named Oggy.",
                            ImageUrl = "https://i.pinimg.com/736x/5d/cb/ac/5dcbac34552629b0bb4963d0223f0166.jpg",
                            Title = "Oggy and the Cockroaches"
                        },
                        new
                        {
                            Id = 3,
                            Budget = "3000000",
                            CartoonGenreId = 3,
                            CartoonUrl = "https://www.youtube.com/watch?v=IbeOYixloT0",
                            Description = "Doraemon is a beloved children's series about a robotic cat named Doraemon who travels back in time from the 22nd century.",
                            ImageUrl = "https://i.pinimg.com/236x/4e/de/d4/4eded44f271d6409be1850646ec382ae.jpg",
                            Title = "Doraemon"
                        });
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.CartoonGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CartoonGenre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Slapstick Comedy"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Children's Film"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Adventure"
                        });
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BehindTheScene")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestFactsUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("MovieUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BehindTheScene = "https://www.youtube.com/watch?v=m15YteEQC7k",
                            Budget = "100000",
                            Country = "USA",
                            Description = "desc 1",
                            GenreId = 1,
                            ImageUrl = "https://i.pinimg.com/736x/f8/46/e4/f846e4d7aa3aa6b7c82799e4745f8ab1.jpg",
                            InterestFactsUrl = "https://www.youtube.com/watch?v=ID_TNr5yoHE",
                            IsFavorite = false,
                            MovieUrl = "https://www.youtube.com/watch?v=jaJuwKCmJbY",
                            Title = "Die hard"
                        },
                        new
                        {
                            Id = 2,
                            BehindTheScene = "https://www.youtube.com/watch?v=iWPWZNfh-To",
                            Budget = "1000000",
                            Country = "USA",
                            Description = "desc 2",
                            GenreId = 2,
                            ImageUrl = "https://i.pinimg.com/originals/61/fa/cb/61facb2dbfa0f558c8be590d93813af5.jpg",
                            InterestFactsUrl = "https://www.youtube.com/watch?v=zqAgauSv7AE",
                            IsFavorite = false,
                            MovieUrl = "https://www.youtube.com/watch?v=LZl69yk5lEY",
                            Title = "The Mask"
                        },
                        new
                        {
                            Id = 3,
                            BehindTheScene = "https://www.youtube.com/watch?v=M2Lul33Oypw",
                            Budget = "200000",
                            Country = "USA",
                            Description = "desc 3",
                            GenreId = 3,
                            ImageUrl = "https://i.pinimg.com/736x/39/66/3b/39663baaa2f92e10fa3f6757ce9b4d37.jpg",
                            InterestFactsUrl = "https://www.youtube.com/watch?v=tHQEimbxdRE",
                            IsFavorite = false,
                            MovieUrl = "https://www.youtube.com/watch?v=PLl99DlL6b4",
                            Title = "The Shawshank redemption"
                        },
                        new
                        {
                            Id = 4,
                            BehindTheScene = "https://www.youtube.com/watch?v=3CuFPurGYDk",
                            Budget = "300000",
                            Country = "USA",
                            Description = "desc 4",
                            GenreId = 3,
                            ImageUrl = "https://i.pinimg.com/222x/70/2f/95/702f957e27890efd7f65d40a04c1915d.jpg",
                            InterestFactsUrl = "https://www.youtube.com/shorts/N6Nv5Z8U4P0",
                            IsFavorite = false,
                            MovieUrl = "https://www.youtube.com/watch?v=jcDD2-s4vWA",
                            Title = "Point Break"
                        },
                        new
                        {
                            Id = 5,
                            BehindTheScene = "https://www.youtube.com/watch?v=MBShyOajLcg",
                            Budget = "450000",
                            Country = "USA",
                            Description = "desc 5",
                            GenreId = 1,
                            ImageUrl = "https://i.pinimg.com/736x/8d/ae/66/8dae66323e077860ea2ab571edede26c.jpg",
                            InterestFactsUrl = "https://www.youtube.com/watch?v=amTSmyikwlY",
                            IsFavorite = false,
                            MovieUrl = "https://www.youtube.com/watch?v=CRRlbK5w8AE",
                            Title = "Terminator"
                        },
                        new
                        {
                            Id = 6,
                            BehindTheScene = "https://www.youtube.com/watch?v=iWPWZNfh-To",
                            Budget = "3000000",
                            Country = "USA",
                            Description = "desc 6",
                            GenreId = 2,
                            ImageUrl = "https://i.pinimg.com/originals/61/fa/cb/61facb2dbfa0f558c8be590d93813af5.jpg",
                            InterestFactsUrl = "https://www.youtube.com/watch?v=zqAgauSv7AE",
                            IsFavorite = false,
                            MovieUrl = "https://www.youtube.com/watch?v=LZl69yk5lEY",
                            Title = "The Mask 2"
                        });
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long?>("ChatId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.UserFavoriteMovie", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("UserFavoriteMovie");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.Cartoon", b =>
                {
                    b.HasOne("MoviesTelegramBotApp.Models.CartoonGenre", "Genre")
                        .WithMany("Cartoons")
                        .HasForeignKey("CartoonGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.Movie", b =>
                {
                    b.HasOne("MoviesTelegramBotApp.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.UserFavoriteMovie", b =>
                {
                    b.HasOne("MoviesTelegramBotApp.Models.Movie", "Movie")
                        .WithMany("Users")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesTelegramBotApp.Models.User", "User")
                        .WithMany("FavoriteMovies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.CartoonGenre", b =>
                {
                    b.Navigation("Cartoons");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.Movie", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("MoviesTelegramBotApp.Models.User", b =>
                {
                    b.Navigation("FavoriteMovies");
                });
#pragma warning restore 612, 618
        }
    }
}
