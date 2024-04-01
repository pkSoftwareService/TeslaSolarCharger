﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeslaSolarCharger.Model.EntityFramework;

#nullable disable

namespace TeslaSolarCharger.Model.Migrations
{
    [DbContext(typeof(TeslaSolarChargerContext))]
    partial class TeslaSolarChargerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.CachedCarState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarStateJson")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CachedCarStates");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChargeMode")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChargerActualCurrent")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChargerPhases")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChargerPilotCurrent")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChargerRequestedCurrent")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChargerVoltage")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChargingPriority")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("ClimateOn")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IgnoreLatestTimeToReachSocDate")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LatestTimeToReachSoC")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double?>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<int>("MaximumAmpere")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinimumAmpere")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinimumSoc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("PluggedIn")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("ShouldBeManaged")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("ShouldSetChargeStartTimes")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SoC")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SocLimit")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeslaFleetApiState")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TeslaMateCarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsableEnergy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vin")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeslaMateCarId")
                        .IsUnique();

                    b.HasIndex("Vin")
                        .IsUnique();

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ChargePrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AddSpotPriceToGridPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EnergyProvider")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(6);

                    b.Property<string>("EnergyProviderConfiguration")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("GridPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SolarPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SpotPriceCorrectionFactor")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ValidSince")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ChargePrices");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ChargingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChargingProcessId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GridPower")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SolarPower")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChargingProcessId");

                    b.ToTable("ChargingDetails");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ChargingProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OldHandledChargeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("UsedGridEnergyKwh")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("UsedSolarEnergyKwh")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("ChargingProcesses");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.HandledCharge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("AverageSpotPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("CalculatedPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChargingProcessId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("UsedGridEnergy")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("UsedSolarEnergy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HandledCharges");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ModbusConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Address")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BitLength")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BitStartIndex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConnectDelaySeconds")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CorrectionFactor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Endianess")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("InvertsModbusConfigurationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Operator")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReadTimeoutSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RegisterType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnitIdentifier")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsedFor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ValueType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InvertsModbusConfigurationId");

                    b.ToTable("ModbusConfigurations");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.PowerDistribution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChargingPower")
                        .HasColumnType("INTEGER");

                    b.Property<float>("GridProportion")
                        .HasColumnType("REAL");

                    b.Property<int>("HandledChargeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PowerFromGrid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<float?>("UsedWattHours")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("HandledChargeId");

                    b.ToTable("PowerDistributions");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HttpMethod")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NodePatternType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RestValueConfigurations");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueConfigurationHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RestValueConfigurationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RestValueConfigurationId", "Key")
                        .IsUnique();

                    b.ToTable("RestValueConfigurationHeaders");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueResultConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CorrectionFactor")
                        .HasColumnType("TEXT");

                    b.Property<string>("NodePattern")
                        .HasColumnType("TEXT");

                    b.Property<int>("Operator")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RestValueConfigurationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsedFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("XmlAttributeHeaderName")
                        .HasColumnType("TEXT");

                    b.Property<string>("XmlAttributeHeaderValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("XmlAttributeValueName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RestValueConfigurationId");

                    b.ToTable("RestValueResultConfigurations");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.SpotPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SpotPrices");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.TeslaToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiresAtUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Region")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnauthorizedCounter")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TeslaTokens");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.TscConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("TscConfigurations");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ChargingDetail", b =>
                {
                    b.HasOne("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ChargingProcess", "ChargingProcess")
                        .WithMany("ChargingDetails")
                        .HasForeignKey("ChargingProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChargingProcess");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ChargingProcess", b =>
                {
                    b.HasOne("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.Car", "Car")
                        .WithMany("ChargingProcesses")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ModbusConfiguration", b =>
                {
                    b.HasOne("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ModbusConfiguration", "InvertsModbusConfiguration")
                        .WithMany()
                        .HasForeignKey("InvertsModbusConfigurationId");

                    b.Navigation("InvertsModbusConfiguration");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.PowerDistribution", b =>
                {
                    b.HasOne("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.HandledCharge", "HandledCharge")
                        .WithMany("PowerDistributions")
                        .HasForeignKey("HandledChargeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HandledCharge");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueConfigurationHeader", b =>
                {
                    b.HasOne("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueConfiguration", "RestValueConfiguration")
                        .WithMany("Headers")
                        .HasForeignKey("RestValueConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RestValueConfiguration");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueResultConfiguration", b =>
                {
                    b.HasOne("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueConfiguration", "RestValueConfiguration")
                        .WithMany("RestValueResultConfigurations")
                        .HasForeignKey("RestValueConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RestValueConfiguration");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.Car", b =>
                {
                    b.Navigation("ChargingProcesses");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.ChargingProcess", b =>
                {
                    b.Navigation("ChargingDetails");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.HandledCharge", b =>
                {
                    b.Navigation("PowerDistributions");
                });

            modelBuilder.Entity("TeslaSolarCharger.Model.Entities.TeslaSolarCharger.RestValueConfiguration", b =>
                {
                    b.Navigation("Headers");

                    b.Navigation("RestValueResultConfigurations");
                });
#pragma warning restore 612, 618
        }
    }
}
