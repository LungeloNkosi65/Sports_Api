# Hollywoodbet Sports Api

THe Hollywoodbet Sports Api is built using DotNet Core and uses Entity Framework Core as an ORM. The project handles the mapping of sports, countries, tournaments, events, 
bet types and their markets, finally it handles the oods for the specific markets which are different for every event.  The final process the project handles is the bet stricking.
The data brought back by the sport api is displayed and manipulated in a separate front end project which was done in Angular9.

# Project Structure

The project is structured in a Models -- Repository -- Service -- Controller parten where each part is in a separate folder. The repositories handle everything related to the
database(CRUD), then the Service communicates with the controller action methods to handle the http requests.



# Project Flow

The site reads from the api and then the api gets the data from the database. The admin site does the crud for the database and it reflects on the main bet stricking site.

# Hollywoodbets Site Repo Link
https://github.com/LungeloNkosi65/HollywoodRep.git

![Events1](https://user-images.githubusercontent.com/49978441/88652171-bfea5c80-d0ca-11ea-95e3-8f34e20bd4bd.png)

# Sport Admin Repo Link
https://github.com/LungeloNkosi65/SportAdmin-Front.git
![Sport Admin](https://user-images.githubusercontent.com/49978441/88652321-f32ceb80-d0ca-11ea-828a-a391c02e0aff.png)
![Sport Admin-Add](https://user-images.githubusercontent.com/49978441/88652326-f45e1880-d0ca-11ea-9983-45da71267a1c.png)


# Table Structure


![New Table Structure](https://user-images.githubusercontent.com/49978441/88653736-beba2f00-d0cc-11ea-8a35-62daaff14e28.png)


# Flow Diagram

![Anotation-Diagram](https://user-images.githubusercontent.com/49978441/88676155-08fed880-d0ec-11ea-844c-0e9785bb3d09.png)










