
drop table Process;
drop table PolicyProject;
drop table ProjectManager;
drop table Policy;
drop table Project;
drop table Employee;



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
	PRIMARY KEY (employeeID)
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
	policyID INT,
	projectID INT,
	PRIMARY KEY (policyProjectID),
	FOREIGN KEY (departmentHeadID) REFERENCES Employee(employeeID),
	FOREIGN KEY (ProjectManagerID) REFERENCES Employee(employeeID),
	FOREIGN KEY (policyID) REFERENCES Policy(policyID),
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

INSERT INTO Employee VALUES ('1', 'ceo', 'phone1', 'address1', 'email@mail', 'department1', 'ceo', 'pass', 1)
INSERT INTO Employee VALUES ('2', 'name2', 'phone1', 'address1', 'email@mail', 'department1', 'head1', 'pass', 2)
INSERT INTO Employee VALUES ('3', 'name3', 'phone1', 'address1', 'email@mail', 'department2', 'head2', 'pass', 2)
INSERT INTO Employee VALUES ('4', 'name4', 'phone1', 'address1', 'email@mail', 'department1', 'manag1', 'pass', 3)
INSERT INTO Employee VALUES ('5', 'name5', 'phone1', 'address1', 'email@mail', 'department2', 'manag2', 'pass', 3)
INSERT INTO Employee VALUES ('6', 'name6', 'phone1', 'address1', 'email@mail', 'department1', 'manag3', 'pass', 3)

INSERT INTO Project VALUES (1, 'project1', 'objective1', 10000, 'stakeholder1', 'department1')
INSERT INTO Project VALUES (2, 'project2', 'objective2', 10000, 'stakeholder2', 'department2')
INSERT INTO Project VALUES (3, 'project3', 'objective3', 10000, 'stakeholder3', 'department3')
INSERT INTO Project VALUES (4, 'project4', 'objective4', 10000, 'stakeholder4', 'department4')