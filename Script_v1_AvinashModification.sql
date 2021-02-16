create table Screen_Det
(
    ID              int identity primary key,
    [Description]    VARCHAR(500),
    created_dt      DATETIME,
    created_by      VARCHAR(10),
    updated_dt      DATETIME,
    updated_by      VARCHAR(10)
)

Go
create table Questions_Det
(
    ID       int identity primary key,
    [Desc]     VARCHAR(500),
    created_dt      DATETIME,
    created_by      VARCHAR(10),
    updated_dt      DATETIME,
    updated_by      VARCHAR(10)
)

Go
create table Site_Det
(
    Site_ID     int identity primary key,
    [Desc]        VARCHAR(50),
    Logo        VarBinary(max),
    State       VARCHAR(30),
    created_dt  DATETIME,
    created_by  VARCHAR(10),
    updated_dt  DATETIME,
    updated_by  VARCHAR(10)

)

Go

create table roles_det
(
    ID          int identity Primary key,
    ROle_cd     VARCHAR(10),
    Role_Desc   VARCHAR(30),
    Role_Act_Ir int,
    created_dt  DATETIME,
    created_by  VARCHAR(10),
    updated_dt  DATETIME,
    updated_by  VARCHAR(10)
)

Go
create table roles_Screen_map
(
	ID			int Identity,
    Role_cd     VARCHAR(10),
    Screen_ID   int,
    Role_Act_Ir VARCHAR(1),
    created_dt  DATETIME,
    created_by  VARCHAR(10),
    updated_dt  DATETIME,
    updated_by  VARCHAR(10)
)
Go

create table Usr_role_map
(
	Id			int Identity,
    User_ID     int,
    Role_ID     int,
    Role_Act_Ir VARCHAR(1),
    created_dt  DATETIME,
    created_by  VARCHAR(10),
    updated_dt  DATETIME,
    updated_by  VARCHAR(10)
)

Go

create table Address_Det
(
    ID                      int identity primary key,
    Leasing_office_name     VARCHAR(50),
    Bldg_No                 VARCHAR(10),
    Add_Type                VARCHAR(10),
    Street_Address_1        VARCHAR(100),
    Street_Address_2        VARCHAR(100),
    APT_No                  VARCHAR(5),
    city                    VARCHAR(20),
    State                   VARCHAR(20),
    Zipcode                 VARCHAR(10),
    site_ID                 int,
    created_dt              DATETIME,
    created_by              VARCHAR(10),
    updated_dt              DATETIME,
    updated_by              VARCHAR(10)
)

Go
ALTER TABLE Address_Det
ADD CONSTRAINT address_det_site_fk
   FOREIGN KEY (site_id)
   REFERENCES site_det (site_ID);

Go

create table User_Det
(
    ID              int identity,
    Address_ID      int not null,
    fname           VARCHAR(50),
    lname           VARCHAR(50),
    pri_Tel_No      int,
    Sec_Tel_No      int,
    email           VARCHAR(30),
    Alt_email       VARCHAR(30),
    Passwd          VARCHAR(50),        
    Is_Verified     int,
    DOB             DATETIME,
    Acv_Ir          int,
    created_dt      DATETIME,
    created_by      VARCHAR(10),
    updated_dt      DATETIME,
    updated_by      VARCHAR(10)
)

Go
alter table User_Det add constraint User_Det_comp_key primary key(ID,Address_ID);

Go

create table Cust_Det
(
    ID              int identity,
    Address_ID      int not null,
    fname           VARCHAR(50),
    lname           VARCHAR(50),
    pri_Tel_No      varchar(12),
    Sec_Tel_No      varchar(12),
    email           VARCHAR(30),
    Alt_email       VARCHAR(30),
    Passwd          VarBinary(200),        
    Is_Verified     int,
    DOB             DATETIME,
    Acv_Ir          int,
    Reg_Dt          DATETIME,
    created_dt      DATETIME,
    created_by      VARCHAR(10),
    updated_dt      DATETIME,
    updated_by      VARCHAR(10)
)

Go

alter table cust_Det add constraint Cust_Det_comp_key primary key(ID,Address_ID);

Go
   



   