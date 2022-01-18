# Informat-Interview test

Welcome cadet, your mission, if you choose to accept it, is to create a program according to the specifications below.

## The business logic

In a database you will find the information to link students to klassen. The program should provide the following output:

- A list of the students in klas 2A, as seen on 1 september 2018
- This list is ordered by name if the klas contains less than 10 students
- This list is ordered by id if the klas contains 10 or more students

## The architecture

For this project we will use a 3-tier approach, having a separate layer for the presentation (console application), the
domain logic and the database access.


### Klassen (Class)

| Field | Data type | Description
|-------|-----------|-------------
| Id    | Int       | Unique identifier for a klas
| Name  | Varchar   | Name of the klas
| Code  | Varchar   | Code of the klas

### Leerlingen (Students)

| Field | Data type | Description
|-------|-----------|-------------
| Id    | Int       | Unique identifier for a leerling
| Name  | Varchar   | Name of the leerling

### Inschrijvingen (Enrolments)

| Field | Data type | Description
|-------|-----------|-------------
| Id    | GUID      | Unique identifier for an inschrijving
| LeerlingId | Int  | Leerling Id for this inschrijving
| KlasId | Int      | Klas Id for this inschrijving
| StartDate | DateTime | Startdate for this inschrijving
| EndDate | DateTime | Enddate for this inschrijving
