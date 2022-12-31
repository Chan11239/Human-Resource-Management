CREATE TABLE  autonumbers  (
   id  int NOT NULL IDENTITY(1, 1),
   lastModifiedDate  datetime DEFAULT CURRENT_TIMESTAMP,
   isActive  bit DEFAULT(1),
   prefix  varchar(10) DEFAULT NULL,
   suffix  varchar(10) DEFAULT NULL,
   currentSequence  int DEFAULT  0 ,
   zeroPadding  int DEFAULT  0 ,
   displaySequence  varchar(100) DEFAULT NULL,
   groupType  varchar(80) NOT NULL,
  PRIMARY KEY ( id )
)

CREATE TABLE  details  (
   employeeNo  varchar(50) NOT NULL,
   lastName  varchar(25) DEFAULT NULL,
   firstName  varchar(25) DEFAULT NULL,
   middleName  varchar(25) DEFAULT NULL,
   fullName  varchar(100) DEFAULT NULL,
   department  varchar(50) DEFAULT NULL,
   position  varchar(50) DEFAULT NULL,
   classification  varchar(50) DEFAULT NULL,
   rankEmployee  varchar(50) DEFAULT NULL,
   points int,
   salaryRate  varchar(50) DEFAULT NULL,
   dateAppointment  date DEFAULT NULL,
   statusOfEmployement  varchar(50) DEFAULT NULL,
   newDateAppointment  date DEFAULT NULL,
   newDepartment  varchar(50) DEFAULT NULL,
   newPosition  varchar(50) DEFAULT NULL,
   dateSeparation  date DEFAULT NULL,
   natureOfSeparation  varchar(50) DEFAULT NULL,
  PRIMARY KEY ( employeeNo )
)

CREATE TABLE departmentList (
	id int IDENTITY(1,1) PRIMARY KEY,
	departmentName varchar(50),
	classificationName varchar(50),
	lastModifiedDate DateTime DEFAULT CURRENT_TIMESTAMP,
	isActive bit
)

CREATE TABLE rankList (
	id int IDENTITY(1,1) PRIMARY KEY,
	classificationName varchar(50),
	startPoint varchar(50),
	endPoint varchar(50),
	type varchar(50),
	rankName varchar(50),
	salaryRate varchar(50)
)

CREATE TABLE positionList (
	id int IDENTITY(1,1) PRIMARY KEY,
	classificationName varchar(50),
	departmentName varchar(50),
	positionName varchar(50),
	isActive bit
)

CREATE TABLE leaveList (
	id int IDENTITY(1,1) PRIMARY KEY,
	code varchar(50),
	name varchar(50),
	description varchar(MAX),
	allotedDays varchar(50),
	isActive bit
)

CREATE TABLE leaveApplications (
	id int IDENTITY(1,1) PRIMARY KEY,
	employeeNo varchar(50),
	employeeName varchar(50),
	reasons varchar(MAX),
	department varchar(50),
	startDate Date,
	endDate Date,
	status varchar(50),
	typeOfLeave varchar(50)
)
CREATE TABLE Flavors (ItemCode int, ItemDesc VARCHAR(100), Price float);
DROP TABLE leaveApplications
