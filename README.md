# Student Management Web API in Dotnet

## Swagger
![image](https://github.com/satyapsr13/StudentManagement_API_Dotnet/assets/73766765/eba2f83a-0969-4859-9830-fba17ebe354a)

## Visual Studio
![image](https://github.com/satyapsr13/StudentManagement_API_Dotnet/assets/73766765/9d4982bd-8c71-4e10-8ae7-f231de3e8245)

# Student Management API Documentation

This documentation provides a guide on how to use the Student Management API in .NET, which allows you to perform CRUD operations on student data stored in MongoDB.

## Prerequisites

Before using the API, make sure you have the following:

1. Install [.NET Core](https://dotnet.microsoft.com/download) on your machine.
2. Install [MongoDB](https://www.mongodb.com/) on your machine or connect to a remote MongoDB instance.

## Getting Started

1. Clone or download the project from the repository.

2. Open the terminal or command prompt, navigate to the project folder, and restore the dependencies by running the following command:

   ```shell
   dotnet restore
   ```

3. Modify the `appsettings.json` file in the project to specify the MongoDB connection details:

   ```json
   {
      "ConnectionStrings": {
         "MongoDb": "mongodb://localhost:27017",
         "DatabaseName": "StudentManagementDB"
      }
   }
   ```

4. Run the application using the following command:

   ```shell
   dotnet run
   ```

5. The API will be accessible at `http://localhost:5000`.

## API Endpoints

### Create a Student

**Request**

- Method: POST
- Endpoint: `/api/students`
- Content-Type: application/json

```json
{
   "name": "John Doe",
   "age": 20,
   "grade": "A"
}
```

**Response**

- Status: 201 Created
- Content-Type: application/json

```json
{
   "id": "1234567890",
   "name": "John Doe",
   "age": 20,
   "grade": "A"
}
```

### Get a Student by ID

**Request**

- Method: GET
- Endpoint: `/api/students/{id}`

**Response**

- Status: 200 OK
- Content-Type: application/json

```json
{
   "id": "1234567890",
   "name": "John Doe",
   "age": 20,
   "grade": "A"
}
```

### Update a Student

**Request**

- Method: PUT
- Endpoint: `/api/students/{id}`
- Content-Type: application/json

```json
{
   "name": "Jane Doe",
   "age": 21,
   "grade": "A+"
}
```

**Response**

- Status: 200 OK
- Content-Type: application/json

```json
{
   "id": "1234567890",
   "name": "Jane Doe",
   "age": 21,
   "grade": "A+"
}
```

### Delete a Student

**Request**

- Method: DELETE
- Endpoint: `/api/students/{id}`

**Response**

- Status: 204 No Content

### Get All Students

**Request**

- Method: GET
- Endpoint: `/api/students`

**Response**

- Status: 200 OK
- Content-Type: application/json

```json
[
   {
      "id": "1234567890",
      "name": "John Doe",
      "age": 20,
      "grade": "A"
   },
   {
      "id": "0987654321",
      "name": "Jane Doe",
      "age": 21,
      "grade": "A+"
   }
]
```

## Error Handling

In case of any error, the API will return an appropriate HTTP status code along with a JSON response containing an error message.

## Conclusion

This documentation provides guidelines on using the Student Management API in .NET to perform CRUD operations on student data in MongoDB. Use the provided endpoints to create, update, delete, and retrieve student records. Feel free to customize the code to fit your specific needs and further enhance the functionalities if required.


