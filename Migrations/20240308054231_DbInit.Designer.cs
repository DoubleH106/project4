﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project4.Models;

#nullable disable

namespace project4.Migrations
{
    [DbContext(typeof(project4Context))]
    [Migration("20240308054231_DbInit")]
    partial class DbInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("project4.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("project4.Models.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsTrue")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("QuestionId");

                    b.ToTable("ANSWER");
                });

            modelBuilder.Entity("project4.Models.Categories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("CATEGORIES");
                });

            modelBuilder.Entity("project4.Models.Example", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NameLenguage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NameVN")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("WordID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("WordID");

                    b.ToTable("EXAMPLE");
                });

            modelBuilder.Entity("project4.Models.History", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("QuantityCorrect")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("LessonId");

                    b.ToTable("HISTORY");
                });

            modelBuilder.Entity("project4.Models.Lesson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("TopicId");

                    b.ToTable("LESSON");
                });

            modelBuilder.Entity("project4.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("LessonId");

                    b.ToTable("QUESTION");
                });

            modelBuilder.Entity("project4.Models.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Avata")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.ToTable("TOPIC");
                });

            modelBuilder.Entity("project4.Models.Word", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRememory")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NameEN")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NameVN")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("TimeStudied")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("WORD");
                });

            modelBuilder.Entity("project4.Models.Answer", b =>
                {
                    b.HasOne("project4.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("project4.Models.Example", b =>
                {
                    b.HasOne("project4.Models.Word", "Words")
                        .WithMany("Examples")
                        .HasForeignKey("WordID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Words");
                });

            modelBuilder.Entity("project4.Models.History", b =>
                {
                    b.HasOne("project4.Models.Lesson", "Lesson")
                        .WithMany("Histories")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("project4.Models.Lesson", b =>
                {
                    b.HasOne("project4.Models.Categories", "Categories")
                        .WithMany("Lessons")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project4.Models.Topic", "Topic")
                        .WithMany("Lessons")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("project4.Models.Question", b =>
                {
                    b.HasOne("project4.Models.Lesson", "Lessons")
                        .WithMany("Questions")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("project4.Models.Topic", b =>
                {
                    b.HasOne("project4.Models.Account", "Account")
                        .WithMany("Topics")
                        .HasForeignKey("AccountID");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("project4.Models.Account", b =>
                {
                    b.Navigation("Topics");
                });

            modelBuilder.Entity("project4.Models.Categories", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("project4.Models.Lesson", b =>
                {
                    b.Navigation("Histories");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("project4.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("project4.Models.Topic", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("project4.Models.Word", b =>
                {
                    b.Navigation("Examples");
                });
#pragma warning restore 612, 618
        }
    }
}
