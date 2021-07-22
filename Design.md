# working-days-dotnet Design

## Holday.cs
- This class will represent each public holiday in the csv file.
- It will consist of 5 properties representing the 5 columns in the csv.
- It will have one method ```PublicHolidayFallsOn()``` that returns a string stating whether the public holiday falls before, after or on the weekend.

## CsvParser.cs
- I made this class static, as I felt that there was no need to instantiate an object to use the class' method.
- I made a const variable ```File``` which contains the name of the csv file, so that I can reference it later.
- The ```ParseHolidaysCsv()``` method returns a list of ```Holiday```s, it basically parses the csv file and turns it into usable data.
- 
