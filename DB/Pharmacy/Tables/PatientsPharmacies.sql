CREATE TABLE [dbo].[PatientsPharmacies] (
    [PatientsId]   UNIQUEIDENTIFIER NOT NULL,
    [PharmaciesId] UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([PatientsId] ASC, [PharmaciesId] ASC),
    FOREIGN KEY ([PatientsId]) REFERENCES [dbo].[Patients] ([PatientsId]),
    FOREIGN KEY ([PharmaciesId]) REFERENCES [dbo].[Pharmacies] ([PharmacyId])
);

