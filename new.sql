

CREATE DATABASE PROJECT_AGRICULTURE;

CREATE TABLE Manager
(
number int  IDENTITY  (1,1) NOT NULL,
manager_id as 'M' + RIGHT ('000'+ CAST(number AS VARCHAR(7)),7)persisted,
manager_name CHAR(30) NOT NULL,
manager_NIC CHAR(12) NOT NULL UNIQUE,
man_tp VARCHAR(14),
man_uname VARCHAR(14),
man_pw VARCHAR(14),
CONSTRAINT pk_Manager PRIMARY KEY(manager_id),
CHECK (manager_id LIKE'M%')
);

SELECT * FROM Manager;


CREATE TABLE Employee
(
number int  IDENTITY  (1,1) NOT NULL,
employee_id as 'E' + RIGHT ('000'+ CAST(number AS VARCHAR(7)),7)persisted,
employee_name CHAR(30),
employee_NIC CHAR(12)NOT NULL UNIQUE,
employee_oficial_telephone INT,
starting_date DATE DEFAULT getdate(),
CONSTRAINT pk_Employee PRIMARY KEY(employee_id),
CHECK (employee_id LIKE'E%')
);
INSERT INTO Employee VALUES('Sachintha Madhawa','200013567V',0713434234,SYSDATETIME());
INSERT INTO Employee VALUES('Sachintha Madhawa','200013467V',0713434234,SYSDATETIME());
INSERT INTO Employee VALUES('Sachintha Madhawa','200013557V',0713434234,SYSDATETIME());
INSERT INTO Employee VALUES('Sachintha Madhawa','200013527V',0713434234,SYSDATETIME());
INSERT INTO Employee VALUES('Sachintha Madhawa','200013557V',0713434234,SYSDATETIME());
INSERT INTO Employee VALUES('Sachintha Madhawa','205013557V',0713434234,SYSDATETIME());

SELECT * FROM Employee;

SELECT * FROM Area;
SELECT * FROM Field;


CREATE TABLE Area
(
number int  IDENTITY  (1,1) NOT NULL,
area_id as 'A' + RIGHT ('000'+ CAST(number AS VARCHAR(7)),7)persisted,

area_name CHAR(30) NOT NULL UNIQUE,
number_of_fields INT,
employee_id VARCHAR(8) UNIQUE,
CONSTRAINT pk_Area PRIMARY KEY(area_id),
CONSTRAINT fk_Area FOREIGN KEY(employee_id)REFERENCES Employee
); 
  
select * from Area

CREATE TABLE Field(
number int  IDENTITY  (1,1) NOT NULL,
field_id as 'F'+ RIGHT ('000'+ CAST(number AS VARCHAR(7)),7)persisted,
field_name CHAR(30) NOT NULL UNIQUE,
field_size REAL NOT NULL,
farmer_name CHAR(25),
land_owner_name CHAR(25),
area_id VARCHAR(8) NOT NULL,
CONSTRAINT pk_Field PRIMARY KEY(field_id),
CONSTRAINT fk_Field FOREIGN KEY(area_id)REFERENCES Area
);






select * from field


CREATE TABLE Fertilizer
(
number int  IDENTITY  (1,1) NOT NULL,
  
fertilizer_id as 'FE'+ RIGHT ('000'+ CAST(number AS VARCHAR(7)),7)persisted,
fertilizer_name CHAR(25) NOT NULL,
official_unit_price VARCHAR(50),
quantity VARCHAR(7),
supplier_id varchar(9),
CONSTRAINT pk_Fertilizer PRIMARY KEY(fertilizer_id),
CONSTRAINT fk_Supplier FOREIGN KEY(supplier_id)REFERENCES Supplier
);

CREATE TABLE Supplier(
number int  IDENTITY  (1,1) NOT NULL,
supplier_id as 'SU'+ RIGHT ('000'+ CAST(number AS VARCHAR(7)),7)persisted,
supplier_name CHAR(30),
supplier_address CHAR(25),
suppplier_telephone int,
CONSTRAINT pk_Supplier PRIMARY KEY(supplier_id)
);

SELECT * FROM Supplier;


CREATE TABLE Student
(
number int  IDENTITY  (1,1) NOT NULL,
student_id as 'S'+ RIGHT ('000'+ CAST(number AS VARCHAR(7)),7)persisted,
f_name VARCHAR(100),
l_name VARCHAR(100),
st_address VARCHAR(100),
dob DATE,
st_tp VARCHAR(14)

CONSTRAINT pk_Student PRIMARY KEY (student_id)
);


SELECT * FROM Supplier


SELECT * FROM Manager;


CREATE TABLE Fertilizer_Supplier(
number int  IDENTITY  (1,1) NOT NULL,
fertilizer_id VARCHAR(9),
supplier_id VARCHAR(9),
CONSTRAINT pk_Fertilizer_Supplier PRIMARY KEY (fertilizer_id,supplier_id),
CONSTRAINT fk_Fertilizer_Supplier FOREIGN KEY (fertilizer_id)REFERENCES Fertilizer,
                                  FOREIGN KEY(supplier_id)REFERENCES Supplier

);















SELECT * FROM Field;

SELECT * FROM Area;










   