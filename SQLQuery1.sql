CREATE TABLE MonetaryDonations (
ID INT IDENTITY PRIMARY KEY NOT NULL,
Name VARCHAR (255),
Date VARCHAR (225),
Amount DECIMAL(13,2)
);

CREATE TABLE Inventory (
ID INT IDENTITY PRIMARY KEY NOT NULL,
GoodsName VARCHAR (255),
GoodsPrice DECIMAL(13,2)
);
SELECT SUM(Amount)
FROM MonetaryDonations

INSERT INTO MonetaryDonations VALUES('Kevin', '11 June 2022', 587),
									('David', '15 June 2022', 9633),
									('Phillip',	'17 June 2022',	9644),
									('Cancelo',	'19 June 2022',	55),
									('BongUmusa', '26 August 2022', 2555);

ALTER TABLE Disasters
ADD AllocatedMoney DECIMAL(13,2);

ALTER TABLE Disasters
ADD AllocatedGoods varchar(255);

UPDATE Disasters
SET AllocatedMoney = 0, AllocatedGoods = 'None'
WHERE ID = 1;

UPDATE Disasters
SET AllocatedMoney = 0, AllocatedGoods = 'None'
WHERE ID = 2;

UPDATE Disasters
SET AllocatedMoney = 0, AllocatedGoods = 'None'
WHERE ID = 3;

UPDATE Disasters
SET AllocatedMoney = 0, AllocatedGoods = 'None'
WHERE ID = 4;

UPDATE Disasters
SET AllocatedMoney = 0, AllocatedGoods = 'None'
WHERE ID = 5;
