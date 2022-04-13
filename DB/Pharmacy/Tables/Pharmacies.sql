CREATE TABLE [dbo].[Pharmacies] (
    [PharmacyId] UNIQUEIDENTIFIER NOT NULL,
    [PhName]         NCHAR (30)       NOT NULL,
    [StateCode]    NCHAR (20)       NOT NULL,
    [Address]      NCHAR (30)       NOT NULL,
    [ContactEmail] NCHAR (50)       NOT NULL,
    [ContactPhone] NCHAR (20)       NOT NULL,
    PRIMARY KEY CLUSTERED ([PharmacyId] ASC)
);

