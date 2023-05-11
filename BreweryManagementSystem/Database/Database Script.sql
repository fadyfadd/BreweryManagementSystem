
use master

IF (EXISTS (SELECT name 
FROM master.sys.databases
WHERE (name = 'BreweryManagementSystem')))
BEGIN
    alter database  [BreweryManagementSystem] set single_user with rollback immediate
    drop database if exists BreweryManagementSystem
END;
 
create database BreweryManagementSystem

use BreweryManagementSystem

create table Beer    (
    Id INT IDENTITY(1,1),
    [Name] NVARCHAR(100) UNIQUE,
    WholeSalePrice Numeric(10,2),
    RetailPrice Numeric(10,2)
    primary key (id)
)

create table Brewery (
    Id Int IDENTITY(1,1)  ,
    [Name] NVARCHAR(100) UNIQUE,
    primary key (Id)
)

create table Brewery_Beer(
    Id int IDENTITY(1,1),
    BeerId Int ,
    BreweryId Int
    primary key (id)
)

alter table Brewery_Beer add CONSTRAINT FK_Brewery_Beer_1 FOREIGN KEY(BeerId) REFERENCES Beer(Id)
alter table Brewery_Beer add CONSTRAINT FK_Brewery_Beer_2 FOREIGN Key(BreweryId) REFERENCES Brewery(Id)
alter table Brewery_Beer add CONSTRAINT UC_Brewery_Beer_3 UNIQUE(BeerId)

create table WholeSaler(
    Id int identity(1,1)
    primary key (id)
)

create table wholeSaler_Beer(
    Id int identity(1,1),
    WholeSalerId int,
    BeerId int,
    primary key (id)
)

alter table wholeSaler_Beer add CONSTRAINT FK_WholeSaler_Beer_1 FOREIGN KEY(BeerId) REFERENCES Beer(Id)
alter table wholeSaler_Beer add CONSTRAINT FK_WholeSaler_Beer_2 FOREIGN Key(WholeSalerId) REFERENCES WholeSaler(Id)
alter table wholeSaler_Beer add CONSTRAINT UC_WholeSaler_Beer_3 UNIQUE(BeerId , WholeSalerId)

create table WholeSaler_Stock(
    Id int identity(1,1), 
    DefinedBeerId int,   
    Quantity int,     
    primary key (id)
)

alter table WholeSaler_Stock add CONSTRAINT FK_WholeSaler_Stock_1 FOREIGN KEY(DefinedBeerId) REFERENCES wholeSaler_Beer(Id)
alter table wholeSaler_Beer add CONSTRAINT UC_WholeSaler_Stock_2 UNIQUE(BeerId , WholeSalerId)

insert into Brewery(Name) VALUES('3 Brasseurs');
insert into Brewery(Name) VALUES('Beirut Micro Brasserie')

insert into Beer(Name , WholeSalePrice , RetailPrice) VALUES('Blonde' , 10 , 12);
insert into Beer(Name , WholeSalePrice , RetailPrice) VALUES('Brune' , 11 , 13);

insert into Brewery_Beer(BeerId , BreweryId) VALUES(1 ,1);
insert into Brewery_Beer(BeerId , BreweryId) VALUES(2 ,2);
