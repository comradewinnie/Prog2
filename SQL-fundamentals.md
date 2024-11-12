# Learning SQLite

## Creating new table for doctors
```SQL
CREATE TABLE Doctors (
  DoctorID INTEGER PRIMARY KEY AUTOINCREMENT,
  Name TEXT NOT NULL,
  Surname TEXT NOT NULL,
  Multiplier DECIMAL NOT NULL
  );
```