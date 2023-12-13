# University Registrar

#### By Aidan Williams

## Technologies Used

* _C#_
* _.NET_

## Description

A web app for keeping track of courses and students at a university.

## Setup Instructions

1. Clone this repo.
1. Open MYSQL Workbench and connect to your local server.
1. Select Server > Data Import in your toolbar.
1. Select 'Import from Self-Contained File' under Import Options and select the .sql file located in this repo's directory.
1. Select 'Start Import' under the Import Progress tab.
1. Navigate to this project's production directory.
    1. Create a file called "appsettings.json"
    1. Add the following code to the file (username and password credentials are for your local server):
    
        `{
          "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
          }
        }`
1. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory.
1. Run `dotnet run` in the command line.
1. Visit https://localhost:5001/ in your web browser.
1. Optionally, you can run `dotnet build` to compile this website without running a local server.

## Known Bugs

* _No known bugs._

## License

_[GPL](https://en.wikipedia.org/wiki/GNU_General_Public_License)_

Copyright (c) _2023_ _Aidan Williams_