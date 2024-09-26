# GymMe - Supplement Selling Application
- GymMe is a web-based online health and supplement selling application. This project is an assignment to build a simplified version of the application **Back-End** using ASP.NET with Domain Driven Design (DDD) principles.
- Tech Stack : C#, and .NET

###  Layers of the Application
The project is divided into several layers, each with specific responsibilities:

1. View Layer
This layer is responsible for presenting data to the user and receiving user inputs. It handles all the User Interface (UI) elements and renders the necessary pages.

2. Controller Layer
The controller serves as the intermediary between the View and the lower layers. It validates inputs from the view, processes user requests, and delegates them to the appropriate handler.

3. Handler Layer
The business logic resides in the handler layer. This layer processes the application's core functionalities, such as managing supplements or orders. It delegates data manipulation tasks (like select, insert, update, delete) to the repository layer.

4. Repository Layer
The repository layer handles all database operations. It provides public interfaces to access, query, and manipulate data in the database. This layer ensures domain objects are retrieved and manipulated in a controlled and structured way.

5. Factory Layer
The factory encapsulates the creation of complex objects, ensuring that aggregate objects (objects containing other objects) are instantiated in a consistent state.

6. Model Layer
The model layer represents business concepts and situations. This layer is implemented using Entity Framework to manage the relationships between different domain objects and map them to the database.
