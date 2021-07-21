# working-days-dotnet
## System Requirements
1. Install [.NET Core SDK](https://dotnet.microsoft.com/download)
2. Install [Visual Studio Code](https://code.visualstudio.com/)
3. Open this project in VS Code and accept the prompt to install recommended extensions
4. Open your terminal window in VS code and enter the following commands in order
  - ```cd WorkingDays```
  - ```dotnet run```
5. To run tests, follow the following commands in order
  - ```cd ..``` to go back to the working-days-dotnet directory
  - ```cd WorkingDaysTest```
  - ```dotnet test``` to run unit tests

## WorkingDays
1. The console will ask you to enter a date in the format of mm/dd/yyyy.
```Please enter a 2021 date in mm/dd/yyyy format:  ```
2. Next the console will ask you to enter in an australian state in abreviated form.
```Please enter a state in abbreviated form:  ```
3. Once the two console inputs are entered the program will out put the full date and whether the day is a working day, weekend or public holiday. If the day is a public holiday, the program will output whether it falls before, after or on the weekend. In this case the date I entered 01/01/2021.
``
//Output

Friday, 01 January 2021, is New Year's Day and falls after the weekend. 
```
