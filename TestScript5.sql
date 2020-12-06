INSERT INTO myshop.suppliers (SupplierName, City, Country) 
VALUES ('Norske Meierier', 'Lviv', 'Ukraine');
INSERT INTO myshop.products (ProductName, SupplierID, CategoryID, Price) 
VALUES ('Green tea', (SELECT SupplierID FROM myshop.suppliers WHERE SupplierName = "Norske Meierier"), 
(SELECT CategoryID FROM myshop.categories WHERE CategoryName = "Beverages"), 10)