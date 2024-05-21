# UKULAN


YtBookStore is a .NET application for managing a bookstore. This README provides instructions on how to set up and run the project.

Prerequisites
.NET SDK
SQL Server

# How to run it
1. clone the project
   git clone https://github.com/rd003/UKULAN-YsK.git](https://github.com/Yusufsertkaya/UKULAN-YsK.git
2. open `appsettings.json` file and update connection string's `data source=your server name`
   
   ``` {
  "ConnectionStrings": {
    "conn": "data source=your_server_name;initial catalog=UKULAN;integrated security=true;encrypt=false"
  }
}
```
4. Delete `Migrations` folder
5. Open Tools > Package Manager > Package manager console
6. Run these 2 commands
    ```
     (i) add-migration init
     (ii) update-database
     ````
7. Now you can run this project
   
dotnet run
