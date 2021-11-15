CREATE TABLE [dbo].[CallService]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[VehicleNo]     VARCHAR (10)  not null,
    [Appointment]   DATE          NULL,
	[ServiceType] varchar(25),
	[WorkToBeCompleted] varchar(25)
)
