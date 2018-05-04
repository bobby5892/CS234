/****** Select Statements for Lab 4  ******/
-- 1.  Select all of the customers who live in NY state
	SELECT * FROM Customers WHERE State='NY'
	
-- 2.  Select all of the states that start with A 
	SELECT * FROM Customers WHERE State LIKE'A%'
	
-- 3.  Select all of the Products that have a price between 50 and 60 dollars
	SELECT * FROM Products WHERE UnitPrice BETWEEN 50 AND 60
	
-- 4.  Show me the value of the inventory that we have on hand for each product
	SELECT description,UnitPrice*OnHandQuantity AS 'valueTotal' FROM Products
	
-- 5.  Get me a list of the invoices in April, May or June
	SELECT * FROM Invoices WHERE Month(InvoiceDate) BETWEEN 4 AND 6
	
-- 6.  Get me a list of the invoices in Jan or April
	SELECT * FROM Invoices WHERE Month(InvoiceDate)  IN(1,4)
	
-- 7.  Add the name of the state to the result set from #1
	SELECT * FROM Customers 
		INNER JOIN States
		ON States.StateCode = Customers.State
		WHERE State='NY' 
-- 8.  Add the customer's name to the result set from #5
	SELECT * FROM Invoices 
		INNER JOIN Customers 
		ON invoices.CustomerID = Customers.CustomerID
		WHERE Month(InvoiceDate) BETWEEN 4 AND 6
-- 9.  Get me a list of all of the products that have been ordered.  Include the quantity ordered on each invoice.
SELECT Invoices.InvoiceID,Products.Description,Products.UnitPrice,Products.OnHandQuantity FROM InvoiceLineItems
	INNER JOIN Invoices
	ON InvoiceLineItems.InvoiceID=Invoices.InvoiceID
	INNER JOIN Products
	ON InvoiceLineItems.ProductCode=Products.ProductCode
	
-- 10. Get me a list of all of the invoices.  Include all of the items ordered on the invoice, including the detailed information about each product.
--     You'll have more than one record for each invoice.

-- 11. Add the customer's name and address to the results from 10.

-- 12. Add the name of the state to the results from 11.

-- 13. How many products do we have?

-- 14. What's the total value of all of the products sold?

-- 15. What's the total value of all of the inventory we have on hand?

-- 16. How many orders has each customer placed?  EXTRA CREDIT:  List all customers, even if they don't have any orders.