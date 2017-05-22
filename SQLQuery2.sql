﻿
drop table Task;
drop table PolicyProject;
drop table ProjectManager;
drop table Policy;
drop table Project;
drop table Employee;
drop table Council;


CREATE TABLE Council(
	councilID int,
	name VARCHAR(80),
	budget float,
	happiness float,
	PRIMARY KEY(councilID)

);

CREATE TABLE Employee(
	employeeID VARCHAR(80),
	name VARCHAR(80),
	phoneNumber VARCHAR(80),
	address VARCHAR(255),
	email  VARCHAR(200),
	department VARCHAR(80),
	username VARCHAR(80),
	password VARCHAR(80),
	privilege INT,
	PRIMARY KEY (employeeID),
);

CREATE TABLE ProjectManager(
	performanceRating INT,
	currentlyAssigned INT,
	employeeID VARCHAR(80),
	PRIMARY KEY (employeeID),
	FOREIGN KEY (employeeID) REFERENCES Employee
);

CREATE TABLE Policy(
	policyName VARCHAR(255),
	policyStatement VARCHAR(255),
	policyID INT,
	PRIMARY KEY (policyID),
	
);

CREATE TABLE Project(
	projectID INT,
	name VARCHAR(80) UNIQUE,
	objective VARCHAR(255),
	budget INT,
	Stakeholder VARCHAR(80),
	department VARCHAR(80),
	PRIMARY KEY (projectID),
);

CREATE TABLE PolicyProject (
	policyProjectID VARCHAR(80),
	startDate VARCHAR(80),
	estimatedEndDate VARCHAR(80),
	endDate VARCHAR(80),
	finalCost INT,
	progress INT,
	departmentHeadID VARCHAR(80),
	projectManagerID VARCHAR(80),
	policyID INT,
	projectID INT,
	weighting INT,
	PRIMARY KEY (policyProjectID),
	FOREIGN KEY (departmentHeadID) REFERENCES Employee(employeeID),
	FOREIGN KEY (ProjectManagerID) REFERENCES Employee(employeeID),
	FOREIGN KEY (policyID) REFERENCES Policy(policyID),
	FOREIGN KEY (projectID) REFERENCES Project
);

CREATE TABLE Task(
	processID INT,
	description VARCHAR(255),
	cost INT,
	workers INT, 
	TimeFrame INT,
	ecoImpact INT,
	happiness INT,
	weight INT,
	policyProjectID VARCHAR(80),
	PRIMARY KEY (processID),
	FOREIGN KEY (policyProjectID) REFERENCES PolicyProject
);

INSERT INTO Council VALUES (1, 'Wollongong', 100, 1000)
INSERT INTO Council VALUES (2, 'Kiama', 100, 1000)
INSERT INTO Council VALUES (3, 'ShellHarbour', 100, 1000)

INSERT INTO Policy VALUES ('policy1', 'policyStatement', 1)
INSERT INTO Policy VALUES ('policy2', 'policyStatement', 2)
INSERT INTO Policy VALUES ('policy3', 'policyStatement', 3)

INSERT INTO Employee VALUES ('1', 'ceo', 'phone1', 'address1', 'email@mail', 'department1', 'ceo', 'pass', 1)
INSERT INTO Employee VALUES ('2', 'deptHead1', 'phone1', 'address1', 'email@mail', 'department1', 'head1', 'pass', 2)
INSERT INTO Employee VALUES ('3', 'deptHead2', 'phone1', 'address1', 'email@mail', 'department2', 'head2', 'pass', 2)
INSERT INTO Employee VALUES ('4', 'manager1', 'phone1', 'address1', 'email@mail', 'department1', 'manag1', 'pass', 3)
INSERT INTO Employee VALUES ('5', 'manager2', 'phone1', 'address1', 'email@mail', 'department2', 'manag2', 'pass', 3)
INSERT INTO Employee VALUES ('6', 'manager3', 'phone1', 'address1', 'email@mail', 'department1', 'manag3', 'pass', 3)

INSERT INTO Project VALUES (1, 'project1', 'objective1', 10000, 'stakeholder1', 'department1')
INSERT INTO Project VALUES (2, 'project2', 'objective2', 10000, 'stakeholder2', 'department2')
INSERT INTO Project VALUES (3, 'project3', 'objective3', 10000, 'stakeholder3', 'department3')
INSERT INTO Project VALUES (4, 'project4', 'objective4', 10000, 'stakeholder4', 'department4')

INSERT INTO PolicyProject VALUES(1, GetDate(), GetDate(), GetDate(), 100, 20, 2, 4, 1, 1, 20)
INSERT INTO PolicyProject VALUES(2, GetDate(), GetDate(), GetDate(), 100, 30, 2, 4, 1, 2, 20)
INSERT INTO PolicyProject VALUES(3, GetDate(), GetDate(), GetDate(), 20, 40, 2, 4, 1, 3, 20)
INSERT INTO PolicyProject VALUES(4, GetDate(), GetDate(), GetDate(), 10, 50, 2, 5, 2, 1, 20)
INSERT INTO PolicyProject VALUES(5, GetDate(), GetDate(), GetDate(), 60, 60, 2, 5, 2, 2, 20)
INSERT INTO PolicyProject VALUES(6, GetDate(), GetDate(), GetDate(), 80, 70, 2, 5, 2, 3, 20)