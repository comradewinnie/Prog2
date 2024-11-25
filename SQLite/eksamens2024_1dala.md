https://skolo.lv/mod/book/view.php?id=83627824&chapterid=351652
```SQL
CREATE TABLE Kafejnicas (
  ID INTEGER PRIMARY KEY AUTOINCREMENT,
  Nosaukums VARCHAR(32),
  Adrese VARCHAR(100)
);

INSERT INTO Kafejnicas (nosaukums, adrese) VALUES
('Pie Jāņa', 'Brīvibas iela 10'),
('Buločka', 'Graudu iela 13'),
('Trīs graudi', 'Zemgales iela 29');

CREATE TABLE Darbinieki (
  ID INTEGER PRIMARY KEY AUTOINCREMENT,
  Vards VARCHAR(32),
  Uzvards VARCHAR(32),
  Talruna_numurs CHAR(12),
  Amats VARCHAR(32),
  Kafejnicas_ID INTEGER,
  Atvalinajums BOOLEAN,
  FOREIGN KEY (kafejnicas_id) REFERENCES Kafejnicas(id)  
);

INSERT INTO Darbinieki (vards, uzvards, talruna_numurs, amats, kafejnicas_id, atvalinajums) VALUES
('Jānis', 'Bērziņš', '+37120000000', 'viesmīlis', 1, TRUE),
('Viktors', 'Raskoļņikovs', '+37126756729', 'boss', 2, FALSE),
('Viesturs', 'Liepiņš', '+37124726506', 'pāvars', 1, FALSE);

CREATE TABLE Pasutijumi (
  ID INTEGER PRIMARY KEY AUTOINCREMENT,
  Summa REAL,
  Datums DATE,
  Apraksts VARCHAR(100),
  Darbinieka_ID INTEGER,
  FOREIGN KEY (darbinieka_id) REFERENCES Darbinieki(id)
);
```
