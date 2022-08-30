drop table if exists History;

create table History
(
	Id int not null identity(1, 1) primary key,
	UserId int not null,
	Operation nvarchar(20) not null check (Operation <> N''),
	DateWhen datetime not null DEFAULT (getdate())
);