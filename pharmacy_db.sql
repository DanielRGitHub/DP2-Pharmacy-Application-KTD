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



