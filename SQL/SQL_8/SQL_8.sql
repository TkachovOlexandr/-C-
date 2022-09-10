drop table if exists History;
drop table if exists Products;

create table History
(
	Id int not null identity(1, 1) primary key,
	UserId int not null,
	Operation nvarchar(20) not null check (Operation <> N''),
	DateWhen datetime not null DEFAULT (getdate())
);

create table Products
(
	Id int not null identity(1, 1) primary key,
	Product_Name nvarchar(20) not null check (Product_Name <> N''),
	Product_Category nvarchar(20) not null check (Product_Category <> N''),
	Product_Provider nvarchar(20) not null check (Product_Provider <> N''),
	Product_Price float not null
);


drop trigger if exists User_Insert;
drop trigger if exists User_Delete;
drop trigger if exists User_Update;
GO
CREATE TRIGGER User_Insert
    ON [Products]
    AFTER INSERT
AS
BEGIN
    INSERT INTO History(UserId, Operation)
    SELECT Id, 'ADDED ' FROM INSERTED;
END
GO
CREATE TRIGGER User_Delete
    ON [Products]
    AFTER DELETE
AS
BEGIN
    INSERT INTO History(UserId, Operation)
    SELECT Id, 'DELETED ' FROM DELETED;
END
GO
CREATE TRIGGER User_Update
    ON [Products]
    AFTER UPDATE
AS
BEGIN
    INSERT INTO History(UserId, Operation)
    SELECT Id, 'UPDATED ' FROM INSERTED;
END
GO