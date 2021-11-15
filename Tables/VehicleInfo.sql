CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[VehicleNumber] varchar(10),
	[RegistrationNumber] varchar(10),
	[VehicleType] varchar(25),
	[Manufacturer] varchar(25),
	[EngineSize] int,
	[CurrentOdometerReading] int,
	[NextOdometerReading] int



)
