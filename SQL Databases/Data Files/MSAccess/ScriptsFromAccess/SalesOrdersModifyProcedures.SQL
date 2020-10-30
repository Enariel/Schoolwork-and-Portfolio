CREATE PROCEDURE CH15_Adjust_Accessory_Retail_Price
AS 
UPDATE Products
INNER JOIN Product_Vendors
ON Products.ProductNumber=Product_Vendors.ProductNumber SET Products.RetailPrice = Round(1.35*Product_Vendors.WholeSalePrice,0)
WHERE (Products.RetailPrice<1.35*Product_Vendors.WholeSalePrice)
AND (Product_Vendors.WholesalePrice=DMax('WholeSalePrice','Product_Vendors','Product_Vendors.ProductNumber = ' & Products.ProductNumber))
AND (Products.CategoryID=1);


CREATE VIEW CH15_Adjust_Accessory_Retail_Price_Query
AS 
SELECT Products.ProductNumber, Products.ProductName, Products.RetailPrice, Round(1.35*Product_Vendors.WholeSalePrice,0) AS UpdatedPrice
FROM Products
INNER JOIN Product_Vendors
ON Products.ProductNumber=Product_Vendors.ProductNumber
WHERE (Products.RetailPrice<1.35*Product_Vendors.WholeSalePrice)
AND (Product_Vendors.WholesalePrice=DMax('WholeSalePrice','Product_Vendors','Product_Vendors.ProductNumber = ' & Products.ProductNumber))
AND (Products.CategoryID=1);


CREATE PROCEDURE CH15_Adjust_Bike_Retail_Price
AS 
UPDATE Products
INNER JOIN Product_Vendors
ON Products.ProductNumber=Product_Vendors.ProductNumber SET Products.RetailPrice = ROUND(1.45*Product_Vendors.WholeSalePrice,0)
WHERE (Products.RetailPrice<1.45*Product_Vendors.WholeSalePrice)
AND (Product_Vendors.WholesalePrice=DMin('WholeSalePrice','Product_Vendors','Product_Vendors.ProductNumber = ' & Products.ProductNumber))
AND (Products.CategoryID=2);


CREATE VIEW CH15_Adjust_Bike_Retail_Price_Query
AS 
SELECT Products.RetailPrice, ROUND(1.45*Product_Vendors.WholeSalePrice,0) AS UpdatedPrice
FROM Products
INNER JOIN Product_Vendors
ON Products.ProductNumber=Product_Vendors.ProductNumber
WHERE (Products.RetailPrice<1.45*Product_Vendors.WholeSalePrice)
AND (Product_Vendors.WholesalePrice=DMin('WholeSalePrice','Product_Vendors','Product_Vendors.ProductNumber = ' & Products.ProductNumber))
AND (Products.CategoryID=2);


CREATE PROCEDURE CH15_Adjust_Late_Order_Prices
AS 
UPDATE Order_Details SET QuotedPrice = Round(QuotedPrice*0.98,2)
WHERE OrderNumber IN  (SELECT OrderNumber FROM Orders WHERE DateDiff('d', OrderDate, ShipDate)>30);


CREATE VIEW CH15_Adjust_Late_Order_Prices_Query
AS 
SELECT OrderNumber, ProductNumber, QuotedPrice, Round(QuotedPrice*0.98,2) AS UpdatedPrice
FROM Order_Details
WHERE OrderNumber IN  (SELECT OrderNumber FROM Orders WHERE DateDiff('d', OrderDate, ShipDate)>30);


CREATE PROCEDURE CH15_Give_Discount_To_Good_October_Customers
AS 
UPDATE Order_Details SET QuotedPrice = Round(QuotedPrice*0.95,2)
WHERE Order_Details.OrderNumber IN (SELECT Orders.OrderNumber FROM Orders WHERE Orders.CustomerID IN (SELECT O2.CustomerID FROM Orders As O2 
INNER JOIN Order_Details
ON O2.OrderNumber = Order_Details.OrderNumber WHERE O2.OrderDate Between '10/1/2012'
AND '10/31/2012' GROUP BY O2.CustomerID HAVING Sum((Order_Details)(QuotedPrice)*(Order_Details)(QuantityOrdered))>50000));


CREATE VIEW CH15_Give_Discount_To_Good_October_Customers_Query
AS 
SELECT QuotedPrice, Round(QuotedPrice*0.95,2) AS UpdatedPrice
FROM Order_Details
WHERE Order_Details.OrderNumber IN 
(SELECT Orders.OrderNumber 
  FROM Orders 
  WHERE Orders.CustomerID IN 
  (SELECT O2.CustomerID 
    FROM Orders As O2 
INNER JOIN Order_Details 
     
ON O2.OrderNumber = Order_Details.OrderNumber 
    WHERE O2.OrderDate Between '10/1/2012'
AND '10/31/2012' 
    GROUP BY O2.CustomerID 
    HAVING Sum((Order_Details)(QuotedPrice)*(Order_Details)(QuantityOrdered))>50000));


CREATE PROCEDURE CH15_Update_Order_Totals_Subquery
AS 
UPDATE Orders SET Orders.OrderTotal = CCur(NZ(DSum('(QuotedPrice) * (QuantityOrdered)','Order_Details','OrderNumber = ' & (Orders)(OrderNumber)),0));


CREATE VIEW CH15_Update_Order_Totals_Subquery_Query
AS 
SELECT Orders.OrderTotal, CCur(NZ(DSum('(QuotedPrice) * (QuantityOrdered)','Order_Details','OrderNumber = ' & (Orders)(OrderNumber)),0)) AS NewTotal
FROM Orders;


CREATE PROCEDURE CH16_Add_Customer
AS 
INSERT INTO Customers ( CustFirstName, CustLastName, CustStreetAddress, CustCity, CustState, CustZipCode, CustAreaCode, CustPhoneNumber )
VALUES ('Mary', 'Baker', '7834 W 32nd Ct', 'Bothell', 'WA', '98011', 425, '555-9876');


CREATE VIEW CH16_Add_Customer_Query
AS
SELECT 'Mary' AS CustFirstName, 'Baker' AS CustLastName, '7834 W 32nd Ct' AS CustStreetAddress, 'Bothell' AS CustCity, 'WA' AS CUstState, '98011' AS CustZipCode, 425 AS CustAreaCode, '555-9876' AS CustPhoneNumber
FROM Customers
WHERE CustomerID=1001;


CREATE PROCEDURE CH16_Add_Employee
AS 
INSERT INTO Employees ( EmpFirstName, EmpLastName, EmpStreetAddress, EmpCity, EmpState, EmpZipCode, EmpAreaCode, EmpPhoneNumber )
VALUES ('Susan', 'Metters', '16547 NE 132nd St', 'Woodinville', 'WA', '98072', 425, '555-7825');


CREATE VIEW CH16_Add_Employee_Query
AS
SELECT 'Susan' As EmpFirstName, 'Metters' As EmpLastName, '16547 NE 132nd St' As EmpStreetAddress, 'Woodinville' As EmpCity, 'WA' As EmpState, '98072' As EmpZipCode, 425 As EmpAreaCode, '555-7825' As EmpPhoneNumber
FROM Employees
WHERE EmployeeID = 701;


CREATE PROCEDURE CH16_Add_Product
AS 
INSERT INTO Products ( ProductName, RetailPrice, CategoryID )
SELECT 'Hot Dog Spinner', 895, CategoryID
FROM Categories
WHERE CategoryDescription='Bikes';


CREATE VIEW CH16_Add_Product_Query
AS
SELECT 'Hot Dog Spinner' AS ProductName, 895 AS RetailPrice, CategoryID
FROM Categories
WHERE CategoryDescription='Bikes';


CREATE PROCEDURE CH16_Add_Vendor
AS 
INSERT INTO Vendors ( VendName, VendStreetAddress, VendCity, VendState, VendZipCode, VendPhoneNumber, VendFaxNumber, VendWebPage, VendEMailAddress )
VALUES ('Hot Dog Bikes', '1234 Main Street', 'Chicago', 'IL', '60620', '(773) 555-6543', '(773) 555-6542', 'http://www.hotdogbikes.com/', 'Sales@hotdogbikes.com');


CREATE VIEW CH16_Add_Vendor_Query
AS
SELECT 'Hot Dog Bikes' As VendName, '1234 Main Street' As VendStreetAddress, 'Chicago' As VendCity, 'IL' As VendState, '60620' As VendZipCode, '(773) 555-6543' As VendPhoneNumber, '(773) 555-6542' As VendFaxNumber, 'http://www.hotdogbikes.com/' As VendWebPage, 'Sales@hotdogbikes.com' As VendEMailAddress
FROM Vendors
WHERE VendorID = 1;


CREATE PROCEDURE CH16_Archive_2012_Order_Details
AS 
INSERT INTO Order_Details_Archive
SELECT Order_Details.OrderNumber AS OrderNumber, Order_Details.ProductNumber AS ProductNumber, Order_Details.QuotedPrice AS QuotedPrice, Order_Details.QuantityOrdered AS QuantityOrdered
FROM Order_Details
WHERE Order_Details.OrderNumber IN
(SELECT OrderNumber
FROM Orders
WHERE (Orders.OrderDate<'1/1/2013'));


CREATE VIEW CH16_Archive_2012_Order_Details_Query
AS 
SELECT Order_Details.OrderNumber AS OrderNumber, Order_Details.ProductNumber AS ProductNumber, Order_Details.QuotedPrice AS QuotedPrice, Order_Details.QuantityOrdered AS QuantityOrdered
FROM Order_Details
WHERE Order_Details.OrderNumber IN
(SELECT OrderNumber
FROM Orders
WHERE (Orders.OrderDate<'1/1/2013'));


CREATE PROCEDURE CH16_Archive_2012_Orders
AS 
INSERT INTO Orders_Archive
SELECT Orders.OrderNumber AS OrderNumber, Orders.OrderDate AS OrderDate, Orders.ShipDate AS ShipDate, Orders.CustomerID AS CustomerID, Orders.EmployeeID AS EmployeeID, Orders.OrderTotal AS OrderTotal
FROM Orders
WHERE (Orders.OrderDate<'1/1/2013');


CREATE VIEW CH16_Archive_2012_Orders_Query
AS 
SELECT Orders.OrderNumber AS OrderNumber, Orders.OrderDate AS OrderDate, Orders.ShipDate AS ShipDate, Orders.CustomerID AS CustomerID, Orders.EmployeeID AS EmployeeID, Orders.OrderTotal AS OrderTotal
FROM Orders
WHERE (Orders.OrderDate<'1/1/2013');


CREATE PROCEDURE CH16_Copy_Customer_To_Employee
AS 
INSERT INTO Employees ( EmpFirstName, EmpLastName, EmpStreetAddress, EmpCity, EmpState, EmpZipCode, EmpAreaCode, EmpPhoneNumber )
SELECT Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, Customers.CustCity, Customers.CustState, Customers.CustZipCode, Customers.CustAreaCode, Customers.CustPhoneNumber
FROM Customers
WHERE (Customers.CustFirstName='David')
AND (Customers.CustLastName='Smith');


CREATE VIEW CH16_Copy_Customer_To_Employee_Query
AS 
SELECT Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, Customers.CustCity, Customers.CustState, Customers.CustZipCode, Customers.CustAreaCode, Customers.CustPhoneNumber
FROM Customers
WHERE (Customers.CustFirstName='David')
AND (Customers.CustLastName='Smith');


CREATE PROCEDURE CH16_Copy_Dec11_Order_For_Keyser
AS 
INSERT INTO Orders ( OrderNumber, OrderDate, ShipDate, CustomerID, EmployeeID, OrderTotal )
SELECT (OrderNumber)+1000 AS NewOrderNo, '6/12/2013' AS OrderDate, '6/15/2013' AS ShipDate, Orders.CustomerID, Orders.EmployeeID, Orders.OrderTotal
FROM Orders
WHERE (Orders.OrderDate='12/11/2012')
AND (Orders.CustomerID=(SELECT CustomerID FROM Customers WHERE CustFirstName = 'Liz'
AND CustLastName = 'Keyser'));


CREATE VIEW CH16_Copy_Dec11_Order_For_Keyser_Query
AS 
SELECT (OrderNumber)+1000 AS NewOrderNo, '6/12/2013' AS OrderDate, '6/15/2013' AS ShipDate, Orders.CustomerID, Orders.EmployeeID, Orders.OrderTotal
FROM Orders
WHERE (Orders.OrderDate='12/11/2012')
AND (Orders.CustomerID=(SELECT CustomerID FROM Customers WHERE CustFirstName = 'Liz'
AND CustLastName = 'Keyser'));


CREATE PROCEDURE CH16_Copy_Dec11_OrderDetails_For_Keyser
AS 
INSERT INTO Order_Details ( OrderNumber, ProductNumber, QuotedPrice, QuantityOrdered )
SELECT (OrderNumber)+1000 AS NewOrderNo, Order_Details.ProductNumber, Order_Details.QuotedPrice, Order_Details.QuantityOrdered
FROM Order_Details
WHERE Order_Details.OrderNumber In 
(SELECT OrderNumber 
FROM Orders 
WHERE OrderDate = '12/11/2012' 
AND CustomerID=
(SELECT CustomerID 
FROM Customers 
WHERE CustFirstName = 'Liz'
AND CustLastName = 'Keyser'));


CREATE VIEW CH16_Copy_Dec11_OrderDetails_For_Keyser_Query
AS 
SELECT (OrderNumber)+1000 AS NewOrderNo, Order_Details.ProductNumber, Order_Details.QuotedPrice, Order_Details.QuantityOrdered
FROM Order_Details
WHERE Order_Details.OrderNumber In 
(SELECT OrderNumber 
FROM Orders 
WHERE OrderDate = '12/11/2012' 
AND CustomerID=
(SELECT CustomerID 
FROM Customers 
WHERE CustFirstName = 'Liz'
AND CustLastName = 'Keyser'));


CREATE PROCEDURE CH16_Copy_November_OrderDetails_For_AKennedy
AS 
INSERT INTO Order_Details ( OrderNumber, ProductNumber, QuotedPrice, QuantityOrdered )
SELECT (OrderNumber)+1000 AS NewOrderNo, Order_Details.ProductNumber, Order_Details.QuotedPrice, Order_Details.QuantityOrdered
FROM Order_Details
WHERE Order_Details.OrderNumber In 
(SELECT OrderNumber 
FROM Orders 
WHERE OrderDate BETWEEN '11/1/2012'
AND '11/30/2012' 
AND CustomerID=
(SELECT CustomerID 
FROM Customers 
WHERE CustFirstName = 'Angel'
AND CustLastName = 'Kennedy'));


CREATE VIEW CH16_Copy_November_OrderDetails_For_AKennedy_Query
AS 
SELECT (OrderNumber)+1000 AS NewOrderNo, Order_Details.ProductNumber, Order_Details.QuotedPrice, Order_Details.QuantityOrdered
FROM Order_Details
WHERE Order_Details.OrderNumber In 
(SELECT OrderNumber 
FROM Orders 
WHERE OrderDate BETWEEN '11/1/2012'
AND '11/30/2012' 
AND CustomerID=
(SELECT CustomerID 
FROM Customers 
WHERE CustFirstName = 'Angel'
AND CustLastName = 'Kennedy'));


CREATE PROCEDURE CH16_Copy_November_Orders_For_AKennedy
AS 
INSERT INTO Orders ( OrderNumber, OrderDate, ShipDate, CustomerID, EmployeeID, OrderTotal )
SELECT (OrderNumber)+1000 AS NewOrderNo, '6/15/2013' AS OrderDate, '6/18/2013' AS ShipDate, Orders.CustomerID, Orders.EmployeeID, Orders.OrderTotal
FROM Orders
WHERE (Orders.OrderDate BETWEEN '11/1/2012'
AND '11/30/2012')
AND (Orders.CustomerID=(SELECT CustomerID FROM Customers WHERE CustFirstName = 'Angel'
AND CustLastName = 'Kennedy'));


CREATE VIEW CH16_Copy_November_Orders_For_AKennedy_Query
AS 
SELECT (OrderNumber)+1000 AS NewOrderNo, '6/15/2013' AS OrderDate, '6/18/2013' AS ShipDate, Orders.CustomerID, Orders.EmployeeID, Orders.OrderTotal
FROM Orders
WHERE (Orders.OrderDate BETWEEN '11/1/2012'
AND '11/30/2012')
AND (Orders.CustomerID=(SELECT CustomerID FROM Customers WHERE CustFirstName = 'Angel'
AND CustLastName = 'Kennedy'));


CREATE PROCEDURE CH17_Delete_Archived_Order_Details_OK
AS 
DELETE Order_Details.*
FROM Order_Details
WHERE Order_Details.OrderNumber IN
(SELECT OrderNumber
FROM Order_Details_Archive);


CREATE VIEW CH17_Delete_Archived_Order_Details_OK_Query
AS 
SELECT Order_Details.*
FROM Order_Details
WHERE Order_Details.OrderNumber IN
(SELECT OrderNumber
FROM Order_Details_Archive);


CREATE PROCEDURE CH17_Delete_Archived_Order_Details_Unsafe
AS 
DELETE Order_Details.*
FROM Order_Details
WHERE Order_Details.OrderNumber IN
(SELECT OrderNumber
FROM Orders
WHERE Orders.OrderDate<'1/1/2013');


CREATE VIEW CH17_Delete_Archived_Order_Details_Unsafe_Query
AS 
SELECT Order_Details.*
FROM Order_Details
WHERE Order_Details.OrderNumber IN
(SELECT OrderNumber
FROM Orders
WHERE Orders.OrderDate<'1/1/2013');


CREATE PROCEDURE CH17_Delete_Archived_Orders_OK
AS 
DELETE Orders.*
FROM Orders
WHERE Orders.OrderNumber IN
(SELECT OrderNumber
FROM Orders_Archive);


CREATE VIEW CH17_Delete_Archived_Orders_OK_Query
AS 
SELECT Orders.*
FROM Orders
WHERE Orders.OrderNumber IN
(SELECT OrderNumber
FROM Orders_Archive);


CREATE PROCEDURE CH17_Delete_Archived_Orders_Unsafe
AS 
DELETE Orders.*
FROM Orders
WHERE (Orders.OrderDate<'1/1/2013');


CREATE VIEW CH17_Delete_Archived_Orders_Unsafe_Query
AS 
SELECT Orders.*
FROM Orders
WHERE (Orders.OrderDate<'1/1/2013');


CREATE PROCEDURE CH17_Delete_Categories_No_Products
AS 
DELETE Categories.*
FROM Categories
WHERE (Categories.CategoryID Not In (SELECT CategoryID FROM Products));


CREATE VIEW CH17_Delete_Categories_No_Products_Query
AS 
SELECT Categories.*
FROM Categories
WHERE (Categories.CategoryID Not In (SELECT CategoryID FROM Products));


CREATE PROCEDURE CH17_Delete_Customers_Never_Ordered
AS 
DELETE Customers.*
FROM Customers
WHERE (Customers.CustomerID Not In (SELECT CustomerID FROM Orders));


CREATE VIEW CH17_Delete_Customers_Never_Ordered_Query
AS 
SELECT Customers.*
FROM Customers
WHERE (Customers.CustomerID Not In (SELECT CustomerID FROM Orders));


CREATE PROCEDURE CH17_Delete_Employees_No_Orders
AS 
DELETE Employees.*
FROM Employees
WHERE (Employees.EmployeeID Not In (SELECT EmployeeID FROM Orders));


CREATE VIEW CH17_Delete_Employees_No_Orders_Query
AS 
SELECT Employees.*
FROM Employees
WHERE (Employees.EmployeeID Not In (SELECT EmployeeID FROM Orders));


CREATE PROCEDURE CH17_Delete_Products_Never_Ordered_1
AS 
DELETE Product_Vendors.*
FROM Product_Vendors
WHERE (Product_Vendors.ProductNumber Not In (SELECT ProductNumber FROM Order_Details));


CREATE VIEW CH17_Delete_Products_Never_Ordered_1_Query
AS 
SELECT Product_Vendors.*
FROM Product_Vendors
WHERE (Product_Vendors.ProductNumber Not In (SELECT ProductNumber FROM Order_Details));


CREATE PROCEDURE CH17_Delete_Products_Never_Ordered_2
AS 
DELETE Products.*
FROM Products
WHERE (Products.ProductNumber Not In (SELECT ProductNumber FROM Order_Details));


CREATE VIEW CH17_Delete_Products_Never_Ordered_2_Query
AS 
SELECT Products.*
FROM Products
WHERE (Products.ProductNumber Not In (SELECT ProductNumber FROM Order_Details));


CREATE PROCEDURE CH17_Delete_Vendors_No_Products
AS 
DELETE Vendors.*
FROM Vendors
WHERE (Vendors.VendorID Not In (SELECT VendorID FROM Product_Vendors));


CREATE VIEW CH17_Delete_Vendors_No_Products_Query
AS 
SELECT Vendors.*
FROM Vendors
WHERE (Vendors.VendorID Not In (SELECT VendorID FROM Product_Vendors));


CREATE PROCEDURE CH17_Delete_Zero_OrdersA
AS 
DELETE Orders.*
FROM Orders
WHERE Orders.OrderTotal=0;


CREATE VIEW CH17_Delete_Zero_OrdersA_Query
AS 
SELECT Orders.*
FROM Orders
WHERE Orders.OrderTotal=0;


CREATE PROCEDURE CH17_Delete_Zero_OrdersB
AS 
DELETE Orders.*
FROM Orders
WHERE Orders.OrderNumber Not IN (SELECT OrderNumber FROM Order_Details);


CREATE VIEW CH17_Delete_Zero_OrdersB_Query
AS 
SELECT Orders.*
FROM Orders
WHERE Orders.OrderNumber Not IN (SELECT OrderNumber FROM Order_Details);


