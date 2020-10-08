Requirement specification
========
## Introduction
1. Project name
2. Purpose
3. Intended audience
4. User needs 
5. Project outline 
6. current situation 
7. Goal  
8. Glossary
9. other requirements

__Project name__
the project name is the cashier machine: 

![cashier machine](images/cashier.jpg)

__purpose__

The purpose of this document is to build a cashier machine for store that reduces the cost of bookkeeping and labor, simplify the processing and flow of large amounts of information,easy to manage transaction and products.
The cashier machine actually can do a lot of stuff for the user(saleman) : 
* Fast Checkouts. Cash registers will ensure that the checkout stage of your business is as fast and seamless as possible. ...
* Increase Security. Cash registers can improve the security on your shop floor.The cash drawers will be securely locked until a successful sales transaction is put through.
* Multiple Payment Options.you will need to be able to accept all the payment options(card,cash).
* Audit Reports : Cash registers will record detailed information about each sales transaction.

__Intended audience__

This is aimed at the store staff,people who often need to collect money and give back changes,and also,this project can be accessed by developers, project managers, testers, sales and marketing people or stakeholders in other departments. Our main targets are store owners who wish to find a simpler way of getting stock out their doors while also keeping track of how much of said stock left thier doors, it serves to keep track of invetory while making it easier to leave the store.

__User needs__

* Users need a simple UI to get their work done efficiently and quickly
* Users need to be able to log in to protect the assets of the owner(If someone were to remove stock from the system, it could be stolen so we need verification).
* Owners need to able to remove and add employees so that they may manage their workforce.
* Employees need to be able to add and remove items from a cart.
* Employees need to be able to manage stock.

__Project outline__

The project is a simple windows form application which serves the purpose to manage a small inventory of stock. there shall be 3 forms, one for logging in. one for all the employees functionality and another for adding and removing employees. The project shall be a small representation of what a real world teller machine is. Therefore we are going to be using classes and inhertiance to make use of the junior developers knowledge and allowing them to contribute alot to the projects development. by using classes we can divide the work into neat bundles of code which offer alot of functionality while stil being very readable. Having a class for "Items" having tostring methods which can be printed on the till slip for example. simple functionality that will make code neater throughout the entire project. All and all the project is a very simple one, adding and removing items from a list of objects which we will define. having a concrete group of items called "Stock" which we will check if theres anything left and if there is remove one from stock and add one onto the till slip. 

__current situation__

As the world gets more and more efficent technology needs to move along with it, and so we have the idea to create a simple fast teller machine, which will help managers keep check of stock and help employees move products out of the door. the most tedious part of going to the store is the checkout, so we whish to make it simpler. we have a team of 6 who will help us in developing this application. 

__Goal__

One of the goal is to know how to be a part of a team in the software industry, through some controlling tools like git, GitHub, and gitLab, also to get to use the task manager websites like Trello.com, and spread the tasks for each member of the team. But our main goal is to make the life of both the store owner and employee easier with an application which is easy to use and easy to train employees with. Our hopes is to streamline the checkout process with this software which can help out our employees.

__Glossary__

 * C# : is a general-purpose, procedural computer programming language supporting structured programming.
 * Mysql : s an open-source relational database management system.

__other requirements__

in this project we will be mainly working on these things : 
* Performance : how the app reacts to the user’s requests.
* Safety.
* Security :  the way the app protects information.
* Quality.
* Availability : how the app operates and functions.
