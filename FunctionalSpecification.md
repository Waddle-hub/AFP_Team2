## Describing the current situation
We, as a team setting up our environment to startup our group project with the following developing members:
1. Sabri Said
2. Szenczi Boldizsar
3. Wan Shiyi
4. Yuldashov Rasul
5. Friedrichs Wade David
6. Silabela Mxolisi

We have agreed to develop a cashier application for a store for the purpose of bookkeeping and money management. The application will have a simple login as well as point of sale screen. Currently we are working on documentation which is an integral part of our application. This will give us ideas so that we will have a better understanding when it comes to implementation of our project. The application will be used by store clerks in order to keep better track of inventory and help the owners manage their stores in a simple way. 

## UI Plan

The interface will be a not so complicated one, a simple login screen only and a dashboard that will have buttons such as; add item, remove item, produce slip, etc. No database will be used since this is a small project, everything will be hardcoded into the project. With this simple design we aim to provide an easy interface that doesnt require much training leaving less stress on the owners to train new employees. 

## Use Cases

In order for the user to be able to use the system they must login first. After loging in using a user id as well as password then they will see the dashboard.

* Only Admin can add/remove users.
* The login screen will only show the ID label as well as password label.
* The dashboard will have text areas as well as buttons.
* Users may logout using the button at the top corner.
* Users may add and remove items from till slips
* Users may produce till slips.


## How the system should be and what it should not be  ?__

The system should be as simple as we can make it so that the user can easily use it,otherwise,it shouldn't be broken at any point,always working properly(maintenance) which means we should maintain our application to work properly and if any error shows up we have to catch it(for example : try,catch exception).

Data requirements must be accurate, reliable and true. When you make an action request, such as finding, deleting, modifying, and adding, you should ensure that the input data matches the database data. When meeting the user's request, the system should ensure that the data in response to the inspection rate and accuracy rate.

Time characteristics. 
In order to meet the user's efficient requirements, the response time of the data, the update processing time, the data conversion and transmission time, the running time should be within 1-5 seconds. When you need to interact with an external device, such as a printer, the response time may be long, but it should be within acceptable limits.

======

## Constrains__ :
Design Constraints imposes limitations on the following things:
* The running environment : Microsoft Visual Studio.
* The operating system : Microsoft Windows 10.
* the programming language, databases;
* coding standards;
* business logic, etc.
The application should have methods and function that can do all the operations needed like deleting or adding items, updating...etc also,it should have generic classes and methods.

As per said in the requirement specification, the software must oblige the new requlations in the EU, namely GDPR. This means whatever data we collect from the user, must be treated with the upmost care. Also the user MUST explicitly accept the collection and use of his/her data.

