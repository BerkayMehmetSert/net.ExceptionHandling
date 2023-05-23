# Net Exception Handling Example

This project demonstrates how to handle custom exceptions in an API. The API provides endpoints for managing product data. The project includes a controller called `ProductController`, which contains the following endpoints:

## Endpoints

`GET api/Product/success`

This endpoint is used to retrieve products successfully. When a request is made, the list of products returned from the **GetProducts** method is returned with a `200 OK` status code.

`GET api/Product/business-error`

This endpoint is used to test a business rule exception. When a request is made, if the number of products is greater than zero, it returns a **400 Bad Request** status code with the error message "`Too many products`". Otherwise, the list of products returned from the GetProducts method is returned with a `200 OK` status code.

`GET api/Product/not-found-error`

This endpoint is used to test a not found exception. When a request is made, if the number of products is greater than zero, it returns a **404 Not Found** status code with the error message "`Too many products`". Otherwise, the list of products returned from the GetProducts method is returned with a `200 OK` status code.

### Exception Handling

Exceptions are handled by the `ExceptionHandler` class. This class is designed as an abstract class to handle different types of custom exceptions, such as `BusinessException` and `NotFoundException`. It provides separate handling methods for each exception type. There is also a default handling method for any other exceptions.

The `HttpExceptionHandler` class implements the `ExceptionHandler` class and is used to generate HTTP responses. It creates a `ProblemDetails` object based on the relevant status code and exception details. This object is then serialized to JSON and returned as the response.