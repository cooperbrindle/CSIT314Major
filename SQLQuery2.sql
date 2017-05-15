drop table Employee;
drop table Ceo;
drop table Process;
drop table PolicyProject;
drop table DepartmentHead;
drop table ProjectManager;
drop table Policy;
drop table Project;



CREATE TABLE Employee(
	name VARCHAR(80),
	employeeID VARCHAR(80),
	phoneNumber VARCHAR(80),
	address VARCHAR(255),
	email  VARCHAR(200),
	department VARCHAR(80),
	password VARCHAR(80),
	PRIMARY KEY (employeeID)
);

CREATE TABLE Ceo(
	name VARCHAR(80),
	employeeID VARCHAR(80),
	phoneNumber VARCHAR(80),
	address VARCHAR(255),
	email  VARCHAR(200),
	password VARCHAR(80),
	PRIMARY KEY (employeeID)
);

CREATE TABLE DepartmentHead (
	name VARCHAR(80),
	departmentHeadID VARCHAR(80),
	phoneNumber VARCHAR(80),
	address VARCHAR(255),
	email  VARCHAR(200),
	department VARCHAR(80),
	password VARCHAR(80),
	PRIMARY KEY (departmentHeadID)
);

CREATE TABLE ProjectManager(
	name VARCHAR(80),
	projectManagerID VARCHAR(80),
	phoneNumber VARCHAR(80),
	address VARCHAR(255),
	email  VARCHAR(200),
	department VARCHAR(80),
	password VARCHAR(80),
	performanceRating INT,
	currentlyAssigned INT,
	PRIMARY KEY (projectManagerID)
);

CREATE TABLE Policy(
	policyName VARCHAR(255),
	policyStatement VARCHAR(255),
	policyID INT,
	PRIMARY KEY (policyID),
	
);

CREATE TABLE Project(
	projectID INT,
	name VARCHAR(80),
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
	projectID INT,
	PRIMARY KEY (policyProjectID),
	FOREIGN KEY (departmentHeadID) REFERENCES DepartmentHead,
	FOREIGN KEY (ProjectManagerID) REFERENCES ProjectManager,
	FOREIGN KEY (projectID) REFERENCES Project
);

CREATE TABLE Process(
	processID INT,
	instructions VARCHAR(255),
	milestones VARCHAR(80),
	cost INT,
	policyProjectID VARCHAR(80),
	PRIMARY KEY (processID),
	FOREIGN KEY (policyProjectID) REFERENCES PolicyProject
);

INSERT INTO Ceo VALUES ('ceo', '1', '11111111', 'address', 'email@mail', 'pass')

INSERT INTO DepartmentHead VALUES ('head1', '1', 'phone', 'address', 'email@mail', 'department1', 'pass')
INSERT INTO DepartmentHead VALUES ('head2', '2', 'phone', 'address', 'email@mail', 'department1', 'pass')
INSERT INTO DepartmentHead VALUES ('head3', '3', 'phone', 'address', 'email@mail', 'department1', 'pass')

INSERT INTO ProjectManager VALUES ('man1', '1', 'phone', 'address', 'email@mail', 'department1', 'pass', 1, 0)
INSERT INTO ProjectManager VALUES ('man2', '2', 'phone', 'address', 'email@mail', 'department1', 'pass' ,1, 0)
INSERT INTO ProjectManager VALUES ('man3', '3', 'phone', 'address', 'email@mail', 'department1', 'pass', 1, 0)

INSERT INTO Project VALUES (1, 'project1', 'objective1', 10000, 'stakeholder1', 'department1')
INSERT INTO Project VALUES (2, 'project2', 'objective2', 10000, 'stakeholder2', 'department2')
INSERT INTO Project VALUES (3, 'project3', 'objective3', 10000, 'stakeholder3', 'department3')
INSERT INTO Project VALUES (4, 'project4', 'objective4', 10000, 'stakeholder4', 'department4')