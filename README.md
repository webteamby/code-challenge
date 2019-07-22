# code-challenge

# Frame of Project

This project is made in Visual Studio 2019 as new project based based on 'ASP.Net WebAPI 2' template.
Using .Net Framawork 4.7.1
https://marketplace.visualstudio.com/items?itemName=sergey-tregub.asp-net-web-api-owin-template

# Data Base

Using LiteDB. From nugget-package manager.

Before start App you should specify path to "MyLiteDb.db" in Web.config file.

<add key="LiteDb.Path" value="D:\Projects\_git\my\other\code-challenge-webteamby\MyLiteDb.db"/>

Schema of DB

```
 {
    "email": "my Test@myemail.com",
    "firstName": "Vasya 2",
    "lastName": "Pupkin",
    "bio": "My name is",
    "phoneNumber": "+3752734596",
    "region": "Minsk",
    "industry": "TractorIT",
    "educations": [
      {
        "schoolName": "School",
        "schoolStartYear": 1997,
        "schoolEndYear": 2001
      },
      {
        "schoolName": "Univer",
        "schoolStartYear": 2001,
        "schoolEndYear": 2010
      }
    ],
    "workExperiences": [
      {
        "jobTitle": "Dev",
        "company": "Gik",
        "jobStartYear": 2018,
        "jobEndYear": 2019
      }
    ],
    "facebook": "My facebook",
    "twitter": "Twitter",
    "blog": "blogpost.com",
    "id": 4
  },
```  

NOTE: Indexes are added to 'Industry' and 'Region' fields to have fast search by that conditions


# Exceptions handling

Implemented via global request filter.

# Documenting API

API documentation could be got at address http://localhost:5000/swagger/ui/index
