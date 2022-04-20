
CREATE PROCEDURE SPCreatePharmacy
@PharmacyId uniqueidentifier = NULL,
@PhName nchar(20) = NULL,
@StateCode nchar(20) = NULL,
@Address nchar(30) = NULL,
@ContactEmail nchar(20) =NULL,
@ContactPhone nchar(20) =NULL
AS
BEGIN
INSERT INTO Pharmacies (PharmacyId,PhName, StateCode, Address, ContactEmail, ContactPhone)
VALUES (@PharmacyId, @PhName, @StateCode, @Address, @ContactEmail, @ContactPhone)
END
