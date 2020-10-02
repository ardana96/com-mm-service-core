﻿// <auto-generated />
using Com.MM.Service.Core.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.MM.Service.Core.Lib.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20200828085401_change_name_tale_expedition")]
    partial class change_name_tale_expedition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Account_and_Roles.AccountProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<string>("Firstname");

                    b.Property<string>("Gender");

                    b.Property<string>("Lastname");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AccountProfiles");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Account_and_Roles.AccountRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<bool>("Active");

                    b.Property<int>("RoleId");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Account_and_Roles.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Division");

                    b.Property<int>("RoleId");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("Unit");

                    b.Property<string>("UnitCode");

                    b.Property<int>("UnitId");

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.Property<int>("permission");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Account_and_Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleCategories");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleCollections");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleColors");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleCounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleCounters");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleMaterials");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleMaterialComposition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleMaterialCompositions");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleMotif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("FilePath")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleMotifs");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleProces", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleProcess");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleSeason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleSeasons");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleSizes");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleSubCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleSubCollections");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleSubCounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleSubCounters");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.ArticleSubProces", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("ArticleSubProcess");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("COACode")
                        .HasMaxLength(50);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Expedition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Expeditions");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ArticleCategoriesId");

                    b.Property<int>("ArticleCollectionsId");

                    b.Property<int>("ArticleColorsId");

                    b.Property<int>("ArticleCountersId");

                    b.Property<int>("ArticleMaterialCompositionsId");

                    b.Property<int>("ArticleMaterialsId");

                    b.Property<int>("ArticleProcessId");

                    b.Property<string>("ArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<int>("ArticleSeasonsId");

                    b.Property<int>("ArticleSubCountersId");

                    b.Property<string>("CategoryDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryDocName")
                        .HasMaxLength(255);

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("CollectionDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("CollectionDocName")
                        .HasMaxLength(255);

                    b.Property<string>("ColorCode")
                        .HasMaxLength(255);

                    b.Property<string>("ColorDocName")
                        .HasMaxLength(255);

                    b.Property<string>("CounterDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("CounterDocName")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<double?>("DomesticCOGS");

                    b.Property<double?>("DomesticRetail");

                    b.Property<double?>("DomesticSale");

                    b.Property<double?>("DomesticWholesale");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(255);

                    b.Property<double?>("InternatinalCOGS");

                    b.Property<double?>("InternatioalRetail");

                    b.Property<double?>("InternationalSale");

                    b.Property<double?>("InternationalWholesale");

                    b.Property<string>("MaterialCompositionDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("MaterialCompositionDocName")
                        .HasMaxLength(255);

                    b.Property<string>("MaterialDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("MaterialDocName")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("ProcessDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("ProcessDocName")
                        .HasMaxLength(255);

                    b.Property<string>("Remark")
                        .HasMaxLength(255);

                    b.Property<string>("SeasonDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("SeasonDocName")
                        .HasMaxLength(255);

                    b.Property<string>("Size");

                    b.Property<string>("StyleDocCode")
                        .HasMaxLength(255);

                    b.Property<string>("StyleDocName")
                        .HasMaxLength(255);

                    b.Property<string>("Tags")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("Uom")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Module.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Module.ModuleDestination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("DestinationValue")
                        .HasMaxLength(255);

                    b.Property<int>("ModuleId");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("ModuleDesstinations");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Module.ModuleSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ModuleId");

                    b.Property<string>("SourceValue")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("ModuleSources");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool>("IsCentral");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent");

                    b.Property<string>("_CreatedBy");

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent");

                    b.Property<string>("_DeletedBy");

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent");

                    b.Property<string>("_LastModifiedBy");

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Account_and_Roles.AccountRole", b =>
                {
                    b.HasOne("Com.MM.Service.Core.Lib.Models.Account_and_Roles.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Account_and_Roles.Permission", b =>
                {
                    b.HasOne("Com.MM.Service.Core.Lib.Models.Account_and_Roles.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Module.ModuleDestination", b =>
                {
                    b.HasOne("Com.MM.Service.Core.Lib.Models.Module.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.MM.Service.Core.Lib.Models.Module.ModuleSource", b =>
                {
                    b.HasOne("Com.MM.Service.Core.Lib.Models.Module.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
