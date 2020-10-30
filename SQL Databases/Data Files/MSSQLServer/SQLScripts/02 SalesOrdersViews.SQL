USE SalesOrdersExample;
GO

CREATE VIEW CH04_Customer_States
AS
SELECT DISTINCT CustState
FROM Customers ;
GO

CREATE VIEW CH04_Employee_Information
AS
SELECT Employees.*
FROM Employees ;
GO

CREATE VIEW CH04_Product_Price_List
AS
SELECT ProductName, RetailPrice
FROM Products ;
GO

CREATE VIEW CH04_Vendor_Locations
AS
SELECT     TOP 100 PERCENT VendCity, VendName
FROM         Vendors
ORDER BY VendCity;
GO

CREATE VIEW CH04_Vendor_Names
AS
SELECT VendName
FROM Vendors ;
GO

CREATE VIEW CH05_Adjusted_Wholesale_Prices
AS
SELECT ProductNumber, WholesalePrice, WholesalePrice - (WholesalePrice * 0.05) AS NewPrice
FROM Product_Vendors ;
GO

CREATE VIEW CH05_Orders_By_Customer_And_Date
AS
SELECT     TOP 100 PERCENT CustomerID, OrderDate, OrderNumber
FROM         Orders
ORDER BY CustomerID, OrderDate DESC, OrderNumber;
GO

CREATE VIEW CH05_Product_Inventory_Value
AS
SELECT ProductName, RetailPrice * QuantityOnHand AS InventoryValue
FROM Products ;
GO

CREATE VIEW CH05_Shipping_Days_Analysis
AS
SELECT OrderNumber, OrderDate, ShipDate, DateDiff(d, OrderDate, ShipDate) AS DaysElapsed
FROM Orders ;
GO

CREATE VIEW CH05_Vendor_Addresses
AS
SELECT     TOP 100 PERCENT VendName, VendStreetAddress + ', ' + VendCity + '  ' + VendState + '  ' + VendZipCode AS VendCompleteAddress, 
                      VendPhoneNumber
FROM         Vendors
ORDER BY VendName;
GO

CREATE VIEW CH06_Ballard_Bellevue_Redmond_Vendors
AS
SELECT     TOP 100 PERCENT VendName, VendCity
FROM         Vendors
WHERE     (VendCity IN ('Ballard', 'Bellevue', 'Redmond'))
ORDER BY VendName;
GO

CREATE VIEW CH06_Orders_for_Customer_1001
AS
SELECT OrderNumber, CustomerID
FROM Orders
WHERE CustomerID = 1001 ;
GO

CREATE VIEW CH06_Products_Priced_Over_125
AS
SELECT     TOP 100 PERCENT ProductName, RetailPrice
FROM         Products
WHERE     (RetailPrice >= 125)
ORDER BY ProductName;
GO

CREATE VIEW CH06_Products_That_Begin_With_DOG
AS
SELECT     TOP 100 PERCENT ProductName
FROM         Products
WHERE     (ProductName LIKE 'Dog%')
ORDER BY ProductName;
GO

CREATE VIEW CH06_Vendors_With_No_Website
AS
SELECT     TOP 100 PERCENT VendName, VendWebPage
FROM         Vendors
WHERE     (VendWebPage IS NULL)
ORDER BY VendName;
GO

CREATE VIEW CH08_Customers_And_OrderDates
AS
SELECT     TOP 100 PERCENT Customers.CustFirstName + ' ' + Customers.CustLastName AS CustomerFullName, Orders.OrderDate
FROM         Customers INNER JOIN
                      Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY Orders.OrderDate;
GO

CREATE VIEW CH08_Customers_Both_Bikes_And_Helmets
AS
SELECT     CustBikes.CustFirstName, CustBikes.CustLastName
FROM         (SELECT DISTINCT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
              FROM          ((Customers 
                              INNER JOIN Orders 
                              ON Customers.CustomerID = Orders.CustomerID) 
                              INNER JOIN Order_Details 
                              ON Orders.OrderNumber = Order_Details.OrderNumber) 
                              INNER JOIN Products 
                              ON Products.ProductNumber = Order_Details.ProductNumber
              WHERE      Products.ProductName LIKE '%Bike') CustBikes 
        INNER JOIN
             (SELECT DISTINCT Customers.CustomerID
              FROM          ((Customers 
                              INNER JOIN Orders 
                              ON Customers.CustomerID = Orders.CustomerID) 
                              INNER JOIN Order_Details 
                              ON Orders.OrderNumber = Order_Details.OrderNumber)                                 INNER JOIN Products 
                              ON Products.ProductNumber = Order_Details.ProductNumber
              WHERE      Products.ProductName LIKE '%Helmet') CustHelmets 
        ON CustBikes.CustomerID = CustHelmets.CustomerID;
GO

CREATE VIEW CH08_Customers_Employees_Same_City
AS
SELECT Customers.CustFirstName, Customers.CustLastName, Employees.EmpFirstName, Employees.EmpLastName, Employees.EmpCity
FROM Customers INNER JOIN Employees ON (Customers.CustCity = Employees.EmpCity) ;
GO

CREATE VIEW CH08_Customers_Employees_Same_LastName
AS
SELECT (Customers.CustFirstName + ' ' + Customers.CustLastName) AS CustFullName, (Employees.EmpFirstName + ' ' + Employees.EmpLastName) AS EmpFullName
FROM Customers INNER JOIN Employees ON (Customers.CustLastName = Employees.EmpLastName) ;
GO

CREATE VIEW CH08_Customers_Who_Ordered_Helmets
AS
SELECT DISTINCT Customers.CustFirstName, Customers.CustLastName
FROM ((Customers INNER JOIN Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN Order_Details ON (Orders.OrderNumber = Order_Details.OrderNumber)) INNER JOIN Products ON (Products.ProductNumber = Order_Details.ProductNumber)
WHERE Products.ProductName LIKE '%Helmet%' ;
GO

CREATE VIEW CH08_Employees_And_Customers
AS
SELECT DISTINCT (Employees.EmpFirstName + ' ' + Employees.EmpLastName) AS EmpFullName, (Customers.CustFirstName + ' ' + Customers.CustLastName) AS CustFullName
FROM (Employees INNER JOIN Orders ON (Employees.EmployeeID = Orders.EmployeeID)) INNER JOIN Customers ON (Customers.CustomerID = Orders.CustomerID) ;
GO

CREATE VIEW CH08_Orders_With_Products
AS
SELECT     TOP 100 PERCENT Orders.OrderNumber AS OrderNo, Orders.OrderDate, Order_Details.ProductNumber AS ProductNo, 
                      Products.ProductName AS Product, Order_Details.QuotedPrice AS Price, Order_Details.QuantityOrdered AS Qty, 
                      Order_Details.QuotedPrice * Order_Details.QuantityOrdered AS AmountOwed
FROM         Orders INNER JOIN
                      Order_Details ON Orders.OrderNumber = Order_Details.OrderNumber INNER JOIN
                      Products ON Products.ProductNumber = Order_Details.ProductNumber
ORDER BY OrderNo;
GO

CREATE VIEW CH08_Products_And_Categories
AS
SELECT Categories.CategoryDescription, Products.ProductName
FROM Categories INNER JOIN Products ON (Categories.CategoryID = Products.CategoryID) ;
GO

CREATE VIEW CH08_Vendors_And_Products_Less_Than_100
AS
SELECT Vendors.VendName, Products.ProductName, Product_Vendors.WholesalePrice
FROM (Vendors INNER JOIN Product_Vendors ON (Vendors.VendorID = Product_Vendors.VendorID)) INNER JOIN Products ON (Products.ProductNumber = Product_Vendors.ProductNumber)
WHERE Product_Vendors.WholesalePrice < 100 ;
GO

CREATE VIEW CH09_All_Customers_And_Any_Bike_Orders
AS
SELECT     Customers.CustFirstName + ' ' + Customers.CustLastName AS CustFullName, RD.OrderDate, RD.ProductName, RD.QuantityOrdered, 
                      RD.QuotedPrice
FROM         Customers LEFT OUTER JOIN
             (SELECT     Orders.CustomerID, Orders.OrderDate, Products.ProductName, Order_Details.QuantityOrdered, Order_Details.QuotedPrice
              FROM          ((Orders 
              INNER JOIN      Order_Details 
              ON Orders.OrderNumber = Order_Details.OrderNumber)
              INNER JOIN      Products 
              ON Order_Details.ProductNumber = Products.ProductNumber) 
              INNER JOIN      Categories 
              ON Categories.CategoryID = Products.CategoryID
              WHERE      Categories.CategoryDescription = 'Bikes') RD 
             ON Customers.CustomerID = RD.CustomerID;
GO

CREATE VIEW CH09_All_Products_Any_Order_Dates
AS
SELECT     Products.ProductNumber, Products.ProductName, OD.OrderDate
FROM         Products LEFT OUTER JOIN
             (SELECT DISTINCT Order_Details.ProductNumber, Orders.OrderDate
              FROM          Orders 
              INNER JOIN    Order_Details 
              ON Orders.OrderNumber = Order_Details.OrderNumber) OD 
             ON Products.ProductNumber = OD.ProductNumber;
GO

CREATE VIEW CH09_Customers_No_Helmets
AS
SELECT     Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM         Customers LEFT OUTER JOIN
               (SELECT     Orders.CustomerID, Products.ProductName
                FROM          Products 
                INNER JOIN    (Orders 
                INNER JOIN    Order_Details 
                ON Orders.OrderNumber = Order_Details.OrderNumber) 
                ON Products.ProductNumber = Order_Details.ProductNumber
                WHERE      Products.ProductName LIKE '%helmet%') HelmetOrders 
            ON Customers.CustomerID = HelmetOrders.CustomerID
WHERE     (HelmetOrders.CustomerID IS NULL);
GO

CREATE VIEW CH09_Customers_No_Rep_Same_Zip
AS
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName, Customers.CustZipCode
FROM Customers LEFT JOIN Employees ON (Customers.CustZipCode = Employees.EmpZipCode)
WHERE Employees.EmployeeID Is Null ;
GO

CREATE VIEW CH09_Products_Never_Ordered
AS
SELECT Products.ProductNumber, Products.ProductName
FROM Products LEFT JOIN Order_Details ON (Products.ProductNumber = Order_Details.ProductNumber)
WHERE Order_Details.OrderNumber Is Null ;
GO

CREATE VIEW CH10_Customer_Helmets_Vendor_Helmets
AS
SELECT     Customers.CustLastName + ', ' + Customers.CustFirstName AS FullName, Products.ProductName, 'Customer' AS RowID
FROM         ((Customers INNER JOIN
                      Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN
                      Order_Details ON (Orders.OrderNumber = Order_Details.OrderNumber)) INNER JOIN
                      Products ON (Products.ProductNumber = Order_Details.ProductNumber)
WHERE     Products.ProductName LIKE '%helmet%'
UNION
SELECT     Vendors.VendName, Products.ProductName, 'Vendor' AS RowID
FROM         (Vendors INNER JOIN
                      Product_Vendors ON (Vendors.VendorID = Product_Vendors.VendorID)) INNER JOIN
                      Products ON (Products.ProductNumber = Product_Vendors.ProductNumber)
WHERE     Products.ProductName LIKE '%helmet%';
GO

CREATE VIEW CH10_Customer_Order_Bikes_UNION_Customer_Order_Helmets
AS
SELECT     Customers.CustFirstName, Customers.CustLastName, 'Bike' AS ProdType
FROM         ((Customers INNER JOIN
                      Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN
                      Order_Details ON (Orders.OrderNumber = Order_Details.OrderNumber)) INNER JOIN
                      Products ON (Products.ProductNumber = Order_Details.ProductNumber)
WHERE     Products.ProductName LIKE '%bike%'
UNION
SELECT     Customers.CustFirstName, Customers.CustLastName, 'Helmet' AS ProdType
FROM         ((Customers INNER JOIN
                      Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN
                      Order_Details ON (Orders.OrderNumber = Order_Details.OrderNumber)) INNER JOIN
                      Products ON (Products.ProductNumber = Order_Details.ProductNumber)
WHERE     Products.ProductName LIKE '%helmet%';
GO

CREATE VIEW CH10_Customers_Bikes_Or_Helmets
AS
SELECT DISTINCT Customers.CustFirstName, Customers.CustLastName
FROM ((Customers INNER JOIN Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN Order_Details ON (Orders.OrderNumber = Order_Details.OrderNumber)) INNER JOIN Products ON (Products.ProductNumber = Order_Details.ProductNumber)
WHERE Products.ProductName LIKE '%bike%' OR Products.ProductName LIKE '%helmet%' ;
GO

CREATE VIEW CH10_Customers_UNION_ALL_Employees
AS
SELECT     TOP 100 PERCENT *
FROM         (SELECT     Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, Customers.CustCity, Customers.CustState, 
                                              Customers.CustZipCode
                       FROM          Customers
                       UNION ALL
                       SELECT     Employees.EmpFirstName, Employees.EmpLastName, Employees.EmpStreetAddress, Employees.EmpCity, Employees.EmpState, 
                                             Employees.EmpZipCode
                       FROM         Employees) DERIVEDTBL
ORDER BY CustZipCode;
GO

CREATE VIEW CH11_Customers_Clothing_OR_Accessories
AS
SELECT     CustomerID, CustFirstName, CustLastName
FROM         Customers
WHERE     (CustomerID = ANY
                          (SELECT     Orders.CustomerID
                            FROM          ((Orders INNER JOIN
                                                   Order_Details ON Orders.OrderNumber = Order_Details.OrderNumber) INNER JOIN
                                                   Products ON Products.ProductNumber = Order_Details.ProductNumber) INNER JOIN
                                                   Categories ON Categories.CategoryID = Products.CategoryID
                            WHERE      Categories.CategoryDescription = 'Clothing' OR
                                                   Categories.CategoryDescription = 'Accessories'));
GO

CREATE VIEW CH11_Customers_Clothing_OR_Accessories_EXISTS
AS
SELECT     CustomerID, CustFirstName, CustLastName
FROM         dbo.Customers
WHERE     EXISTS
                          (SELECT     *
                            FROM          ((Orders INNER JOIN
                                                   Order_Details ON Orders.OrderNumber = Order_Details.OrderNumber) INNER JOIN
                                                   Products ON Products.ProductNumber = Order_Details.ProductNumber) INNER JOIN
                                                   Categories ON Categories.CategoryID = Products.CategoryID
                            WHERE      (Categories.CategoryDescription = 'Clothing' OR
                                                   Categories.CategoryDescription = 'Accessories') AND Customers.CustomerID = Orders.CustomerID);
GO

CREATE VIEW CH11_Customers_Clothing_OR_Accessories_IN
AS
SELECT     CustomerID, CustFirstName, CustLastName
FROM         dbo.Customers
WHERE     (CustomerID IN
                          (SELECT     Orders.CustomerID
                            FROM          ((Orders INNER JOIN
                                                   Order_Details ON Orders.OrderNumber = Order_Details.OrderNumber) INNER JOIN
                                                   Products ON Products.ProductNumber = Order_Details.ProductNumber) INNER JOIN
                                                   Categories ON Categories.CategoryID = Products.CategoryID
                            WHERE      Categories.CategoryDescription = 'Clothing' OR
                                                   Categories.CategoryDescription = 'Accessories'));
GO

CREATE VIEW CH11_Customers_Ordered_Bikes_EXISTS
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM Customers
WHERE EXISTS
    (SELECT *
    FROM (Orders
    INNER JOIN Order_Details
    ON Orders.OrderNumber = Order_Details.OrderNumber) 
    INNER JOIN Products
    ON Products.ProductNumber = Order_Details.ProductNumber
    WHERE Products.CategoryID = 2
    AND Orders.CustomerID = Customers.CustomerID);
GO

CREATE VIEW CH11_Customers_Ordered_Bikes_IN
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM Customers
WHERE Customers.CustomerID IN 
(SELECT Orders.CustomerID FROM ((Orders 
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber) 
INNER JOIN Products
ON Products.ProductNumber = Order_Details.ProductNumber) 
INNER JOIN Categories
ON Categories.CategoryID = Products.CategoryID 
WHERE Categories.CategoryDescription = 'Bikes');
GO

CREATE VIEW CH11_Customers_Ordered_Bikes_JOIN
AS 
SELECT DISTINCT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM ((Customers
INNER JOIN Orders
ON Customers.CustomerID=Orders.CustomerID)
INNER JOIN Order_Details
ON Orders.OrderNumber=Order_Details.OrderNumber)
INNER JOIN Products
ON Products.ProductNumber=Order_Details.ProductNumber
WHERE Products.CategoryID=2;
GO

CREATE VIEW CH11_Products_Last_Date
AS
SELECT Products.ProductNumber, Products.ProductName, (SELECT max(Orders.OrderDate) FROM Orders INNER JOIN Order_Details ON Orders.OrderNumber = Order_Details.OrderNumber WHERE Order_Details.ProductNumber = Products.ProductNumber) AS LastOrder
FROM Products ;
GO

CREATE VIEW CH11_Products_Not_Ordered
AS
SELECT Products.ProductName
FROM Products
WHERE Products.ProductNumber NOT IN (SELECT Order_Details.ProductNumber FROM Order_Details) ;
GO

CREATE VIEW CH11_Vendors_Product_Count
AS
SELECT VendName, (SELECT count(*) FROM Product_Vendors WHERE Product_Vendors.VendorID = Vendors.VendorID) AS VendProductCount
FROM Vendors ;
GO

CREATE VIEW CH12_Average_Price_Of_A_Mountain_Bike
AS
SELECT avg(RetailPrice) AS AverageCost
FROM Products
WHERE ProductName LIKE '%Mountain Bike%' ;
GO

CREATE VIEW Ch12_Most_Recent_Order_Date
AS
SELECT max(OrderDate) AS MostRecentOrderDate
FROM Orders ;
GO

CREATE VIEW CH12_Number_Of_California_Customers
AS
SELECT count(*) AS NumberOfCACustomers
FROM Customers
WHERE CustState = 'CA' ;
GO

CREATE VIEW CH12_Quoted_Price_vs_Average_Retail_Price
AS
SELECT DISTINCT ProductName, Products.ProductNumber
FROM Products INNER JOIN Order_Details ON (Products.ProductNumber =  Order_Details.ProductNumber)
WHERE Order_Details.QuotedPrice >=     (SELECT avg(RetailPrice)     FROM Products) ;
GO

CREATE VIEW CH12_Total_Amount_For_Order_Number_8
AS
SELECT sum(QuantityOrdered * QuotedPrice) AS TotalOrderAmount
FROM Order_Details
WHERE OrderNumber = 8 ;
GO

CREATE VIEW CH13_Order_Totals_By_Customer_And_Date
AS
SELECT Customers.CustFirstName +  ' ' +     Customers.CustLastName AS CustFullName, Orders.OrderDate, sum(Order_Details.QuotedPrice *     Order_Details.QuantityOrdered) AS TotalCost
FROM (Customers INNER JOIN Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN Order_Details ON (Orders.OrderNumber =     Order_Details.OrderNumber)
GROUP BY Customers.CustFirstName, Customers.CustLastName, Orders.OrderDate ;
GO

CREATE VIEW CH13_Sales_By_Product
AS
SELECT Products.ProductName, sum(Order_Details.QuotedPrice * Order_Details.QuantityOrdered) AS TotalSales
FROM Products INNER JOIN Order_Details ON (Products.ProductNumber = Order_Details.ProductNumber)
GROUP BY Products.ProductName ;
GO

CREATE VIEW CH13_Vendor_Avg_Delivery
AS
SELECT Vendors.VendName, avg(Product_Vendors.DaysToDeliver) AS AvgDelivery
FROM Vendors INNER JOIN Product_Vendors ON (Vendors.VendorID = Product_Vendors.VendorID)
GROUP BY Vendors.VendName ;
GO

CREATE VIEW CH13_Vendors_Product_Count_Group
AS
SELECT Vendors.VendName, count(Product_Vendors.ProductNumber) AS CountOfProductNumber
FROM Vendors INNER JOIN Product_Vendors ON (Vendors.VendorID = Product_Vendors.VendorID)
GROUP BY Vendors.VendName ;
GO

CREATE VIEW CH13_Vendors_Product_Count_Subquery
AS
SELECT VendName, (SELECT count(*) FROM Product_Vendors WHERE Product_Vendors.VendorID = Vendors.VendorID) AS VendProductCount
FROM Vendors ;
GO

CREATE VIEW CH14_Order_Totals_By_Customer_And_Date_GT1000
AS
SELECT Customers.CustFirstName +  ' ' +     Customers.CustLastName AS CustFullName, Orders.OrderDate, sum(Order_Details.QuotedPrice *     Order_Details.QuantityOrdered) AS TotalCost
FROM (Customers INNER JOIN Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN Order_Details ON (Orders.OrderNumber =     Order_Details.OrderNumber)
GROUP BY Customers.CustFirstName, Customers.CustLastName, Orders.OrderDate
HAVING sum(Order_Details.QuotedPrice * Order_Details.QuantityOrdered) > 1000 ;
GO

CREATE VIEW CH14_Sales_By_Product_GT_Category_Avg
AS
SELECT     Products.ProductName, SUM(Order_Details.QuotedPrice * Order_Details.QuantityOrdered) AS TotalSales
FROM         Products 
INNER JOIN   Order_Details 
  ON Products.ProductNumber = Order_Details.ProductNumber
GROUP BY Products.CategoryID, Products.ProductName
HAVING      (SUM(Order_Details.QuotedPrice * Order_Details.QuantityOrdered) >
                (SELECT     AVG(SumCategory)
                 FROM       
                    (SELECT     P2.CategoryID, SUM(OD2.QuotedPrice * OD2.QuantityOrdered) AS SumCategory
                     FROM          Products AS P2 
                     INNER JOIN    Order_Details AS OD2 
                       ON P2.ProductNumber = OD2.ProductNumber
                     GROUP BY P2.CategoryID, P2.ProductNumber) AS S
                 WHERE      S.CategoryID = Products.CategoryID
                 GROUP BY CategoryID));
GO

CREATE VIEW CH14_Single_Item_Order_Count
AS
SELECT     COUNT(*) AS SingleItemOrderCount
FROM         (SELECT     Order_Details.OrderNumber
                       FROM          Order_Details
                       GROUP BY Order_Details.OrderNumber
                       HAVING      COUNT(*) = 1) SingleOrders;
GO

CREATE VIEW CH14_Vendor_Avg_Delivery_GT_Overall_Avg
AS
SELECT Vendors.VendName, avg(Product_Vendors.DaysToDeliver) AS AvgDelivery
FROM Vendors INNER JOIN Product_Vendors ON (Vendors.VendorID = Product_Vendors.VendorID)
GROUP BY Vendors.VendName
HAVING avg(Product_Vendors.DaysToDeliver) > (SELECT avg(DaysToDeliver) FROM Product_Vendors) ;
GO

CREATE VIEW CH14_West_Coast_Big_Order_States
AS
SELECT Customers.CustState, sum(Order_Details.QuantityOrdered *     Order_Details.QuotedPrice) AS SumOfOrders
FROM (Customers INNER JOIN Orders ON (Customers.CustomerID = Orders.CustomerID)) INNER JOIN Order_Details ON (Orders.OrderNumber =     Order_Details.OrderNumber)
WHERE Customers.CustState IN ('WA', 'OR', 'CA')
GROUP BY Customers.CustState
HAVING sum(Order_Details.QuantityOrdered *     Order_Details.QuotedPrice) > 1000000 ;
GO

CREATE VIEW CH18_Cust_Bikes_And_Helmets_EXISTS
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM Customers
WHERE EXISTS 
(SELECT *
FROM (Orders
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Products.ProductNumber = Order_Details.ProductNumber
WHERE Products.CategoryID = 2
AND Orders.CustomerID = Customers.CustomerID)
AND EXISTS
(SELECT *
FROM (Orders
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Products.ProductNumber = Order_Details.ProductNumber
WHERE Products.ProductName LIKE '%Helmet'
AND Orders.CustomerID = Customers.CustomerID);
GO

CREATE VIEW CH18_Cust_Bikes_No_Helmets_EXISTS
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM Customers
WHERE EXISTS 
(SELECT *
FROM (Orders
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Products.ProductNumber = Order_Details.ProductNumber
WHERE Products.CategoryID = 2
AND Orders.CustomerID = Customers.CustomerID)
AND NOT EXISTS
(SELECT *
FROM (Orders
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Products.ProductNumber = Order_Details.ProductNumber
WHERE Products.ProductName LIKE '%Helmet'
AND Orders.CustomerID = Customers.CustomerID);
GO

CREATE VIEW CH18_Customer_Bikes_No_Helmets
AS 
SELECT CustomerID, CustFirstName, CustLastName
FROM Customers
WHERE (CustomerID IN
                          (SELECT     Orders.CustomerID
                            FROM          (Orders
INNER JOIN
                                                   Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN
                                                   Products
ON Products.ProductNumber = Order_Details.ProductNumber
                            WHERE      Products.CategoryID = 2)) 
          
AND (CustomerID NOT IN
                          (SELECT     Orders.CustomerID
                            FROM          (Orders
INNER JOIN
                                                   Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN
                                                   Products
ON Products.ProductNumber = Order_Details.ProductNumber
                            WHERE      Products.ProductName LIKE '%Helmet'));
GO

CREATE VIEW CH18_Customers_Bikes_And_Helmets_Same_Order
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName, Orders.OrderNumber, Orders.OrderDate
FROM Customers
INNER JOIN Orders
ON Customers.CustomerID=Orders.CustomerID
WHERE EXISTS  (SELECT * FROM (Orders As O2
INNER JOIN Order_Details
ON O2.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Products.ProductNumber = Order_Details.ProductNumber WHERE Products.CategoryID = 2
AND Orders.CustomerID = Customers.CustomerID
AND O2.OrderNumber = Orders.OrderNumber)
AND EXISTS (SELECT * FROM (Orders As O3 
INNER JOIN Order_Details
ON O3.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Products.ProductNumber = Order_Details.ProductNumber WHERE Products.ProductName LIKE '%Helmet'
AND Orders.CustomerID = Customers.CustomerID
AND O3.OrderNumber = Orders.OrderNumber);
GO

CREATE VIEW CH18_Customers_No_Orders_JOIN
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, Customers.CustCity, Customers.CustState
FROM Customers LEFT JOIN Orders
ON Customers.CustomerID=Orders.CustomerID
WHERE Orders.OrderNumber Is Null;
GO

CREATE VIEW CH18_Customers_No_Orders_NOT_IN
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, Customers.CustCity, Customers.CustState
FROM Customers
WHERE Customers.CustomerID NOT IN
(SELECT Orders.CustomerID FROM Orders);
GO

CREATE VIEW CH18_Customers_Not_Bikes_Or_Tires_NOTIN_1
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM Customers
WHERE Customers.CustomerID NOT IN
(SELECT CustomerID FROM
(Orders
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Order_Details.ProductNumber = Products.ProductNumber
WHERE Products.CategoryID IN (2, 6));
GO

CREATE VIEW CH18_Customers_Not_Bikes_Or_Tires_NOTIN_2
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName
FROM Customers
WHERE Customers.CustomerID NOT IN
(SELECT CustomerID FROM
(Orders
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Order_Details.ProductNumber = Products.ProductNumber
WHERE Products.CategoryID = 2)
AND Customers.CustomerID NOT IN 
(SELECT CustomerID FROM
(Orders
INNER JOIN Order_Details
ON Orders.OrderNumber = Order_Details.OrderNumber)
INNER JOIN Products
ON Order_Details.ProductNumber = Products.ProductNumber
WHERE Products.CategoryID = 6);
GO

CREATE VIEW CH18_Orders_Bikes_No_Helmet_EXISTS
AS 
SELECT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName, Orders.OrderNumber, Orders.OrderDate
FROM Customers
INNER JOIN Orders
ON Customers.CustomerID=Orders.CustomerID
WHERE EXISTS  (SELECT OrderNumber  FROM (Order_Details
INNER JOIN Products
ON Order_Details.ProductNumber = Products.ProductNumber)
INNER JOIN Categories
ON Products.CategoryID = Categories.CategoryID WHERE Categories.CategoryDescription = 'Bikes'
AND Order_Details.OrderNumber = Orders.OrderNumber)
AND NOT EXISTS  (SELECT *  FROM Order_Details
INNER JOIN Products
ON Order_Details.ProductNumber = Products.ProductNumber WHERE Products.ProductName LIKE '%Helmet'
AND Order_Details.OrderNumber = Orders.OrderNumber);
GO

CREATE VIEW CH18_Vendors_Accessories_CarRacks_Clothing
AS 
SELECT Vendors.VendorID, Vendors.VendName
FROM Vendors
WHERE Vendors.VendorID IN
(SELECT VendorID 
  FROM (Product_Vendors
INNER JOIN Products
ON Product_Vendors.ProductNumber = Products.ProductNumber)
INNER JOIN Categories
ON Products.CategoryID = Categories.CategoryID
  WHERE Categories.CategoryDescription = 'Accessories')
AND Vendors.VendorID IN
(SELECT VendorID 
  FROM (Product_Vendors
INNER JOIN Products
ON Product_Vendors.ProductNumber = Products.ProductNumber)
INNER JOIN Categories
ON Products.CategoryID = Categories.CategoryID
  WHERE Categories.CategoryDescription = 'Car racks')
AND Vendors.VendorID IN
(SELECT VendorID 
  FROM (Product_Vendors
INNER JOIN Products
ON Product_Vendors.ProductNumber = Products.ProductNumber)
INNER JOIN Categories
ON Products.CategoryID = Categories.CategoryID
  WHERE Categories.CategoryDescription = 'Clothing');
GO

CREATE VIEW CH19_Customers_Ordered_FirstWeek_Dec2012
AS
SELECT        CustomerID, CustFirstName, CustLastName, (CASE WHEN CustomerID IN
                            (SELECT        CustomerID
                              FROM            Orders
                              WHERE        OrderDate BETWEEN CAST('2012-12-01' AS Date) AND CAST('2012-12-07' AS Date)) 
                            THEN 'Ordered' 
                            ELSE 'Not Ordered' END) AS OrderedFirstWeekDec2012
FROM            Customers;
GO

CREATE VIEW CH19_Customers_State_Names
AS
SELECT        CustFirstName, CustLastName, 
                         (CASE CustState WHEN 'TX' THEN 'Texas' WHEN 'CA' THEN 'California' WHEN 'OR' THEN 'Oregon' WHEN 'WA' THEN 'Washington' ELSE 'Unknown' END) 
                         AS CustStateName
FROM           Customers;
GO

CREATE VIEW CH19_Employee_Age_Feb152014
AS
SELECT        EmployeeID, EmpFirstName, EmpLastName, DATEDIFF(yy, EmpBirthDate, CAST('2014-02-15' AS Date)) - (CASE WHEN Month(EmpBirthDate) 
                         < 2 THEN 0 WHEN Month(EmpBirthDate) > 2 THEN 1 WHEN Day(EmpBirthDate) > 15 THEN 1 ELSE 0 END) AS EmpAge
FROM            Employees;
GO

CREATE VIEW CH19_Products_And_SalesQuality
AS
SELECT ProductNumber, ProductName, 
       (CASE 
        WHEN (SELECT SUM(QuantityOrdered)
              FROM   Order_Details
              WHERE  (Order_Details.ProductNumber = Products.ProductNumber)) <= 200
        THEN 'Poor' 
        WHEN (SELECT SUM(QuantityOrdered)
              FROM   Order_Details
              WHERE  (Order_Details.ProductNumber = Products.ProductNumber)) <= 500 
        THEN 'Average' 
        WHEN (SELECT SUM(QuantityOrdered)
              FROM   Order_Details
              WHERE  (Order_Details.ProductNumber = Products.ProductNumber)) <= 1000 
        THEN 'Good' 
        ELSE 'Excellent' END) AS SalesQuality
FROM            Products;
GO

CREATE VIEW CH19_Products_Ordered_Dec_2012
AS
SELECT        ProductNumber, ProductName, (CASE WHEN Products.ProductNumber IN
                             (SELECT        Order_Details.ProductNumber
                               FROM            Order_Details INNER JOIN
                                                         Orders ON Orders.OrderNumber = Order_Details.OrderNumber
                               WHERE        (Orders.OrderDate BETWEEN CAST('2012-12-01' AS Date) AND CAST('2012-12-31' AS Date))) THEN 'Ordered' ELSE 'Not Ordered' END) 
                         AS ProductOrdered
FROM            Products;
GO

CREATE VIEW CH20_Customer_All_Products_PurchasedStatus
AS 
SELECT TOP 100 PERCENT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, 
  Customers.CustCity, Customers.CustState, Customers.CustZipCode, Categories.CategoryDescription, 
  Products.ProductNumber, Products.ProductName, Products.RetailPrice, 
  (CASE WHEN Customers.CustomerID IN 
      (SELECT Orders.CustomerID 
       FROM ORDERS INNER JOIN Order_Details ON Orders.OrderNumber = Order_Details.OrderNumber 
       WHERE Order_Details.ProductNumber = Products.ProductNumber) 
   THEN 'You purchased this!' ELSE ' ' END) AS ProductOrdered
FROM Customers, Categories
INNER JOIN Products
ON Categories.CategoryID=Products.CategoryID
ORDER BY Customers.CustomerID, Categories.CategoryDescription, Products.ProductNumber;
GO

CREATE VIEW CH20_Customer_Catalog
AS 
SELECT TOP 100 PERCENT Customers.CustomerID, Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, 
  Customers.CustCity, Customers.CustState, Customers.CustZipCode, Categories.CategoryDescription, 
  Products.ProductNumber, Products.ProductName, Products.RetailPrice
FROM Customers, Categories
INNER JOIN Products
ON Categories.CategoryID=Products.CategoryID
ORDER BY Customers.CustomerID, Categories.CategoryDescription, Products.ProductNumber;
GO

CREATE VIEW CH20_Customer_Dec_2012_Order_Coupons
AS 
SELECT ztblPurchaseCoupons.NumCoupons, CustDecOrderTotal.CustomerID, Customers.CustFirstName, Customers.CustLastName, 
  Customers.CustStreetAddress, Customers.CustCity, Customers.CustState, Customers.CustZipCode, CustDecOrderTotal.Purchase
FROM ztblPurchaseCoupons, Customers
INNER JOIN (SELECT Orders.CustomerID, Sum((QuotedPrice)*(QuantityOrdered)) AS Purchase FROM Orders
INNER JOIN Order_Details
ON Orders.OrderNumber=Order_Details.OrderNumber WHERE Orders.OrderDate Between '2012-12-01'
AND '2012-12-31' GROUP BY Orders.CustomerID)  AS CustDecOrderTotal
ON Customers.CustomerID=CustDecOrderTotal.CustomerID
WHERE CustDecOrderTotal.Purchase BETWEEN ztblPurchaseCoupons.LowSpend
AND ztblPurchaseCoupons.HighSpend;
GO

CREATE VIEW CH20_Customer_Discount_Coupons_Print
AS 
SELECT TOP 100 PERCENT CH20_Customer_Dec_2012_Order_Coupons.CustomerID, CH20_Customer_Dec_2012_Order_Coupons.CustFirstName, 
  CH20_Customer_Dec_2012_Order_Coupons.CustLastName, CH20_Customer_Dec_2012_Order_Coupons.CustStreetAddress, 
  CH20_Customer_Dec_2012_Order_Coupons.CustCity, CH20_Customer_Dec_2012_Order_Coupons.CustState, 
  CH20_Customer_Dec_2012_Order_Coupons.CustZipCode
FROM ztblSeqNumbers, CH20_Customer_Dec_2012_Order_Coupons
WHERE CH20_Customer_Dec_2012_Order_Coupons.NumCoupons >= ztblSeqNumbers.Sequence
ORDER BY CH20_Customer_Dec_2012_Order_Coupons.CustomerID;
GO

CREATE VIEW CH20_Customer_Mailing_Skip_5
AS 
SELECT TOP 100 PERCENT * 
FROM 
(SELECT ' ' As CustFirstName, ' ' As CustLastName, ' ' As CustStreenAddress, ' ' As CustCity, ' ' As CustState, ' ' As CustZipCode 
FROM ztblSeqNumbers
WHERE ztblSeqNumbers.Sequence <= 5
UNION ALL SELECT Customers.CustFirstName, Customers.CustLastName, Customers.CustStreetAddress, Customers.CustCity, Customers.CustState, Customers.CustZipCode
FROM Customers) As CustLabels
ORDER BY CustZipCode, CustLastName;
GO

CREATE VIEW CH20_Employees_Same_State_Customers
AS 
SELECT Employees.EmpFirstName, Employees.EmpLastName, Customers.CustFirstName, Customers.CustLastName, 
  Customers.CustAreaCode, Customers.CustPhoneNumber, 
  (CASE WHEN Customers.CustomerID IN (SELECT CustomerID FROM Orders WHERE Orders.EmployeeID = Employees.EmployeeID) 
        THEN 'Ordered from you.' ELSE ' ' END) AS CustStatus
FROM Employees, Customers
WHERE Employees.EmpState=Customers.CustState;
GO

CREATE VIEW CH20_Product_Price_Ranges
AS 
SELECT ztblPriceRanges.PriceCategory, Products.ProductName, Products.RetailPrice
FROM ztblPriceRanges, Products
WHERE Products.RetailPrice Between ztblPriceRanges.LowPrice
AND ztblPriceRanges.HighPrice;
GO

CREATE VIEW CH20_Product_Sales_All_Months_2012_2013
AS 
SELECT ztblMonths.MonthYear, P2.ProductName, 
  (SELECT Sum(Order_Details.QuantityOrdered*Order_Details.QuotedPrice) AS SValue 
FROM  (Products
INNER JOIN Order_Details
ON Products.ProductNumber=Order_Details.ProductNumber)
INNER JOIN Orders
ON Orders.OrderNumber=Order_Details.OrderNumber
WHERE Orders.OrderDate BETWEEN ztblMonths.MonthStart
AND ztblMonths.MonthEnd 
AND Products.ProductNumber = P2.ProductNumber) AS Sales
FROM ztblMonths, Products AS P2 
WHERE ztblMonths.YearNumber BETWEEN 2012 AND 2013;
GO

CREATE VIEW CH20_Product_Sales_ByMonth
AS 
SELECT ztblMonths.MonthYear, Products.ProductName, Sum(Order_Details.QuantityOrdered*Order_Details.QuotedPrice) AS Sales
FROM ztblMonths, (Products
INNER JOIN Order_Details
ON Products.ProductNumber=Order_Details.ProductNumber)
INNER JOIN Orders
ON Orders.OrderNumber=Order_Details.OrderNumber
WHERE Orders.OrderDate BETWEEN ztblMonths.MonthStart
AND ztblMonths.MonthEnd
GROUP BY ztblMonths.MonthYear, Products.ProductName;
GO

CREATE VIEW CH20_Product_Sales_Month_Pivot
AS 
SELECT Products.ProductName, SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.January) AS January, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.February) AS February, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.March) AS March, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.April) AS April, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.May) AS May, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.June) AS June, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.July) AS July, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.August) AS August, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.September) AS September, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.October) AS October, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.November) AS November, 
  SUM(Order_Details.QuotedPrice*Order_Details.QuantityOrdered*ztblMonths.December) AS December
FROM ztblMonths, (Products
INNER JOIN Order_Details
ON Products.ProductNumber=Order_Details.ProductNumber)
INNER JOIN Orders
ON Orders.OrderNumber=Order_Details.OrderNumber
WHERE Orders.OrderDate BETWEEN ztblMonths.MonthStart
AND ztblMonths.MonthEnd
GROUP BY Products.ProductName;
GO

CREATE VIEW CH20_Product_Stock_Labels
AS 
SELECT TOP 100 PERCENT ztblSeqNumbers.Sequence, Products.ProductNumber, Products.ProductName
FROM ztblSeqNumbers, Products
WHERE ztblSeqNumbers.Sequence<=Products.QuantityOnHand
ORDER BY Products.ProductNumber, ztblSeqNumbers.Sequence;
GO
