# Exercises for ASP.Net

## Tutorials
### ASP.Net
https://www.youtube.com/watch?v=BfEjDD8mWYg&ab_channel=freeCodeCamp.org 
https://www.youtube.com/watch?v=pIz7VZDAubo&list=PLhPyEFL5u-i2ShGqmuP3uDdSy06hzBzdo&index=4&ab_channel=ProgrammingwithProfessorSluiter 

### REST API
https://www.youtube.com/watch?v=fmvcAzHpsk8&ab_channel=LesJackson 

## Packages
EntityFrameworkCore: https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/6.0.6 
EntityFrameworkCore.Design: https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/7.0.0-preview.5.22302.2  
EntityFrameworkCore.SqlServer: https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/7.0.0-preview.5.22302.2  
AutoMapper(DependencyInjection): https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection  
Dotnet ef Tool packages: dotnet tool install --global dotnet-ef  

## Models Views and Controllers(MVC)
* Model = Classes (objects)  
	* manages the behavior and data

* View = Web Page (Razor HTML) or combined with other front-end services (React, Angular, Vue)  
	* manages the display of data

* Controller = Connects models, business logic and web pages  
	* handles page events and navigation between pages


User -(orders)-> Router -(rotes[name, url]-> Controller -(Order List)-> Model -(get)-> Database  
Database ---> Model ---> Controller ---> View

## short cut
prop + 2x TAB: Generate a propoty  
ctor + 2x TAP: Generate a constructor 

## Database
| Data Access Object(DAO) | Object Relational Mapper(ORM) |
| :---   | :---   |
| Manually create tables | Allow the computer to generate database tables based on classes defined in the application |
| Traditional method of database access | Database is updated using migrations | 
| Write your own SQL statements | Entity Framework is Microsoft's ORM |
| Database managers(DBA's) ususally perfer DAOs | Simple for basic applications |
| Provides more visibility on finding problems |  |