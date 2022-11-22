create database AuthorizationDB;
go 

use AuthorizationDB;

create table Roles(
id int identity primary key,
RoleName nvarchar(100));

create table Users(
id int identity primary key,
UserName nvarchar(100),
UserPassword nvarchar(100),
UserRole int references Roles(id));
go

use AuthorizationDB;

insert into Roles values
('Customer'),('Manager'),('Admin');
go

use AuthorizationDB;

insert into Users values
('Vasya','incorrect',1),
('Bob','12345',1),
('Big Boss','GGui7qX3900',3),
('A Guy','123guy',2);