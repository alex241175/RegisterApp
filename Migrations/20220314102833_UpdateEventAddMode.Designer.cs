﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegisterApp.Data;

#nullable disable

namespace RegisterApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220314102833_UpdateEventAddMode")]
    partial class UpdateEventAddMode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("RegisterApp.Data.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("End")
                        .HasColumnType("TEXT");

                    b.Property<string>("Entity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Head")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<int>("Mode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT");

                    b.Property<string>("Service")
                        .HasColumnType("TEXT");

                    b.Property<string>("Speaker")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("RegisterApp.Data.EventMember", b =>
                {
                    b.Property<int>("EventMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Attended")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT");

                    b.Property<string>("School")
                        .HasColumnType("TEXT");

                    b.HasKey("EventMemberId");

                    b.HasIndex("EventId");

                    b.ToTable("EventMembers");
                });

            modelBuilder.Entity("RegisterApp.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RegisterApp.Data.EventMember", b =>
                {
                    b.HasOne("RegisterApp.Data.Event", null)
                        .WithMany("EventMembers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegisterApp.Data.Event", b =>
                {
                    b.Navigation("EventMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
