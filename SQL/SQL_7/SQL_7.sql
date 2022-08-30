drop table if exists Product;

create table Product
(
	Id int not null identity(1, 1) primary key,
	Product_Name nvarchar(20) not null check (Product_Name <> N''),
	Product_Category nvarchar(20) not null check (Product_Category <> N''),
	Product_Price float not null
);

insert into Product(Product_Name, Product_Category, Product_Price) values ('ds', 'aerf', 12.43);

select * from Product;