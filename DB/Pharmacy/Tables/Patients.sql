CREATE TABLE [dbo].[Patients] (
    [PatientsId]         UNIQUEIDENTIFIER NOT NULL,
    [FirstName]          NCHAR (20)       NOT NULL,
    [LastName]           NCHAR (20)       NOT NULL,
    [StateCode]          NCHAR (20)       NOT NULL,
    [PharmacyName]       NCHAR (20)       NOT NULL,
    [PharmacyAssignDate] DATETIME         NOT NULL,
    PRIMARY KEY CLUSTERED ([PatientsId] ASC)
);

