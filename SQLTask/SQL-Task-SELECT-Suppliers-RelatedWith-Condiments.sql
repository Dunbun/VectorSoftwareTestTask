SELECT * FROM myshop.suppliers WHERE SupplierID IN 
(SELECT SupplierID FROM myshop.products WHERE CategoryID IN
(SELECT CategoryID FROM myshop.categories WHERE CategoryName = "Condiments") )