# Contacts App Web API

This repository contains a .NET Web API for managing contacts. The API allows you to perform CRUD operations (Create, Read, Update, Delete) on contacts stored in a database.

## Project Structure

The project structure follows a typical ASP.NET Web API pattern, utilizing Entity Framework Core for database interaction.

- **Controllers:**
  - `ContactsController`: Manages CRUD operations for contacts.

- **Data:**
  - `ContactsAppDbContext`: Entity Framework DbContext for handling contact data.

- **Models:**
  - `Contact`: Represents a contact entity.

## API Endpoints

### 1. Get All Contacts

- **Endpoint:** `GET /api/Contacts`
- **Description:** Retrieve a list of all contacts.
- **Response:** Array of contacts.

### 2. Get Contact by ID

- **Endpoint:** `GET /api/Contacts/{id}`
- **Description:** Retrieve a specific contact by ID.
- **Response:** Single contact or NotFound if not found.

### 3. Update Contact

- **Endpoint:** `PUT /api/Contacts/{id}`
- **Description:** Update an existing contact.
- **Request Body:** JSON representing the updated contact.
- **Response:** NoContent on success, BadRequest if the ID in the route does not match the contact ID.

### 4. Create Contact

- **Endpoint:** `POST /api/Contacts`
- **Description:** Create a new contact.
- **Request Body:** JSON representing the new contact.
- **Response:** CreatedAtAction with the new contact details.

### 5. Delete Contact

- **Endpoint:** `DELETE /api/Contacts/{id}`
- **Description:** Delete a contact by ID.
- **Response:** NoContent on success, NotFound if the contact is not found.

## How to Run

1. Clone this repository.
2. Set up a SQL Server or another compatible database and update the connection string in `appsettings.json`.
3. Run the application using Visual Studio or `dotnet run`.
4. Test the API using a tool like [Postman](https://www.postman.com/) or [Swagger](https://swagger.io/).

## Docker Support

This project includes a Dockerfile to facilitate containerized deployment.

### Build Docker Image

To build the Docker image, run the following command in the project directory:

```bash
docker build -t contacts-app .
Once the Docker image is built, you can run a container using the following command:
docker run -p 8080:80 -d contacts-app

## Dependencies

- ASP.NET Core
- Entity Framework Core
- Microsoft.Extensions.DependencyInjection
- Microsoft.EntityFrameworkCore.SqlServer

Feel free to customize and extend this project based on your specific requirements. For any issues or improvements, please create an issue or submit a pull request.

Happy coding!
