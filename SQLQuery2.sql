
drop table Employee;
drop table Council;
drop table Policy;
drop table Project;
drop table PolicyProject;
drop table Task;
drop table Complaint;
drop table ProjectManager;


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
	FOREIGN KEY (projectID) REFERENCES Project(projectID)
);

CREATE TABLE Task(
	processID INT,
	description VARCHAR(255),
	cost INT,
	workers INT, 
	TimeFrame INT,
	ecoImpact INT,
	happiness INT,
	complaints INT,
	weight FLOAT,
	policyProjectID VARCHAR(80),
	PRIMARY KEY (processID),
	FOREIGN KEY (policyProjectID) REFERENCES PolicyProject(policyProjectID)
);

CREATE TABLE Complaint(
	complaintDesc VARCHAR(140),
	taskID INT,
	handled INT,
	FOREIGN KEY (taskID) REFERENCES Task(processID)
);


INSERT INTO Council VALUES (1, 'Wollongong', 100, 1000)
INSERT INTO Council VALUES (2, 'Kiama', 100, 1000)
INSERT INTO Council VALUES (3, 'ShellHarbour', 100, 1000)

INSERT INTO Policy VALUES ('Greener Gong', 'Make Wollongong the most environmentally sustainable districy', 2)
INSERT INTO Policy VALUES ('Daily Operations', 'The day to day workings of the council', 1)
INSERT INTO Policy VALUES ('policy3', 'policyStatement', 3)

INSERT INTO Employee VALUES ('1', 'CEO', 'phone1', 'address1', 'email@mail', 'department1', 'ceo', 'pass', 1)
INSERT INTO Employee VALUES ('2', 'Works Head', 'phone1', 'address1', 'email@mail', 'works', 'works', 'pass', 2)
INSERT INTO Employee VALUES ('3', 'deptHead2', 'phone1', 'address1', 'email@mail', 'department2', 'head2', 'pass', 2)
INSERT INTO Employee VALUES ('4', 'Waste Disposal Manager', 'phone1', 'address1', 'email@mail', 'works', 'garbage', 'pass', 3)
INSERT INTO Employee VALUES ('5', 'manager2', 'phone1', 'address1', 'email@mail', 'department2', 'manag2', 'pass', 3)
INSERT INTO Employee VALUES ('6', 'manager3', 'phone1', 'address1', 'email@mail', 'department1', 'manag3', 'pass', 3)

INSERT INTO Project VALUES (1, 'Clean Energy Alternative', 'Establish clean energy production facilities', 100000, 'The Greens', 'department1')
INSERT INTO Project VALUES (2, 'Garbage Collection', 'Daily Garbage Collection for City', 25000, 'Residents', 'works')
INSERT INTO Project VALUES (3, 'Park Maintenance', 'Weekly maintenance of Parks', 5000, 'Residents', 'works')
INSERT INTO Project VALUES (4, 'project4', 'objective4', 10000, 'stakeholder4', 'department4')

INSERT INTO PolicyProject VALUES(1, 1/2/15, GetDate(), GetDate(), 100000, 30, 2, 4, 1, 1, 20)
INSERT INTO PolicyProject VALUES(2, 1/1/17, 31/12/17, 31/12/17, 25000, 50, 2, 4, 2, 2, 50)
INSERT INTO PolicyProject VALUES(3, 1/1/17, 31/12/17, 31/12/17, 5000, 50, 2, 5, 2, 3, 50)
INSERT INTO PolicyProject VALUES(4, GetDate(), GetDate(), GetDate(), 5000, 50, 2, 5, 2, 1, 20)
INSERT INTO PolicyProject VALUES(5, GetDate(), GetDate(), GetDate(), 4000, 60, 2, 5, 2, 2, 20)
INSERT INTO PolicyProject VALUES(6, GetDate(), GetDate(), GetDate(), 30000, 70, 2, 5, 2, 3, 20)

INSERT INTO Task VALUES(1, 'Daily Garbage Collection', 100, 1, 1, -10, 5, 2, 0.4, 1)
INSERT INTO Task VALUES(2, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(3, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(4, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(5, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(6, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(7, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(8, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(9, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(10, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(11, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(12, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(13, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(14, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(15, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(16, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(17, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(18, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(19, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(20, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(21, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(22, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(23, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(24, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(25, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(26, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(27, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(28, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(29, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(30, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(31, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(32, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(33, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(34, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(35, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(36, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(37, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(38, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(39, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(40, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(41, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(42, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(43, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(44, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(45, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(46, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(47, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(48, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(49, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)
INSERT INTO Task VALUES(50, 'Weekly Park Maintenance', 100, 1, 1, 10, 15, 1, 2, 1)

INSERT INTO Complaint VALUES('Garbage Truck hit car', 1, 1)
INSERT INTO Complaint VALUES('Garbage Truck hit car', 1, 1)
INSERT INTO Complaint VALUES('Mower ran over cat', 2, 0)

