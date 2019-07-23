# Project

Store user profile data in locally nosql db. Allow the users to store in their profiles as many educations and working experiences as they would like.
Provide API to manipulate user data.

# Technical Stuff
This project is made in Visual Studio 2019 as new project based based on 'ASP.Net WebAPI 2' template (https://marketplace.visualstudio.com/items?itemName=sergey-tregub.asp-net-web-api-owin-template).

Using .Net Framawork 4.7.1

# Set up and run
- Dowload project from repo.
- Specify path to "MyLiteDb.db" in Web.config file. <add key="LiteDb.Path" value="D:\Projects\_git\my\other\code-challenge-webteamby\MyLiteDb.db"/>. You could find this file in the root of project folder.
- Restore nugetpackages.
- Build and run 'BsvService.Api'

# Data Base
Database is a locally embedded NoSQL database - LiteDB (https://www.litedb.org/)

### DB schema design:

```
  {
    id: int                  <------------------------ default index
  
    Email: string,
    FirstName: string,
    LastName: string,
    Bio: string,
    PhoneNumber: string,
    Region: string,          <------------------------ make additional index
    Industry: string,        <------------------------ make additional index
    Educations(Array):[
      {
        SchoolName: string,
        SchoolStartYear: int,
        SchoolEndYear: int
      }
	  ...
      {
        SchoolName: string,
        SchoolStartYear: int,
        SchoolEndYear: int
      }
    ],
    WorkExperiences(Array): [
      {
        JobTitle: string,
        Company: string,
        JobStartYear: int,
        JobEndYear: int
      }
	  ...
      {
        JobTitle: string,
        Company: string,
        JobStartYear: int,
        JobEndYear: int
      }
    ],
    Facebook: string,
    Twitter: string,
    Blog: string,
  }
```  
IMPORTANT: For 'Education' and 'WorkExperience' fields we are using collections to allow the users to store as many  educations and working experiences as they would like. So this kind of design is scaleable

IMPORTANT: Indexes are added to 'Industry' and 'Region' fields to have fast search by that conditions


# Exceptions handling

Implemented via global request filter.

# Documenting API

API documentation could be got at address http://localhost:5000/swagger/ui/index

# Unit Tests
 Included
