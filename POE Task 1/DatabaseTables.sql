CREATE TABLE GoodsDonations
(
ID INT NOT NULL PRIMARY KEY IDENTITY,
Donor VARCHAR(225) NOT NULL,
Date VARCHAR(225) NOT NULL,
NumberOfItems INT NOT NULL,
Category VARCHAR(225) NOT NULL,
Description VARCHAR(255) NOT NULL
);

CREATE TABLE Disasters
(
ID INT NOT NULL PRIMARY KEY IDENTITY,
StartDate VARCHAR(225) NOT NULL,
EndDate VARCHAR(225) NOT NULL,
Location VARCHAR(225) NOT NULL,
Description VARCHAR(255) NOT NULL,
AidType VARCHAR(255) NOT NULL
);

INSERT INTO GoodsDonations VALUES('Anonymous','22 April 2022',5,'Clothes','2 Jerseys and 3 Skippers'),
								('Bernardeo Silva','5 June 2022',2,'Non-perishable foods','Banana and Apple'),
								('Captain Jack','9 October 2021',1,'Clothes','All Stars Sneakers');

INSERT INTO Disasters VALUES('1 January 2011','22 May 2015','Java Island, Indonisia','Tsunami','Shelter'),
							('2 February 2018','5 April 2018','Nairobi, Kenya','Drought','Water provision'),
							('18 October 2020','25 December 2020','Zimbabwe, Bulawayo','Earthquake','Food'),
							('7 March 2022','21 May 2022','South Africa, Durban','Floods','Clothing');
