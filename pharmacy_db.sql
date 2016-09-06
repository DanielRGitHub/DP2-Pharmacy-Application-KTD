CREATE SCHEMA IF NOT EXISTS `pharmacy_db` DEFAULT CHARACTER SET utf8 ;
USE `pharmacy_db`;

CREATE TABLE Manufacturer
(
manufacturer_id INT NOT NULL AUTO_INCREMENT,
manufacturer_name VARCHAR(40) NOT NULL,
PRIMARY KEY(manufacturer_id)
);

CREATE TABLE Product
(
manufacturer_id INT NOT NULL,
brand_name VARCHAR(40) NOT NULL,
product_id INT NOT NULL AUTO_INCREMENT,
product_price SMALLINT(4) UNSIGNED NOT NULL,
PRIMARY KEY(product_id),
FOREIGN KEY(manufacturer_id) REFERENCES Manufacturer(manufacturer_id)
);

CREATE TABLE SalesDate
(
sales_date_id INT NOT NULL AUTO_INCREMENT,
`month` VARCHAR(9) NOT NULL,
`year` SMALLINT(4) UNSIGNED NOT NULL,
PRIMARY KEY(sales_date_id)
);

CREATE TABLE Sales
(
sales_id INT NOT NULL AUTO_INCREMENT,
sales_date_id INT NOT NULL,
quantity SMALLINT(4) UNSIGNED NOT NULL,
product_id INT NOT NULL,
PRIMARY KEY(sales_id),
FOREIGN KEY(sales_date_id) REFERENCES SalesDate(sales_date_id),
FOREIGN KEY(product_id) REFERENCES Product(product_id)
);

INSERT INTO Manufacturer(manufacturer_name) 
VALUES ('GlaxoSmithKline');
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (1, 'Zantac 150mg Tablets 60', 10.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (1, 'Flixonase Allergy Nasal Spray 120 Doses', 24.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (1, 'Nicabate Minis 4mg 60', 16.00);

INSERT INTO Manufacturer(manufacturer_name) 
VALUES ('Sigma Pharmaceuticals');

INSERT INTO Manufacturer(manufacturer_name) 
VALUES ('Pfizer');
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (3, 'Norvasc 10mg Tablets 30', 16.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (3, 'Chapstick Lip Balm Hydration Lock 4.4g', 4.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (3, 'Sudafed PE Sinus Relief 48 Tablets', 17.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (3, 'Mylanta Ranitidine 300mg 14 Tablets', 11.00);

INSERT INTO Manufacturer(manufacturer_name) 
VALUES ('Johnson & Johnson');
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (4, 'Johnson & Johnson All Purpose Pad 50', 2.70);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (4, 'Johnson & Johnson Cream Wash Dreamy Skin', 8.40);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (4, 'Johnson & Johnson Wipes Dry 3 x 25 Pack', 14.40);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (4, 'Johnson & Johnson Baby Bath & Wash 828ml', 10.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (4, 'Johnson & Johnson - Baby Bath Milk 800ml', 10.00);

INSERT INTO Manufacturer(manufacturer_name) 
VALUES ('Astra Zeneca');
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (5, 'Nexium 40mg Tablets 30', 32.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (5, 'Crestor 10mg Tablets 30', 18.00);
INSERT INTO Product(manufacturer_id, brand_name, product_price) 
VALUES (5, 'Xylocaine Ointment 5% 35g', 39.00);

INSERT INTO SalesDate(`month`, `year`) 
VALUES ('January', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('February', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('March', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('April', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('May', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('June', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('July', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('August', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('September', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('October', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('November', 2016);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('December', 2016);

INSERT INTO SalesDate(`month`, `year`) 
VALUES ('January', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('February', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('March', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('April', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('May', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('June', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('July', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('August', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('September', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('October', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('November', 2017);
INSERT INTO SalesDate(`month`, `year`) 
VALUES ('December', 2017);




