﻿// <auto-generated />
using System;
using EQM_GQE.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EQM_GQE.DATA.Migrations
{
    [DbContext(typeof(QuestionnaireContext))]
    partial class QuestionnaireContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EQM_GQE.SHARED_RESOURCES.Models.BusinessLine", b =>
                {
                    b.Property<int>("BusinessLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("BUSINESS_LINE_CD")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Abbreviation_EN")
                        .HasColumnType("text")
                        .HasColumnName("BUSINESS_ABBR_ELBL");

                    b.Property<string>("Abbreviation_FR")
                        .HasColumnType("text")
                        .HasColumnName("BUSINESS_ABBR_FRBL");

                    b.Property<string>("BusinessName_EN")
                        .HasColumnType("text")
                        .HasColumnName("BUSINESS_NAME_ENM");

                    b.Property<string>("BusinessName_FR")
                        .HasColumnType("text")
                        .HasColumnName("BUSINESS_NAME_FNM");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_CREATED_DTE");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_DELETED_DTE");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_LAST_UPDATE_DTE");

                    b.HasKey("BusinessLineId");

                    b.ToTable("TY001_BUSINESS_LINE");
                });

            modelBuilder.Entity("EQM_GQE.SHARED_RESOURCES.Models.DocumentStatus", b =>
                {
                    b.Property<int>("DocumentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("DOCUMENT_STATUS_CD")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_CREATED_DTE");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_DELETED_DTE");

                    b.Property<string>("DocumentStatus_EN")
                        .HasColumnType("text")
                        .HasColumnName("DOCUMENT_STATUS_ELBL");

                    b.Property<string>("DocumentStatus_FR")
                        .HasColumnType("text")
                        .HasColumnName("DOCUMENT_STATUS_FLBL");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_LAST_UPDATE_DTE");

                    b.HasKey("DocumentStatusId");

                    b.ToTable("TY004_DOCUMENT_STATUS");
                });

            modelBuilder.Entity("EQM_GQE.SHARED_RESOURCES.Models.DocumentType", b =>
                {
                    b.Property<int>("DocumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("DOCUMENT_TYPE_CD")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_CREATED_DTE");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_DELETED_DTE");

                    b.Property<string>("DocumentType_EN")
                        .HasColumnType("text")
                        .HasColumnName("DOCUMENT_TYPE_ELBL");

                    b.Property<string>("DocumentType_FR")
                        .HasColumnType("text")
                        .HasColumnName("DOCUMENT_TYPE_FRBL");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_LAST_UPDATE_DTE");

                    b.HasKey("DocumentTypeId");

                    b.ToTable("TY002_DOCUMENT_TYPE");
                });

            modelBuilder.Entity("EQM_GQE.SHARED_RESOURCES.Models.Questionnaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("QUESTIONNAIRE_TEMPLATE_ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("boolean")
                        .HasColumnName("ACTIVE_STATUS_IND");

                    b.Property<int>("BUSINESS_LINE_CD")
                        .HasColumnType("integer");

                    b.Property<string>("ChangeSummary_EN")
                        .HasColumnType("text")
                        .HasColumnName("CHANGE_SUMMARY_ETXT");

                    b.Property<string>("ChangeSummary_FR")
                        .HasColumnType("text")
                        .HasColumnName("CHANGE_SUMMARY_FTXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("USER_CREATE_ID");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_CREATED_DTE");

                    b.Property<int>("DOCUMENT_STATUS_CD")
                        .HasColumnType("integer");

                    b.Property<int>("DOCUMENT_TYPE_CD")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_DELETED_DTE");

                    b.Property<string>("DocumentTitle_EN")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DOCUMENT_TITLE_ETXT");

                    b.Property<string>("DocumentTitle_FR")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DOCUMENT_TITLE_FTXT");

                    b.Property<int>("DocumentVersion")
                        .HasColumnType("integer")
                        .HasColumnName("DOCUMENT_VERSION_NUM");

                    b.Property<DateTime>("EffectiveFromDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_EFFECTIVE_BEGIN_DTE");

                    b.Property<DateTime>("EffectiveToDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_EFFECTIVE_END_DTE");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text")
                        .HasColumnName("USER_UPDATE_ID");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_LAST_UPDATE_DTE");

                    b.Property<bool>("OrganisationAccessibility")
                        .HasColumnType("boolean")
                        .HasColumnName("ORGANIZATION_ACCESSIBILITY_IND");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer")
                        .HasColumnName("PARENT_TEMPLATE_ID");

                    b.Property<int>("SECURITY_CLASSIFICATION_CD")
                        .HasColumnType("integer");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("TEMPLATE_TXT");

                    b.HasKey("Id");

                    b.HasIndex("BUSINESS_LINE_CD");

                    b.HasIndex("DOCUMENT_STATUS_CD");

                    b.HasIndex("DOCUMENT_TYPE_CD");

                    b.HasIndex("SECURITY_CLASSIFICATION_CD");

                    b.ToTable("CY001_QUESTIONNAIRE_TEMPLATE");
                });

            modelBuilder.Entity("EQM_GQE.SHARED_RESOURCES.Models.SecurityClassification", b =>
                {
                    b.Property<int>("SecurityClassificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("SECURITY_CLASSIFICATION_CD")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_CREATED_DTE");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_DELETED_DTE");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DATE_LAST_UPDATE_DTE");

                    b.Property<string>("SecurityClassification_EN")
                        .HasColumnType("text")
                        .HasColumnName("CLASSIFICATION_ELBL");

                    b.Property<string>("SecurityClassification_FR")
                        .HasColumnType("text")
                        .HasColumnName("CLASSIFICATION_FRBL");

                    b.HasKey("SecurityClassificationId");

                    b.ToTable("TY003_SECURITY_CLASSIFICATION");
                });

            modelBuilder.Entity("EQM_GQE.SHARED_RESOURCES.Models.Questionnaire", b =>
                {
                    b.HasOne("EQM_GQE.SHARED_RESOURCES.Models.BusinessLine", "BusinessLine")
                        .WithMany()
                        .HasForeignKey("BUSINESS_LINE_CD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EQM_GQE.SHARED_RESOURCES.Models.DocumentStatus", "DocumentStatus")
                        .WithMany()
                        .HasForeignKey("DOCUMENT_STATUS_CD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EQM_GQE.SHARED_RESOURCES.Models.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DOCUMENT_TYPE_CD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EQM_GQE.SHARED_RESOURCES.Models.SecurityClassification", "SecurityClassification")
                        .WithMany()
                        .HasForeignKey("SECURITY_CLASSIFICATION_CD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessLine");

                    b.Navigation("DocumentStatus");

                    b.Navigation("DocumentType");

                    b.Navigation("SecurityClassification");
                });
#pragma warning restore 612, 618
        }
    }
}
