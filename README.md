##HollywoodbetsAPI

THe Hollywoodbet Sports Api is built using DotNet Core and uses Entity Framework Core as an ORM. The project handles the mapping of sports, countries, tournaments, events, 
bet types and their markets, finally it handles the oods for the specific markets which are different for every event.  The final process the project handles is the bet stricking.
The data brought back by the sport api is displayed and manipulated in a separate front end project which was done in Angular9.

##Project Structure

The project is structured in a Repository -- Service -- Controller way where each part is in a separate folder. The repositories handle everything related to the
database(CRUD), then the Service communicates with the controller action methods to handle the http requests.

##Table Structure
[
![Main Table Structure](https://user-images.githubusercontent.com/49978441/88566357-2e310f80-d036-11ea-9be8-c3bd0e37e5f5.png)
](url)






