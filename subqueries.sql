----Write an SQL statement to create a stored procedure with name prcGetAllCustomers to display all records from Customer table.
create or alter procedure prcGetAllCustomers
as 
Begin 
Select * from Customers
End

exec prcGetAllCustomers;

----Write an SQL statement to create a parameterized stored procedure with name prcGetCustomer which should take CustomerID as
----parameter and displays the respective record based on that CustomerID.
create procedure prcGetCustomer5(@CusID nvarchar(20))
as 
select * from Customers where CustomerID=@CusID

exec prcGetCustomer5 'ALFKI'



----Write an SQL statement to create a parameterized stored procedure with name prcAddCustomer which should take CustomerID, CustomerName, Email, Age, Phone as parameters and insert the record in Customer table.
create procedure prcAddCustomer3 @CusId nvarchar(20), @CusName nvarchar(20), @Phone nvarchar(20), @Email nvarchar(20), @Age nvarchar(20)
as 
insert into Customers(CustomerId,ContactName,Phone,Age,Email) values(@CusId,@CusName,@Phone,@Age,@Email)

exec prcAddCustomer3 '101','dhruv','789130','20','dhruv@gmail.com'


----Write an SQL statement to alter the procedure prcGetCustomer to change its functionality. Instead of taking parameter CustomerID it should take CustomerName and display the respective record based on that CustomerName.
create or alter procedure prcGetCustomer @CusName nvarchar(20)
as 
select * from Customers where CustomerName=@CusName

----Write an SQL statement to create a parameterized stored procedure with prcAddOrUpdateCustomer which should take CustomerID, CustomerName, Email, Age, Phone as parameters. If the record with same CustomerID already exists it should update the data otherwise it should insert a new record.
create or alter procedure prcAddorUpdateCustomer @CusId nvarchar(20),@CusName nvarchar(20), @Email nvarchar(20), @Age nvarchar(20), @Phone nvarchar(20)
as
--if already there update
declare @Already nvarchar(20)
set @Already=(select ContactName from Customers where CustomerID=@CusName)
if @Already is Null
	begin
		update Customers set ContactName=@CusName,Phone=@Phone,Email=@Email,@Age=Age  where CustomerID
	end
--else insert
else 
	begin
	insert into Customers(CustomerId,ContactName,Phone,Age,Email) values(@CusId,@CusName,@Phone,@Age,@Email)
	end

----Write an SQL statement to delete procedure prGetAllCustomers.
DROP PROCEDURE [prcGetAllCustomers];


SELECT * FROM INFORMATION_SCHEMA.COLUMNS