drop table if exists Phone_number;
drop table if exists Personal_date;
drop table if exists Phone;

create table Phone_number
(
	Id int not null identity(1, 1) primary key,
	Phone_number nvarchar(20) not null check (Phone_number <> N'')
);

create table Personal_date
(
	Id int not null identity(1, 1) primary key,
	Person_name nvarchar(20) not null check (Person_name <> N''),
	Person_surname nvarchar(20) not null check (Person_surname <> N''),
	Person_age int not null
);

create table Phone
(
	Id int not null identity(1, 1) primary key,
	Phone_number_id int not null,
	Personal_date_id int not null,
	constraint fk_Phone_number_id foreign key (Phone_number_id) references Phone_number(Id),
	constraint fk_Personal_date_id foreign key (Personal_date_id) references Personal_date(Id)
);

insert into Phone_number(Phone_number) values
('+380 12 345 67 89'), ('+380 13 579 24 68'), ('+380 24 680 13 57'), ('+380 14 703 69 25'), ('+380 25 814 70 36'),
('+380 45 432 79 24'), ('+380 68 685 16 87'), ('+380 10 457 00 84'), ('+380 44 217 13 02'), ('+380 19 048 75 12');

insert into Personal_date(Person_name, Person_surname, Person_age) values
('Name_1', 'Surname_1', 11), ('Name_2', 'Surname_2', 22), ('Name_3', 'Surname_3', 33), ('Name_4', 'Surname_4', 44), ('Name_5', 'Surname_5', 55),
('Name_6', 'Surname_6', 66), ('Name_7', 'Surname_7', 77), ('Name_8', 'Surname_8', 88), ('Name_9', 'Surname_9', 99), ('Name_10', 'Surname_10', 110);

insert into Phone(Phone_number_id, Personal_date_id) values
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10);

select * from Phone;
select * from Phone_number;
select * from Personal_date;