# Animal Shelter API
#### _by Aaron Minnick_
### Technologies Used:
* C# / ASP .NET Core
* Entity Framework / LINQ
* Swagger

This is the week 6 independent project for the C# curriculum at [Epicodus](https://www.epicodus.com). The objective was to create an API with full CRUD functionality. 

## Swagger:
This project implements Swagger for automated documentation and interaction with the API. In order to view the Swagger documentation, navigate to **localhost:5000/swagger** after running the program.

(Presently, the home controller is also configured to automatically redirect any visit to **localhost:5000** to the swagger documentation URL.)

## Endpoints:

### /api/animals
>**GET: /api/animals**  
>Returns a list of all animals in the shelter.  

>**GET: /api/animals?species=dog&breed=labrador**  
>Optionally, species and breed parameters may be provided. The above will return a list of all animals in the shelter whose Species and Breed properties match the specified parameters.

>**POST: /api/animals**  
>Adds an animal to the shelter database. AnimalId will be assigned automatically upon creation, but name, species, and breed paramaters should be provided in the body of the request (see example below):
>```
>{
>  "Name" = "Fido",
>  "Species" = "dog",
>  "Breed" = "labrador"
>}
>```

&nbsp;
### /api/animals/{id}
>**GET: /api/animals/{id}**  
>Returns a specific animal, using the animal's AnimalId property.  
>*(Example: /api/animals/5 will return the animal with AnimalId == 5)*

>**PUT: /api/animals/{id}**  
>Edits the record for a specific animal in the database, determined by {id}. The AnimalId property must be provided in the body of your request, in addition to any properties being edited. The AnimalId must match the id in the URL for correct functionality (example):
>```
>{
>  "AnimalId" = 1,
>  "Name" = "Fidor",
>  "Breed" = "poodle"
>}
>```

>**DELETE: /api/animals/{id}**  
>Deletes a specific animal from the database, using the animal's AnimalId property.  

&nbsp;
### /api/animals/random
>**GET: /api/animals/random**  
>Returns a random animal from among all animals in the database.  

&nbsp;

---
## Setup Instructions:
_(Please note, the below instructions are using gitbash on a Windows computer. Commands may vary if you are using a different OS or terminal program.)_
* You will need [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).

* You will need to download and install [MySQL Community Server](https://dev.mysql.com/downloads/) and configure your local server to allow .NET's Entity Framework to construct the database.

* Clone this repository to your local repository (the link may be easily got using the green "Code" button on the github page):
```
$ git clone https://github.com/aaronminnick/AnimalShelterApi.Solution.git
```
* **Or** you may use the same button to download the files to your computer.

* Configure appsettings.json as described below.

* Use console commands to navigate to the main project folder and download dependencies:
```
$ cd AnimalShelterApi
$ dotnet restore
```
* Once your appsettings.json has been configured, use the following command to build the database:
```
$ dotnet ef database update
```
* Build and run the project:
```
$ dotnet build
$ dotnet run
```
* Using a web browser, navigate to **localhost:5000/**, which will redirect you to the swagger documentation automatically.

* **Or** you may use Postman or a similar application to send requests to the API endpoints detailed above.

### appsettings.json
In order for Entity Framework to construct your database correctly, you will need to create a file appsettings.json in the AnimalShelterApi project directory, with the following contents:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=aaron_minnick;uid=root;pwd=[YOUR PASSWORD HERE];"
  }
}
```
Be sure to replace the password value with your actual password. Depending on how you have configured your MySql server, you may need to make additional edits to properties in this file.  
&nbsp;

---
## Known Bugs/Issues:
n/a at this time

_Thanks for reading! Please feel free to contact me with feedback!_
***
#### [License: MIT](https://opensource.org/licenses/MIT)
#### Copyright (c) 2022 Aaron Minnick
