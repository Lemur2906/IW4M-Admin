﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Data.MigrationContext;

namespace Data.Migrations.MySql
{
    [DbContext(typeof(MySqlDatabaseContext))]
    [Migration("20180907020706_AddVision")]
    partial class AddVision
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFACSnapshot", b =>
                {
                    b.Property<int>("SnapshotId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ClientId");

                    b.Property<int>("CurrentSessionLength");

                    b.Property<double>("CurrentStrain");

                    b.Property<int?>("CurrentViewAngleId");

                    b.Property<int>("Deaths");

                    b.Property<double>("Distance");

                    b.Property<double>("EloRating");

                    b.Property<int?>("HitDestinationVector3Id");

                    b.Property<int>("HitLocation");

                    b.Property<int?>("HitOriginVector3Id");

                    b.Property<int>("HitType");

                    b.Property<int>("Hits");

                    b.Property<int>("Kills");

                    b.Property<int?>("LastStrainAngleVector3Id");

                    b.Property<double>("SessionAngleOffset");

                    b.Property<double>("SessionSPM");

                    b.Property<int>("SessionScore");

                    b.Property<double>("StrainAngleBetween");

                    b.Property<int>("TimeSinceLastEvent");

                    b.Property<int>("WeaponId");

                    b.Property<DateTime>("When");

                    b.HasKey("SnapshotId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CurrentViewAngleId");

                    b.HasIndex("HitDestinationVector3Id");

                    b.HasIndex("HitOriginVector3Id");

                    b.HasIndex("LastStrainAngleVector3Id");

                    b.ToTable("EFACSnapshot");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientKill", b =>
                {
                    b.Property<long>("KillId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AttackerId");

                    b.Property<int>("Damage");

                    b.Property<int?>("DeathOriginVector3Id");

                    b.Property<int>("DeathType");

                    b.Property<double>("Fraction");

                    b.Property<int>("HitLoc");

                    b.Property<bool>("IsKill");

                    b.Property<int?>("KillOriginVector3Id");

                    b.Property<int>("Map");

                    b.Property<int>("ServerId");

                    b.Property<int>("VictimId");

                    b.Property<int?>("ViewAnglesVector3Id");

                    b.Property<double>("VisibilityPercentage");

                    b.Property<int>("Weapon");

                    b.Property<DateTime>("When");

                    b.HasKey("KillId");

                    b.HasIndex("AttackerId");

                    b.HasIndex("DeathOriginVector3Id");

                    b.HasIndex("KillOriginVector3Id");

                    b.HasIndex("ServerId");

                    b.HasIndex("VictimId");

                    b.HasIndex("ViewAnglesVector3Id");

                    b.ToTable("EFClientKills");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientMessage", b =>
                {
                    b.Property<long>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ClientId");

                    b.Property<string>("Message");

                    b.Property<int>("ServerId");

                    b.Property<DateTime>("TimeSent");

                    b.HasKey("MessageId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ServerId");

                    b.ToTable("EFClientMessages");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientRatingHistory", b =>
                {
                    b.Property<int>("RatingHistoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ClientId");

                    b.HasKey("RatingHistoryId");

                    b.HasIndex("ClientId");

                    b.ToTable("EFClientRatingHistory");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientStatistics", b =>
                {
                    b.Property<int>("ClientId");

                    b.Property<int>("ServerId");

                    b.Property<bool>("Active");

                    b.Property<int>("Deaths");

                    b.Property<double>("EloRating");

                    b.Property<int>("Kills");

                    b.Property<double>("MaxStrain");

                    b.Property<double>("RollingWeightedKDR");

                    b.Property<double>("SPM");

                    b.Property<double>("Skill");

                    b.Property<int>("TimePlayed");

                    b.Property<double>("VisionAverage");

                    b.HasKey("ClientId", "ServerId");

                    b.HasIndex("ServerId");

                    b.ToTable("EFClientStatistics");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFHitLocationCount", b =>
                {
                    b.Property<int>("HitLocationCountId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ClientId")
                        .HasColumnName("EFClientStatistics_ClientId");

                    b.Property<int>("HitCount");

                    b.Property<float>("HitOffsetAverage");

                    b.Property<int>("Location");

                    b.Property<float>("MaxAngleDistance");

                    b.Property<int>("ServerId")
                        .HasColumnName("EFClientStatistics_ServerId");

                    b.HasKey("HitLocationCountId");

                    b.HasIndex("ServerId");

                    b.HasIndex("ClientId", "ServerId");

                    b.ToTable("EFHitLocationCounts");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFRating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ActivityAmount");

                    b.Property<bool>("Newest");

                    b.Property<double>("Performance");

                    b.Property<int>("Ranking");

                    b.Property<int>("RatingHistoryId");

                    b.Property<int?>("ServerId");

                    b.HasKey("RatingId");

                    b.HasIndex("RatingHistoryId");

                    b.HasIndex("ServerId");

                    b.ToTable("EFRating");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFServer", b =>
                {
                    b.Property<int>("ServerId");

                    b.Property<bool>("Active");

                    b.Property<int>("Port");

                    b.HasKey("ServerId");

                    b.ToTable("EFServers");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFServerStatistics", b =>
                {
                    b.Property<int>("StatisticId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ServerId");

                    b.Property<long>("TotalKills");

                    b.Property<long>("TotalPlayTime");

                    b.HasKey("StatisticId");

                    b.HasIndex("ServerId");

                    b.ToTable("EFServerStatistics");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFAlias", b =>
                {
                    b.Property<int>("AliasId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("IPAddress");

                    b.Property<int>("LinkId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("AliasId");

                    b.HasIndex("IPAddress");

                    b.HasIndex("LinkId");

                    b.ToTable("EFAlias");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFAliasLink", b =>
                {
                    b.Property<int>("AliasLinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.HasKey("AliasLinkId");

                    b.ToTable("EFAliasLinks");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFChangeHistory", b =>
                {
                    b.Property<int>("ChangeHistoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Comment")
                        .HasMaxLength(128);

                    b.Property<int>("OriginEntityId");

                    b.Property<int>("TargetEntityId");

                    b.Property<DateTime>("TimeChanged");

                    b.Property<int>("TypeOfChange");

                    b.HasKey("ChangeHistoryId");

                    b.ToTable("EFChangeHistory");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFClient", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AliasLinkId");

                    b.Property<int>("Connections");

                    b.Property<int>("CurrentAliasId");

                    b.Property<DateTime>("FirstConnection");

                    b.Property<DateTime>("LastConnection");

                    b.Property<int>("Level");

                    b.Property<bool>("Masked");

                    b.Property<long>("NetworkId");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordSalt");

                    b.Property<int>("TotalConnectionTime");

                    b.HasKey("ClientId");

                    b.HasIndex("AliasLinkId");

                    b.HasIndex("CurrentAliasId");

                    b.HasIndex("NetworkId")
                        .IsUnique();

                    b.ToTable("EFClients");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFMeta", b =>
                {
                    b.Property<int>("MetaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Extra");

                    b.Property<string>("Key")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("MetaId");

                    b.HasIndex("ClientId");

                    b.ToTable("EFMeta");
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFPenalty", b =>
                {
                    b.Property<int>("PenaltyId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("AutomatedOffense");

                    b.Property<DateTime>("Expires");

                    b.Property<int>("LinkId");

                    b.Property<int>("OffenderId");

                    b.Property<string>("Offense")
                        .IsRequired();

                    b.Property<int>("PunisherId");

                    b.Property<int>("Type");

                    b.Property<DateTime>("When");

                    b.HasKey("PenaltyId");

                    b.HasIndex("LinkId");

                    b.HasIndex("OffenderId");

                    b.HasIndex("PunisherId");

                    b.ToTable("EFPenalties");
                });

            modelBuilder.Entity("SharedLibraryCore.Helpers.Vector3", b =>
                {
                    b.Property<int>("Vector3Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EFACSnapshotSnapshotId");

                    b.Property<float>("X");

                    b.Property<float>("Y");

                    b.Property<float>("Z");

                    b.HasKey("Vector3Id");

                    b.HasIndex("EFACSnapshotSnapshotId");

                    b.ToTable("Vector3");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFACSnapshot", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "CurrentViewAngle")
                        .WithMany()
                        .HasForeignKey("CurrentViewAngleId");

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "HitDestination")
                        .WithMany()
                        .HasForeignKey("HitDestinationVector3Id");

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "HitOrigin")
                        .WithMany()
                        .HasForeignKey("HitOriginVector3Id");

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "LastStrainAngle")
                        .WithMany()
                        .HasForeignKey("LastStrainAngleVector3Id");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientKill", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Attacker")
                        .WithMany()
                        .HasForeignKey("AttackerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "DeathOrigin")
                        .WithMany()
                        .HasForeignKey("DeathOriginVector3Id");

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "KillOrigin")
                        .WithMany()
                        .HasForeignKey("KillOriginVector3Id");

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Victim")
                        .WithMany()
                        .HasForeignKey("VictimId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SharedLibraryCore.Helpers.Vector3", "ViewAngles")
                        .WithMany()
                        .HasForeignKey("ViewAnglesVector3Id");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientMessage", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientRatingHistory", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFClientStatistics", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFHitLocationCount", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFClientStatistics")
                        .WithMany("HitLocations")
                        .HasForeignKey("ClientId", "ServerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFRating", b =>
                {
                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFClientRatingHistory", "RatingHistory")
                        .WithMany("Ratings")
                        .HasForeignKey("RatingHistoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("IW4MAdmin.Plugins.Stats.Models.EFServerStatistics", b =>
                {
                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFAlias", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFAliasLink", "Link")
                        .WithMany("Children")
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFClient", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFAliasLink", "AliasLink")
                        .WithMany()
                        .HasForeignKey("AliasLinkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SharedLibraryCore.Database.Models.EFAlias", "CurrentAlias")
                        .WithMany()
                        .HasForeignKey("CurrentAliasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFMeta", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Client")
                        .WithMany("Meta")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SharedLibraryCore.Database.Models.EFPenalty", b =>
                {
                    b.HasOne("SharedLibraryCore.Database.Models.EFAliasLink", "Link")
                        .WithMany("ReceivedPenalties")
                        .HasForeignKey("LinkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Offender")
                        .WithMany("ReceivedPenalties")
                        .HasForeignKey("OffenderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SharedLibraryCore.Database.Models.EFClient", "Punisher")
                        .WithMany("AdministeredPenalties")
                        .HasForeignKey("PunisherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SharedLibraryCore.Helpers.Vector3", b =>
                {
                    b.HasOne("IW4MAdmin.Plugins.Stats.Models.EFACSnapshot")
                        .WithMany("PredictedViewAngles")
                        .HasForeignKey("EFACSnapshotSnapshotId");
                });
#pragma warning restore 612, 618
        }
    }
}
