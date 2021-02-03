create table Screen_Det
(
    ID  Int Identity primary key,
    [Description]     VARCHAR(500)
)
Go
create table User_Type
(
ID          Int Identity primary key,
User_Type   VARCHAR(20),
Screen_ID   Int
)
Go
ALTER TABLE User_Type
ADD CONSTRAINT user_type_scrn_fk
   FOREIGN KEY (screen_id)
   REFERENCES screen_det (ID);
Go
create table Site_Det
(
Site_ID     Int Identity primary key,
Name        VARCHAR(50),
Logo        varbinary(max)
)
GO
create table city_det
(
ID          Int Identity primary key,
name        VARCHAR(100),
state       VARCHAR(50),
zipcode     VARCHAR(10),
site_ID     Int
)
Go
ALTER TABLE city_det
ADD CONSTRAINT city_det_site_fk
   FOREIGN KEY (site_id)
   REFERENCES Site_Det (site_ID);
GO


create table User_Det
(
ID              Int Identity primary key,
fname           VARCHAR(50),
lname           VARCHAR(50),
pri_Tel_No      Int,
Sec_Tel_No      Int,
email           VARCHAR(30),
user_type_id    Int
)
Go

 ALTER TABLE user_Det
ADD CONSTRAINT user_det_user_type_fk
   FOREIGN KEY (user_type_id)
   REFERENCES User_Type (ID); 
Go

create table Address_Det
(
ID Int Identity primary key,
user_Det_id				int ,
Leasing_office_name     VARCHAR(50),
Bldg_No                 VARCHAR(10),
Street_Address          VARCHAR(100),
city_id                 Int
)
GO

ALTER TABLE Address_Det
ADD CONSTRAINT address_det_city_fk
   FOREIGN KEY (city_id)
   REFERENCES city_det (ID);
GO

ALTER TABLE Address_Det
ADD CONSTRAINT Address_det_user_fk
   FOREIGN KEY (user_Det_id)
   REFERENCES User_Det(ID);
GO
   



   