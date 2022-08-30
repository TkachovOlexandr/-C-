drop table if exists Product;

create table Product
(
	Id int not null identity(1, 1) primary key,
	Product_Name nvarchar(20) not null check (Product_Name <> N''),
	Product_Category nvarchar(20) not null check (Product_Category <> N''),
	Product_Price FLOAT not null
);

select * from Product;