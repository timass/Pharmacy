CREATE TABLE [dbo].[Pharmacies] (
    [PharmaciesId] UNIQUEIDENTIFIER NOT NULL,
    [Name]         NCHAR (20)       NOT NULL,
    [StateCode]    NCHAR (20)       NOT NULL,
    [Address]      NCHAR (30)       NOT NULL,
    [ContactEmail] NCHAR (20)       NOT NULL,
    [ContactPhone] NCHAR (20)       NOT NULL,
    PRIMARY KEY CLUSTERED ([PharmaciesId] ASC)
);

