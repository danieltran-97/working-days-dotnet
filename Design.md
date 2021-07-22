# Design
- Followed Kent Beck's 4 Principles of Simple Design
  - **Passes tests**: methods pass tests
  - **No duplication**: Followed the DRY princle (Don't repeat yourself)
  - **Reveals intention**: Tried to name classes and class members in an easy way for other devs to understand, without the use of comments.
  - **Fewest elements**: Tried not to use unnecessary methods or class members, tried to keep code of classes between 50-60 lines long. For maintainability purposes.


# Console App
## Holday.cs
- This class will represent each public holiday in the csv file.
- It will consist of 5 properties representing the 5 columns in the csv.
- It will have one method ```PublicHolidayFallsOn()``` that returns a string stating whether the public holiday falls before, after or on the weekend.

## CsvParser.cs
- I made this class static, as I felt that there was no need to instantiate an object to use the class' method.
- I created a const variable ```File``` which contains the name of the csv file, so that I can reference it later.
- The ```ParseHolidaysCsv()``` method returns a list of ```Holiday```s, it basically parses the csv file and turns it into usable data.
- I could have used a downloaded CsvHelper library but I decided to challenge my self to make my own csv reader.
- I reference the ```File``` const to make a ```path``` variable of the csv file.
- I will eventually parse ```path``` into ```StreamReader()``` inorder to read the contents of the csv file.
- Inside the while loop I created 5 List variables that represent the 5 columns in the csv, to store the columns from the csv.
- I first had trouble splitting up the csv due to some Information column fields containing commas. I then created a method ```SplitCommasOutsideQuotes()``` to only split commas outside of quotes. I did this by using a regex pattern I found on Stackoverflow.
- In the for loop I made the starting index 1 to ignore the column headers of the csv. The for loop adds the data from the Lists I created which store the columns. This data is stored as a ```Holiday``` object and this object is then stored as a list of holidays ```List<Holiday>```.
- For the ```Date``` property I converted the string date to a ```DateTime``` so that it could be stored in the object also for the ```Information``` property I decided to remove the quotes of the string if the csv column field it contained commas.

## DayChecker.cs
- I made this class static for the same reason as CsvParser.
- ```CheckWorkingDay()``` returns a boolean determining whether the Date input is a working day, weekend or public holiday.
- The method accepts parameters ```date``` a DateTime and a string ```state```.
- I use the ```ParseHolidayCsv()``` method and store it in the variable ```allHolidays```.
- I created a LINQ query which stores in a list, a holiday if the ```date``` and ```state``` match any holidays from ```allHolidays```.
- ```isHoliday``` is a boolean which determines whether the ```date``` and ```state``` is a public holiday. It is only possible for the ```allHolidays``` list to be empty or have a Count of 1. Therefore having a Count of 1 will indicate that its a holiday
- I also created private method ```IsWeekend()``` for ```CheckWorkingDay``` to use and it determines if a day is Saturday or Sunday.
- ```isWorkingDay``` uses ```IsWeekend()``` and ```isHoliday``` to determine if the day is a working day.
- If the day is a public holiday the method will print to console the full date, name of the public holiday and whether it falls before, after or on the weekend.
- The method will also print a line stating whether the day is a working day or a weekend.

## Program.cs
- I created 2 methods ```GetDecimalFromConsole()``` and ```GetStringFromConsole()``` for retry logic incase the user enters invalid data.

# Testing
- Used the Xunit as my testing tool to write unit tests
- I practiced TDD for this project, and avoided writing the ```Console.Write``` and ```Console.ReadLine``` first as I find it makes me prone to not TDD.

## HolidayShould.cs
- I used inline data to reduce repetition and also the size of the code. This tests the ```PublicHolidayFallsOn()``` method and checks whether its outputing the correct string.
## CsvParserShould.cs
- The first test checks whether ```ParseHolidaysCsv()``` correctly parses the right amount of Holidays from the csv and excluding the headers by expecting the list to have a count of 91.
- The 2nd test tests if a field containing commas within quotes is not split. 
## DayCheckerShould.cs
- The tests here check whether ```CheckWorkingDay()``` returns the the correct boolean, when a ```date``` and ```state``` is entered.
