CREATE TABLE Employees(
EmployeeId INT Identity PRIMARY KEY, 
FullName VARCHAR(50) NOT NULL
)

CREATE TABLE Departments(
DepartmentId INT IDENTITY PRIMARY KEY, 
Name VARCHAR(20) NOT NULL
)

CREATE TABLE EmployeeDepartments(
EmployeeId INT NOT NULL,
DepartmentId INT NOT NULL
CONSTRAINT PK_EmplayeesDepartments Primary KEY(EmployeeID, DepartmentId),

CONSTRAINT FK_EmplayeesDepartments_Employees FOREIGN KEY(EmployeeID)
REFERENCES Employees