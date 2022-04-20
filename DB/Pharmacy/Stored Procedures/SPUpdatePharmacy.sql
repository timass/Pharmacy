CREATE PROCEDURE SPUpdatePharmacy
@PharmacyId uniqueidentifier = NULL,
@PhName nchar(20) = NULL,
@StateCode nchar(20) = NULL,
@Address nchar(30) = NULL,
@ContactEmail nchar(20) =NULL,
@ContactPhone nchar(20) =NULL
AS
BEGIN
UPDATE Pharmacies
SET PhName = @PhName, StateCode = @StateCode, Address = @Address,
ContactEmail = @ContactEmail, ContactPhone = @ContactPhone
WHERE PharmacyId = @PharmacyId
END