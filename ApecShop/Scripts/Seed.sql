use ApecShop;

DELETE FROM Genders;

SET IDENTITY_INSERT Genders OFF
INSERT INTO Genders (GenderID, Title) VALUES
(1, 'm�nnlich'),
(2, 'weiblich'),
(3, 'offen')
SET IDENTITY_INSERT Genders ON
