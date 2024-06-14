CREATE DATABASE MkuProductsDB;
GO

USE MkuProductsDB;
CREATE TABLE Products
(
    Id          INT PRIMARY KEY,
    ProductName TEXT
)
CREATE TABLE Categories
(
    Id           INT PRIMARY KEY,
    CategoryName TEXT
)
CREATE TABLE ProductCategories
(
    ProductId  INT REFERENCES Products (Id),
    CategoryId INT REFERENCES Categories (Id),
    PRIMARY KEY (ProductId, CategoryId)
)

INSERT INTO Products VALUES (1, 'smartphone'), (2, 'auto'), (3, 'laptop'), (4, 'bicycle'), (5, 'table'), (6, 'bird'), (7, 'small bird')
INSERT INTO Categories VALUES (1, 'transport'), (2, 'wooden'), (3, 'forniture'), (4, 'electronic'), (5, 'plastic'), (6, 'whitecolor'), (7, 'redcolor'), (8, 'metal'), (9, 'swimmer'), (10, 'nobirds')
INSERT INTO ProductCategories VALUES (1, 4), (1, 5), (1, 6), (2, 1), (2, 7), (2, 8), (3, 4), (3, 5), (4, 1), (4, 8), (5, 2), (5, 3)

SELECT Products.ProductName, Categories.CategoryName
FROM Products
         LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
         LEFT JOIN Categories ON Categories.Id = ProductCategories.CategoryId