CREATE TABLE [dbo].[WeeklyAppointment]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[VehicleNo] varchar(10),
	[Appointment] date,
	[Services] varchar(30),
	[ProcedureCode] varchar(10),
	[Description] varchar(100)
)
