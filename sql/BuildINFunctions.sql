SELECT
FirstName,
LastName
FROM Employees
--WHERE LEFT(FirstName, 2) = 'Sa';
WHERE LastName LIKE '%ei%'; 

SELECT
FirstName
FROM Employees
WHERE DepartmentID IN (3,10) 
AND HireDate >= 1995 OR HireDate <= 2005


--4
SELECT 
FirstName,
LastName
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'
--5
SELECT 
Name
FROM Towns
WHERE LEN(Name) IN (5,6)
ORDER BY Name ASC

SELECT 
TownID,
Name
FROM Towns
WHERE LEFT(Name, 1) IN ('M', 'K', 'B', 'E')
ORDER BY Name ASC

SELECT 
TownID,
Name
FROM Towns
WHERE LEFT(Name, 1) NOT IN ('R', 'B', 'D')
ORDER BY Name ASC
