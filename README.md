# assignemt1_vishnuHari


# Web API Project

This project is a simple web API built with ASP.NET Core. It includes multiple endpoints for performing various operations such as adding ten to a number, squaring a number, generating greetings, applying mathematical operations, and calculating hosting costs. Below are the details of each endpoint.

## Prerequisites

- .NET 6 SDK or later

## Building and Running the Application

1. Clone the repository or download the source code.
2. Navigate to the project directory.
3. Build the project using the following command:
   ```sh
   dotnet build
   ```
4. Run the project using the following command:
   ```sh
   dotnet run
   ```

The application will start and listen for HTTP requests.

## Endpoints

### 1. AddTen

**Description:** Adds ten to the given integer.

- **URL:** `/api/AddTen/{id:int}`
- **Method:** GET
- **Parameters:**
  - `id` (int): The input integer.
- **Response:** The input integer plus ten.

**Example:**
```
GET /api/AddTen/21
Response: 31
```

### 2. Square

**Description:** Returns the square of the given integer.

- **URL:** `/api/Square/{id:int}`
- **Method:** GET
- **Parameters:**
  - `id` (int): The input integer.
- **Response:** The square of the input integer.

**Example:**
```
GET /api/Square/2
Response: 4
```

### 3. Greeting

**Description:** Returns a "Hello World!" message.

- **URL:** `/api/Greeting`
- **Method:** POST
- **Parameters:** None
- **Response:** "Hello World!"
**Will need postman to run this**
**Example:**
```
POST /api/Greeting
Response: "Hello World!"
```

### 4. Greeting with ID

**Description:** Returns a greeting message with the given integer.

- **URL:** `/api/Greeting/{id:int}`
- **Method:** GET
- **Parameters:**
  - `id` (int): The input integer.
- **Response:** A greeting message indicating the number of people.

**Example:**
```
GET /api/Greeting/3
Response: "Greetings to 3 people!"
```

### 5. NumberMachine

**Description:** Applies four mathematical operations to the given integer.

- **URL:** `/api/NumberMachine/{id:int}`
- **Method:** GET
- **Parameters:**
  - `id` (int): The input integer.
- **Response:** The result of applying the operations.

**Operations:**
1. Add 5
2. Multiply by 2
3. Divide by 3
4. Subtract 7

**Example:**
```
GET /api/NumberMachine/10
Response: 3
```

### 6. HostingCost

**Description:** Calculates the hosting cost based on the number of days.

- **URL:** `/api/HostingCost/{id:int}`
- **Method:** GET
- **Parameters:**
  - `id` (int): The number of days.
- **Response:** An array of strings describing the hosting cost, HST, and total cost.

**Example:**
```
GET /api/HostingCost/0
Response:
[
    "1 fortnights at $5.50/FN = $5.50 CAD",
    "HST 13% = $0.72 CAD",
    "Total = $6.22 CAD"
]
```

## Conclusion

