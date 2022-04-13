
CREATE PROCEDURE SPGetPharmacies AS
BEGIN
    SELECT PharmacyId, PhName, StateCode, Address, ContactEmail, ContactPhone
    FROM Pharmacies
END;