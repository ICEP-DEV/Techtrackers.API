﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechTrackers.Data;

#nullable disable

namespace TechTrackers.Data.Migrations
{
    [DbContext(typeof(TeckTrackersDbContext))]
    [Migration("20240928231752_fifth-database")]
    partial class fifthdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechTrackers.Data.Model.Category", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_ID"));

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Department", b =>
                {
                    b.Property<int>("Department_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Department_ID"));

                    b.Property<string>("Department_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Department_ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Escalation", b =>
                {
                    b.Property<int>("Escalation_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Escalation_ID"));

                    b.Property<int>("HOD_ID")
                        .HasColumnType("int");

                    b.Property<int>("Log_ID")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Escalation_ID");

                    b.ToTable("Escalations");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Feedback", b =>
                {
                    b.Property<int>("Feedback_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Feedback_ID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Log_ID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Feedback_ID");

                    b.ToTable("Feed_back");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Log", b =>
                {
                    b.Property<int>("Log_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Log_ID"));

                    b.Property<string>("Assigned_At")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Assigned_By")
                        .HasColumnType("int");

                    b.Property<string>("Attachment_URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Log_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SLA_ID")
                        .HasColumnType("int");

                    b.Property<int>("Staff_ID")
                        .HasColumnType("int");

                    b.Property<int>("Technician_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Log_ID");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Log_chat", b =>
                {
                    b.Property<int>("Log_Chat_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Log_Chat_ID"));

                    b.Property<int>("Log_ID")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sender_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Log_Chat_ID");

                    b.ToTable("Log_chats");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Log_status_history", b =>
                {
                    b.Property<int>("Log_Status_History_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Log_Status_History_ID"));

                    b.Property<int>("Changed_by_User_ID")
                        .HasColumnType("int");

                    b.Property<int>("Log_ID")
                        .HasColumnType("int");

                    b.Property<string>("Log_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Log_Status_History_ID");

                    b.ToTable("Log_status_histor");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Notifications", b =>
                {
                    b.Property<int>("Notification_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Notification_ID"));

                    b.Property<int>("Log_ID")
                        .HasColumnType("int");

                    b.Property<string>("Notification_Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Notification_Type")
                        .HasColumnType("int");

                    b.Property<bool>("Read_Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Notification_ID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Role", b =>
                {
                    b.Property<int>("Role_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Role_ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Role_ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.Service_level_agreement", b =>
                {
                    b.Property<int>("SLA_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SLA_ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Log_ID")
                        .HasColumnType("int");

                    b.Property<string>("Priority_Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Resolution_Timeframe")
                        .HasColumnType("datetime2");

                    b.HasKey("SLA_ID");

                    b.ToTable("Service_Level_Agreements");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_ID"));

                    b.Property<int>("Department_ID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role_ID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TechTrackers.Data.Model.User_Role", b =>
                {
                    b.Property<int>("User_Role_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Role_ID"));

                    b.Property<int>("Role_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("User_Role_ID");

                    b.ToTable("User_Roles");
                });
#pragma warning restore 612, 618
        }
    }
}