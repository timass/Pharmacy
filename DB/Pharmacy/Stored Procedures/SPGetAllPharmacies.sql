
CREATE PROCEDURE SPGetPharmacies AS
BEGIN
    SELECT PhName, StateCode, Address, ContactEmail, ContactPhone
    FROM Pharmacies
END;