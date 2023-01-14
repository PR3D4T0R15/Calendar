# Calendar

## Zapytania do bazy danych

### Wpisanie daty do bazy
> INSERT INTO main.Wydarzenia (nazwa, dzien, miesiac, rok, czyWazne) VALUES ('$nazwa', '$dzien', '$miesiac', '$rok', '$czyWazne');

### Pobranie wydarzen dla miesiaca
> SELECT dzien,nazwa FROM main.Wydarzenia WHERE miesiac = $miesiac AND rok=$rok  ORDER BY dzien ASC;

### Pobieranie nadchodzacych wydarzen
> SELECT dzien,nazwa FROM main.Wydarzenia WHERE miesiac = $miesiac AND dzien > $dzien AND rok=  $rok ORDER BY dzien ASC;

### Pobranie waznych wydarzen
> SELECT dzien,miesiac,nazwa FROM main.Wydarzenia WHERE czyWazne = $czyWazne ORDER BY dzien ASC;

### Pobranie wydarzen dla dnia
> SELECT nazwa FROM main.Wydarzenia WHERE dzien = $dzien AND miesiac = $miesiac AND rok = $rok ORDER BY id ASC;

### Usuwanie wydarzen
> DELETE FROM main.Wydarzenia WHERE dzien = dzien AND miesiac = mc AND rok = rok AND nazwa = nazwa;


## Tworzenie baz danych

### wydarzenia
> CREATE TABLE "Wydarzenia" (
>	  "id"	INTEGER NOT NULL UNIQUE,
> 	"nazwa"	TEXT NOT NULL,
> 	"dzien"	INTEGER NOT NULL,
> 	"miesiac"	INTEGER NOT NULL,
> 	"rok"	INTEGER NOT NULL,
> 	"czyWazne"	INTEGER NOT NULL DEFAULT 0,
> 	PRIMARY KEY("id" AUTOINCREMENT)
> )

## Wypełnianie bazy danych
> INSERT INTO "main"."Wydarzenia" ("nazwa", "dzien", "miesiac", "rok", "czyWazne") VALUES ('Nowy Rok', '1', '1', '2023', '1');
