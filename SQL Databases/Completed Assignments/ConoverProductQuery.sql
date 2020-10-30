select ven.BusinessEntityID as 'Account Number' , proV.ProductID, pro.Name
from Purchasing.Vendor as ven
join Purchasing.ProductVendor as proV
on ven.BusinessEntityID = proV.BusinessEntityID
join Production.Product as pro
on proV.ProductID = pro.ProductID
union
select soh.CustomerID, sod.ProductID, pro.Name
from Production.Product as pro
join Sales.SalesOrderDetail as sod
on pro.ProductID = sod.ProductID
join Sales.SalesOrderHeader as soh
on soh.SalesOrderID = sod.SalesOrderID