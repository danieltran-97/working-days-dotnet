# working-days-dotnet Design

# Console App
## Holday.cs
- This class will represent each public holiday in the csv file.
- It will consist of 5 properties representing the 5 columns in the csv.
- It will have one method ```PublicHolidayFallsOn()``` that returns a string stating whether the public holiday falls before, after or on the weekend.

## CsvParser.cs
- I made this class static, as I felt that there was no need to instantiate an object to use the class' method.
- I made a const variable ```File``` which contains the name of the csv file, so that I can reference it later.
- The ```ParseHolidaysCsv()``` method returns a list of ```Holiday```s, it basically parses the csv file and turns it into usable data.
- I could have used a downloaded CsvHelper library but I decided to challenge my self to make my own csv reader.
- I reference the ```File``` const to make a ```path``` variable of the csv file.
- I will eventually parse ```path``` into ```StreamReader()``` inorder to read the contents of the csv file.
- I made 5 List variables that represent the 5 columns in the csv, to store the columns from the csv.
- I first had trouble splitting up the csv due to some Information column fields containing commas. I then created a method ```SplitCommasOutsideQuotes()``` to only split commas outside of quotes. I did this by using a regex pattern I found on Stackoverflow.
- In the for loop I made the starting index 1 to ignore the column headers of the csv. The for loop adds the data from the Lists I created which store the columns. This data is stored as a ```Holiday``` object and this object is then stored as a list of holidays ```List<Holiday>```.
