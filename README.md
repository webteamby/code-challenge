# code-challenge

# Frame of Project

This project is made in Visual Studio 2019 as new project based based on 'ASP.Net WebAPI 2' template.
Using .Net Framawork 4.7.1
https://marketplace.visualstudio.com/items?itemName=sergey-tregub.asp-net-web-api-owin-template

# Data Base

Using LiteDB. From nugget-package manager.

Before start App you should specify path to "MyLiteDb.db" in Web.config file.

<add key="LiteDb.Path" value="D:\Projects\_git\my\other\code-challenge-webteamby\MyLiteDb.db"/>

Indexes are added to 'Industry' and 'Region' fields to have fast search by that conditions


# Exceptions handling

Implemented via global request filter.

# Documenting API

API documentation could be got at address http://localhost:5000/swagger/ui/index
