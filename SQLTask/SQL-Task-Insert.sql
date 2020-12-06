START TRANSACTION;
INSERT INTO myshop.suppliers (SupplierName, City, Country) 
VALUES ('Norske Meierier', 'Lviv', 'Ukraine');
INSERT INTO myshop.products (ProductName, SupplierID, CategoryID, Price) 
VALUES ('Green tea', LAST_INSERT_ID(), 
(SELECT CategoryID FROM myshop.categories WHERE CategoryName = "Beverages"), 10);
COMMIT;