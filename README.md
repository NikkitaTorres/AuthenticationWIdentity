# SweetTreat

Created By: Nikkita Torres

## Description 

The SweetTreat web application is designed to allow users to register and sign in. Users that are signed in are able to create, update, and delete both treats and flavors, while users that are just visiting the site are only able to view the treats and flavors.

## Technologies Used

* C#
* MySQL Workbench 8.0 CE
* HTML
* Razor Pages
* ASP.NET Core
* Entity Framework Core

## Setup/Installation Requirements

1. Clone [this](https://github.com/NikkitaTorres/AuthenticationWIdentity.git) repository to your desktop.
2. This project requires a file named "appsettings.json". Create this file at the top level directory of the project (SweetTreat.Solution) by typing "touch appsettings.json" into your terminal.
3. After creating the file, add the following code to the file: "{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database="";uid=YOUR_USERNAME_HERE;pwd=YOUR_PASSWORD_HERE;"
  }
}".
The database="" apostrophes should be changed to whatever you decide to name sql file that will be imported (default: nikkita_torres). Make sure to replace the "YOUR_USERNAME_HERE" and "YOUR_PASSWORD_HERE" with your own username and password for MySQL Workbench, no apostrophes needed.
4. You can either import the nikkita_torres.sql file into MySQL Workbench to re-create the database or use migrations to re-create and update the database. You can import the file by:

- Selecting "Data Import/Export" in the Navigator/Administration"
- Select "Import from Self-Contained File" and select the "nikkita_torres" file inside of the Factory.Solution folder.
- You can rename this file by clicking "New..." next to the "Default Schema to be Imported To", but make sure to adjust the "database=" accordingly in step 3.
- Finally, click the "Start Import" button located in the bottom right.

To create the database using migrations:
- First install dotnet-ef if you haven't already done so. This can be accomplished by running "dotnet tool install --global dotnet-ef --version 6.0.0" in the terminal. If you've already done this, move onto the next step.
- In the production directory (SweetTreat) of the project, run "dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0" in the terminal.
- Run "dotnet ef migrations add Initial" in the terminal. "Initial" can be renamed to something else here, but it is common to leave it as "Initial" or something with a similair meaning for the first migration.
- Finally, run "dotnet ef database update" in terminal to update/create the database. The database will be named whatever you entered into the "database=" portion of step 3.

After you are finished with the above steps, in MySQL Workbench, open the "Navigator > Schemas tab". Right click and select "Refresh All". The new database will appear.
5. Navigate to the Factory directory and run "dotnet build" in the terminal to compile the code.
6. Use "dotnet restore" in the Factory directory to install necessary packages.
7. Use "dotnet watch run" in the Factory directory to launch the project.

## Know bugs

Error when creating a 2nd treat with the same flavor as an existing treat.

## License

MIT License

Copyright (c) [2024] [Nikkita Torres]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.