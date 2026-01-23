SELECT 
o.Name,
COUNT(a.ID) AS NumberOfAnimals
FROM Owners AS o
Join Animals AS a ON o.ID = a.OwnerID
GROUP BY o.Name
ORDER BY NumberOfAnimals DESC;


SELECT 
CONCAT(o.Name, '-', a.Name) AS OwnerAnimal,
o.PhoneNumber,
c.CageId AS CageID
FROM Owners AS o
Join Animals AS a ON o.ID = a.OwnerID
JOIN AnimalTypes AS at ON at.ID = a.AnimalTypeId
JOIN AnimalsCages AS c ON c.AnimalId = a.ID
WHERE at.AnimalType = 'Mammals'
ORDER BY o.Name, a.Name DESC;


