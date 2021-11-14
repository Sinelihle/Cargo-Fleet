CREATE TABLE [dbo].[DailyAppointment]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[VehicleNo]     VARCHAR (10)  NULL,
    [Appointment]   DATE          NULL,
    [Services]      VARCHAR (30)  NULL,
    [ProcedureCode] VARCHAR (10)  NULL,
    [Description]   VARCHAR (100) NULL,
)
