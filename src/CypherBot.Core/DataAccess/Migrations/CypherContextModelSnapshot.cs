﻿// <auto-generated />
using CypherBot.Core.DataAccess.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CypherBot.Core.DataAccess.Migrations
{
    [DbContext(typeof(CypherContext))]
    partial class CypherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("CypherBot.Core.Models.Artifact", b =>
                {
                    b.Property<int>("ArtifactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Depletion")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Effect")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Form")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int>("LevelBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelDie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Source")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("ArtifactId");

                    b.ToTable("Artifacts");
                });

            modelBuilder.Entity("CypherBot.Core.Models.ArtifactQuirk", b =>
                {
                    b.Property<int>("ArtifactQuirkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EndRange")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quirk")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<int>("StartRange")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArtifactQuirkId");

                    b.ToTable("ArtifactQuirks");
                });

            modelBuilder.Entity("CypherBot.Core.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descriptor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Focus")
                        .HasColumnType("TEXT");

                    b.Property<int>("IntPool")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MightPool")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Player")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int>("RecoveryDie")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecoveryMod")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpeedPool")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tier")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int>("XP")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterAbility", b =>
                {
                    b.Property<int>("CharacterAbilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int>("Tier")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterAbilityId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterAbilities");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterArtifact", b =>
                {
                    b.Property<int>("ArtifactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Depletion")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Effect")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Form")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelDie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Quirk")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Source")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("ArtifactId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterArtifacts");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterCypher", b =>
                {
                    b.Property<int>("CypherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Effect")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("EffectOption")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Form")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelDie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Source")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.HasKey("CypherId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterCyphers");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterInventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.HasKey("InventoryId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterInventories");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterRecoveryRoll", b =>
                {
                    b.Property<int>("RecoveryRollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RollName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.HasKey("RecoveryRollId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterRecoveryRolls");
                });

            modelBuilder.Entity("CypherBot.Core.Models.Cypher", b =>
                {
                    b.Property<int>("CypherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Effect")
                        .HasColumnType("varchar(2000)");

                    b.Property<int>("LevelBonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelDie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Source")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(15);

                    b.HasKey("CypherId");

                    b.ToTable("Cyphers");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CypherEffectOption", b =>
                {
                    b.Property<int>("EffectOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CypherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<int>("EndRange")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StartRange")
                        .HasColumnType("INTEGER");

                    b.HasKey("EffectOptionId");

                    b.HasIndex("CypherId");

                    b.ToTable("CypherEffectOptions");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CypherFormOption", b =>
                {
                    b.Property<int>("FormOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CypherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Form")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("FormDescription")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.HasKey("FormOptionId");

                    b.HasIndex("CypherId");

                    b.ToTable("CypherFormOptions");
                });

            modelBuilder.Entity("CypherBot.Core.Models.Descriptor", b =>
                {
                    b.Property<int>("DescriptorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("DescriptorId");

                    b.ToTable("Descriptors");
                });

            modelBuilder.Entity("CypherBot.Core.Models.DescriptorAbility", b =>
                {
                    b.Property<int>("DescriptorAbilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<int>("DescriptorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Source")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int>("Tier")
                        .HasColumnType("INTEGER");

                    b.HasKey("DescriptorAbilityId");

                    b.HasIndex("DescriptorId");

                    b.ToTable("DescriptorAbilities");
                });

            modelBuilder.Entity("CypherBot.Core.Models.Focus", b =>
                {
                    b.Property<int>("FocusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("FocusId");

                    b.ToTable("Foci");
                });

            modelBuilder.Entity("CypherBot.Core.Models.FocusAbility", b =>
                {
                    b.Property<int>("FocusAbilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<int>("FocusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Source")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int>("Tier")
                        .HasColumnType("INTEGER");

                    b.HasKey("FocusAbilityId");

                    b.HasIndex("FocusId");

                    b.ToTable("FociAbilities");
                });

            modelBuilder.Entity("CypherBot.Core.Models.Oddity", b =>
                {
                    b.Property<int>("OddityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OddityDescription")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.HasKey("OddityId");

                    b.ToTable("Oddities");
                });

            modelBuilder.Entity("CypherBot.Core.Models.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<int>("IntellectStartingPool")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MightStartingPool")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int>("SpeedStartingPool")
                        .HasColumnType("INTEGER");

                    b.HasKey("TypeId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("CypherBot.Core.Models.TypeAbility", b =>
                {
                    b.Property<int>("TypeAbilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Source")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int>("Tier")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TypeAbilityId");

                    b.HasIndex("TypeId");

                    b.ToTable("TypeAbilities");
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterAbility", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Character", "Character")
                        .WithMany("Abilities")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterArtifact", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Character", "Character")
                        .WithMany("Artifacts")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterCypher", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Character", "Character")
                        .WithMany("Cyphers")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterInventory", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Character", "Character")
                        .WithMany("Inventory")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.CharacterRecoveryRoll", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Character", "Character")
                        .WithMany("RecoveryRolls")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.CypherEffectOption", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Cypher", "Cypher")
                        .WithMany("EffectOptions")
                        .HasForeignKey("CypherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.CypherFormOption", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Cypher", "Cypher")
                        .WithMany("Forms")
                        .HasForeignKey("CypherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.DescriptorAbility", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Descriptor", "Descriptor")
                        .WithMany("DescriptorAbilities")
                        .HasForeignKey("DescriptorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.FocusAbility", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Focus", "Focus")
                        .WithMany("FocusAbilities")
                        .HasForeignKey("FocusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CypherBot.Core.Models.TypeAbility", b =>
                {
                    b.HasOne("CypherBot.Core.Models.Type", "Type")
                        .WithMany("TypeAbilities")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
