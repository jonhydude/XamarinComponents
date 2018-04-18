﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NugetAuditor.Core;
using System;

namespace NugetAuditor.Core.Migrations
{
    [DbContext(typeof(AuditorDbContext))]
    partial class AuditorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NugetAuditor.Core.ProcessResult", b =>
                {
                    b.Property<string>("PackageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentVersion");

                    b.Property<DateTime>("DatePublished");

                    b.Property<bool>("HasMicrosoftOwner");

                    b.Property<bool>("IconUrlIsValid");

                    b.Property<bool>("IsSigned");

                    b.Property<bool>("LicenceUrlIsFWLink");

                    b.Property<bool>("LicenceUrlIsValid");

                    b.Property<bool>("LicenceUrlPointsToComponentsStore");

                    b.Property<string>("Owners");

                    b.Property<string>("PackageTitle");

                    b.Property<bool>("ProjectUrlIsFWLink");

                    b.Property<bool>("ProjectUrlIsValid");

                    b.Property<bool>("ProjectUrlPointsToComponentsStore");

                    b.Property<long>("TotalDownloads");

                    b.Property<long>("TotalVersions");

                    b.HasKey("PackageId");

                    b.ToTable("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
