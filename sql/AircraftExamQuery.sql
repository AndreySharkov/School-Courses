SELECT
a.Manufacturer,
a.Model,
a.FlightHours,
a.Condition
FROM Aircraft AS a
ORDER BY a.FlightHours DESC;

--2
SELECT
p.FirstName,
p.LastName,
a.Manufacturer,
a.Model,
a.FlightHours
FROM Pilots AS p
JOIN PilotsAircraft AS pa ON p.Id = pa.PilotId
JOIN Aircraft AS a ON pa.AircraftId = a.Id
WHERE FlightHours < 304
ORDER BY a.FlightHours DESC, p.FirstName ASC;

--3
SELECT TOP 20
fd.Id,
fd.Start,
ps.FullName,
ap.AirportName,
fd.TicketPrice
FROM FlightDestinations AS fd
JOIN Airports AS ap ON fd.AirportId = ap.Id
JOIN Passengers AS ps ON fd.PassengerId = ps.Id
WHERE DATEPART(DAY, fd.Start) % 2 = 0
ORDER BY fd.TicketPrice DESC, ap.AirportName ASC;

