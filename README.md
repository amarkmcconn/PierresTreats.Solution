# 🍬💊🧁Pierre's Sweet and Savory Treats🧁💊🍬

## By Mark McConnell 👨

### _This is an MVC application with user authentication and a many-to-many relationship between flavors and treats._

## Technologies Used 💻

* _C#_
* _.Net 5.0_
* _HTML_
* _CSS_
* _Git_
* _VsCode_
* _EntityFrameWork_
* _REPL_
* _MySQL WorkBench_

## Description ✅

_This is an MVC application with user authentication and a many-to-many relationship between flavors and treats. Here are some of the features of this application:_

* The application has user authentication
* A user will be able to log in and log out
* Only logged in users has create, update and delete functionality
* All users have read functionality.
* There is a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
* A user will be able to navigate to a splash page that lists all treats and flavors. Users will be able to click on an individual treat or flavor to see all the treats/flavors that belong to it

![Alt text](/PierresTreats/wwwroot/img/Picture3.png)

## Setup/Installation Requirements 🖊️

* _Clone this repo: <https://github.com/amarkmcconn/PierresTreats.Solution>_
* _Enter the new directory using the command ```cd PierresTreats.Solution```_
* _In the root directory, confirm there is a .gitignore file_
* _Add:_

```js
*/obj,
*/bin
*.vscode
*/appsettings.json
```

* _to the .gitignore file. It will keep your repository clean of unnecessary files and protect your database from unauthorized access_
* _Create an appsetting.json file at the root directory_
* _Open the appsetting.json file and enter:_

```js
{ 
  "ConnectionStrings": { 
    "DefaultConnection": "Server=localhost;Port=3306;database=[Database-Name];uid=root;pwd=[Your-Password];" 
  } 
}
```

* _Run ```git add .gitignore```_
* _Commit your changes_
* _To ensure the project will run correctly,_
* _Download MySQL WorkBench_
* _Run ```dotnet tool install --global dotnet-ef --version 5.0.1``` at a global level_
* _Run the following from the project directory of ```PierresTreats```_
* _Run ```dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0```_
* _Run ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2```_
* _Run ```dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0```_
* _Run ```dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0```_
* _Once all of the necessary setup is in place and we can successfully run dotnet build_
* _Run ```dotnet restore``` and ```dotnet build``` from the PierresTreats directory_
* _Run ```dotnet ef migrations add Initial``` from the PierresTreats Directory_
* _Once we have verified that the migration looks correct and made any necessary changes, we'll run the following command: ```dotnet ef database update```_
* _To interact with the local host website navigate to the University directory and run ```dotnet run```_
* _Click on  <http://localhost:5000>_

## Known Bugs 🐛

* _No Known Issues_

## License 🧾

[MIT](LICENSE) 👈

_If you run into any issues or have questions, ideas, or concerns;  please email me: at mark.programming1@gmail.com or make a contribution to the code._

Copyright (c) 2022 Mark McConnell
