﻿DROP TABLE IF EXISTS dbo.ProductCategory;
DROP TABLE IF EXISTS dbo.Category;
DROP TABLE IF EXISTS dbo.Product;

CREATE TABLE dbo.Category
(
    [Id]    INT PRIMARY KEY,
    [Title] VARCHAR(200) NOT NULL
);

CREATE TABLE dbo.Product
(
    [Id]    INT PRIMARY KEY,
    [Title] VARCHAR(200) NOT NULL
);

CREATE TABLE dbo.ProductCategory
(
    [ProductId]  INT NOT NULL,
    [CategoryId] INT NOT NULL,
    FOREIGN KEY ([ProductId]) REFERENCES dbo.Product ([Id]),
    FOREIGN KEY ([CategoryId]) REFERENCES dbo.Category ([Id]),
    PRIMARY KEY ([ProductId], [CategoryId])
);

INSERT INTO dbo.Category([Id], [Title])
VALUES (1, 'Category1'),
       (2, 'Category2'),
       (3, 'Category3');
INSERT INTO dbo.Product([Id], [Title])
VALUES (1, 'Product1'),
       (2, 'Product2'),
       (3, 'Product3');
INSERT INTO dbo.ProductCategory([ProductId], [CategoryId])
VALUES (1, 1),
       (1, 2),
       (1, 3);
