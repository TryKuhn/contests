# Program description

---

## The program consists of several components:

- Program.cs - the main file where the program is started.

- Splitter.cs - the file that splits the data into a table.

- Data.cs - the file that contains the script that checks that the data is correct.

- Helper.cs - the file that contains all output functions and the description of the query processing function.

- Solver.cs - the file, where all answers to queries are implemented

---

## Implemented functions

### Splitter.cs

- DoSplit - splits string, passed as argument into cells

- ParseInfo - splits passed array of strings into table

### Data.cs

- Bad - checks if the specified table is valid

### Helper.cs

- PrintAllData - prints the table

- PrintPairs - prints/writes the first two columns of the passed table into the file

- PrintAllVariants - outputs possible queries to the user

- StartQuery - user's query processing

### Solver.cs

- InfoAboutPorts - displays the full and short names of all ports of the specified type

- InfoAboutCountry - outputs the busiest ports of the country and then the list of all ports of the country

- BiggestDeparture - displays the world's busiest ports

- TotalPorts - displays the number of ports in the specified country

- InfoBusy - displays the busiest ports in the world

- InfoFree - displays the world's busiest ports

- CountPortsSea - outputs the number of ports in the selected sea

- InfoCountryArrival - displays the number of the freest ports of a given country
