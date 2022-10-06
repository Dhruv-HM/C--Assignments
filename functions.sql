--Write an SQL statement to create a scalar function with name fnFactorial which should take an integer parameter and returns the factorial of the given number.
create or alter function fnFactorial (@num int) returns int
as begin 
	declare @fact int, @i int
	set @i=1
	set @fact=1
	while @i<=@num
		begin 
			set @fact=@fact*(@i)
			set @i=@i+1
		end
	return @fact
end

--select *,Shopify.fnFactorial(5) as something from Employees

--Write an SQL statement to create a function with name fnGetCustomersByAge which should take Age as parameter and returns the records from Customer table where age is greater than or equal to the Age parameter.
create or alter function gnGetCustomerByAge(@Age int) returns Table
as 
return 
	select * from Customers where Age>@Age

--Write an SQL statement to create a function with name fnGetOldestCustomer which should return the record of the oldest customer by age.
create or alter function fnOldestCustomer returns TABLE
as 
select * from Customers where Age=max(Age)
--Write an SQL statement to alter a function fnGetCustomersByAge which should take Age as parameter and returns only the CustomerName.
create or alter function fnGetCustomerByAge(@age int) 
as 
return 
	select CustomerName from Customers where Age>@age

--Write an SQL statement to delete a function fnFactorial.
Drop Function [fnFactorial]

