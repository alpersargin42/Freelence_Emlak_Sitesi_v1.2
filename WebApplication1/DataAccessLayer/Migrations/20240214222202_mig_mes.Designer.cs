﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240214222202_mig_mes")]
    partial class mig_mes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrate.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Advertiser", b =>
                {
                    b.Property<int>("AdvertiserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdvertiserAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvertiserMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvertiserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvertiserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvertiserPassword1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AdvertiserStatus")
                        .HasColumnType("bit");

                    b.HasKey("AdvertiserID");

                    b.ToTable("Advertisers");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstateID")
                        .HasColumnType("int");

                    b.Property<int>("EstateScore")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("EstateID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Estate", b =>
                {
                    b.Property<int>("EstateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertiserID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("EstateContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstateCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstateImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateImage4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateImage5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateOzellik9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstatePopu")
                        .HasColumnType("bit");

                    b.Property<int>("EstatePrice")
                        .HasColumnType("int");

                    b.Property<bool>("EstateStatus")
                        .HasColumnType("bit");

                    b.Property<string>("EstateTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstateID");

                    b.HasIndex("AdvertiserID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Estates");
                });

            modelBuilder.Entity("EntityLayer.Concrate.EstateRaytings", b =>
                {
                    b.Property<int>("EstateRaytingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstateID")
                        .HasColumnType("int");

                    b.Property<int>("EstateReytingCount")
                        .HasColumnType("int");

                    b.Property<int>("EstateTotalScore")
                        .HasColumnType("int");

                    b.HasKey("EstateRaytingID");

                    b.ToTable("EstateRaytings");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Message2", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int?>("SenderID")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("Messages2");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrate.Estate", "Estate")
                        .WithMany("Comments")
                        .HasForeignKey("EstateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estate");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Estate", b =>
                {
                    b.HasOne("EntityLayer.Concrate.Advertiser", "Advertiser")
                        .WithMany("Estates")
                        .HasForeignKey("AdvertiserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrate.Category", "Category")
                        .WithMany("Estate")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advertiser");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Message2", b =>
                {
                    b.HasOne("EntityLayer.Concrate.Advertiser", "ReceiverUser")
                        .WithMany("AdvertiserReceiver")
                        .HasForeignKey("ReceiverID");

                    b.HasOne("EntityLayer.Concrate.Advertiser", "SenderUser")
                        .WithMany("AdvertiserSender")
                        .HasForeignKey("SenderID");

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Advertiser", b =>
                {
                    b.Navigation("AdvertiserReceiver");

                    b.Navigation("AdvertiserSender");

                    b.Navigation("Estates");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Category", b =>
                {
                    b.Navigation("Estate");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Estate", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
