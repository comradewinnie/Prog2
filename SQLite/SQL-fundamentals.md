# Learning SQLite

## Print all data from table 'table'
```SQL
SELECT * FROM table;
```

## Print 'ID' column from table 'table'
```SQL
SELECT id FROM table;
```

## Select ID from 15 to 20
```SQL
SELECT id FROM table WHERE id BETWEEN 15 AND 20;
```

## Delete table
```SQL
DROP TABLE table;
```

## Print rows where 'age' value is >= 10
```SQL
SELECT * FROM Pets WHERE age >= 10;
```

## Print rows where 'age' value is >= 10, but print only name and age
```SQL
SELECT name, age FROM Pets WHERE age >= 10;
```

## Select by text
```SQL
SELECT * FROM Pets WHERE kind == 'Dog' AND age >= 10
```

## Calculate how many owners are in each city and display the grouped data
```SQL
SELECT city, COUNT(ownerid) AS owner_count FROM Owners GROUP BY city;
```

## In descending order of the number of owners
```SQL
ORDER BY owner_count DESC;
```

## Only that cities where owners > 1
```SQL
HAVING owner_count > 1
```
(you can't use WHERE with GROUP BY!)
WHERE -> SELECT, UPDATE, DELETE
HAVING -> SELECT (only)

## Merge two tables by key
```SQL
SELECT * FROM Sales
LEFT JOIN Procedures ON Sales.procedurecode = Procedures.procedurecode;
```

## Print only price
```SQL
SELECT Sales.*, Procedures.price FROM SALES
LEFT JOIN Procedures ON Sales.procedurecode = Procedures.procedurecode;
```

## Calculate the total price and group by country
```SQL
SELECT Sales.country, SUM(Procedures.price) AS total_price
FROM Sales
LEFT JOIN Procedures ON Sales.procedurecode = Procedures.procedurecode
GROUP BY Sales.country;
```

## Average price for every country
```SQL
SELECT Sales.country, SUM(Procedures.price) AS SalesAmount, COUNT(*) AS SalesCount,
SUM(Procedures.price)/COUNT(*) AS Average
FROM Sales
LEFT JOIN Procedures ON Sales.procedurecode = Procedures.procedurecode
GROUP BY Sales.country;
```

## Create new table for doctors
```SQL
CREATE TABLE Doctors (
  DoctorID INTEGER PRIMARY KEY AUTOINCREMENT,
  Name TEXT NOT NULL,
  Surname TEXT NOT NULL,
  Multiplier DECIMAL NOT NULL
  );
```

## Insert data into table
```SQL
INSERT INTO Doctors (Name, Surname, Multiplier)
VALUES
  ('Anna', 'Apse', 2),
  ('Oskars', 'Andersons', 0.5),
  ('Jenifere', 'Pottere', 3.2);
```

## Delete records from table by 'doctorid'
```SQL
DELETE FROM Doctors WHERE doctorid > 4;
```

## Add new calculated column to the query
```SQL
SELECT name, surname, multiplier, (multiplier * 100) AS MultiplierX100
FROM Doctors;
```
