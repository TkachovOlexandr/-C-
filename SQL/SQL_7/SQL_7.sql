drop table if exists History;
drop table if exists Product;

create table History
(
	Id int not null identity(1, 1) primary key,
	UserId int not null,
	Operation nvarchar(20) not null check (Operation <> N''),
	DateWhen datetime not null DEFAULT (getdate())
);

create table Product
(
	Id int not null identity(1, 1) primary key,
	Product_Name nvarchar(20) not null check (Product_Name <> N''),
	Product_Category nvarchar(20) not null check (Product_Category <> N''),
	Product_Provider nvarchar(20) not null check (Product_Provider <> N''),
	Product_Price float not null
);