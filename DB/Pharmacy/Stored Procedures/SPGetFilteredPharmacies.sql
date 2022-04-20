CREATE PROCEDURE SPGetFilteredPharmacies
@PharmacyId uniqueidentifier = NULL,
@PhName nchar(20) = NULL,
@StateCode nchar(20) = NULL,
@Address nchar(30) = NULL,
@ContactEmail nchar(20) =NULL,
@ContactPhone nchar(20) =NULL
AS
BEGIN
SELECT PharmacyId,
       PhName,
       StateCode,
	   Address,
	   ContactEmail,
	   ContactPhone
FROM Pharmacies
WHERE PharmacyId = COALESCE(@PharmacyId,PharmacyId) AND
      PhName = COALESCE(@PhName,PhName) AND
      StateCode = COALESCE(@StateCode,StateCode) AND
	  Address = COALESCE(@Address,Address) AND
	  ContactEmail = COALESCE(@ContactEmail,ContactEmail) AND
	  ContactPhone = COALESCE(@ContactPhone,ContactPhone)
END
