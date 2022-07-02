drop table if exists Main_info;
drop table if exists Appearance;

create table Appearance
(
	Id int not null identity(1, 1) primary key,
	Hair_color nvarchar(20) not null check (Hair_color <> N''),
	Eye_color nvarchar(20) not null check (Eye_color <> N'')
);

create table Main_info
(
	Id int not null identity(1, 1) primary key,
	Person_name nvarchar(20) not null check (Person_name <> N''),
	Person_surname nvarchar(20) not null check (Person_surname <> N''),
	Person_age int not null,
	Person_appearance_id int not null,
	constraint fk_Person_appearance_id foreign key (Person_appearance_id) references Appearance(Id)
);
