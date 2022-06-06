create database RegMVC;
use RegMVC
create table tblRegistration(
Id int Primary key not null,
FName varchar(60) not null,
Lname varchar(60) not null,
Password varchar(20) not null,
City varchar(30) not null,
);
create table UserCart(
cart_id int primary key,
Id int foreign key references tblRegistration(Id),
);
create table CartLine(
cartline_id int primary key,
categories varchar(50),
no_of_items int,
cart_id int foreign key references UserCart(cart_id)
);
create table Product(
Product_id int primary key not null,
Product_name varchar(100),
Product_category varchar(50),
Product_price varchar(30),
Product_desc varchar(500),
cartline_id int foreign key references CartLine(cartline_id)
);

select * from tblRegistration
create table Contact(
user_id int primary key not null,
user_name varchar(50) not null,
user_email varchar(70) not null,
user_query varchar(500) not null
);

select * from Contact
select * from tableRegistration