# Dynamic Profile API

A simple RESTful API that returns developer profile information in a structured format.

---

## 🚀 Features

* ASP.NET Core 8 Web API
* Swagger UI for API testing
* Layered architecture (Controllers, Services)
* Well-structured API response body

---

## 🧱 Project Structure

```
src/
 ├── Controllers/
 │    ├── ProfileController.cs
 ├── Services/
 │    └── ProfileService.cs
 ├── Result/
 │    └── ApiResponse.cs
 ├── Models/
 │    └── Profile.cs
 └── Program.cs
```

---

## ⚙️ Setup Instructions

### 1️⃣ Clone the repository

```bash
git clone https://github.com/Nerdysolution012-dot/dynamic-profile.git
cd dynamic-profile
```

### 2️⃣ Install dependencies

Make sure you have the following installed:

* [.NET 8 SDK](https://dotnet.microsoft.com/download)
* Visual Studio or VS Code

Then restore packages:

```bash
dotnet restore
```

### 3️⃣ Run the application

```bash
dotnet run
```

The API will be available at:

```
https://localhost:7150
```

---

## 🧪 Testing the Endpoint

### Endpoint

**GET** `/api/me`

### Example Response:

```json
{
  "isSuccess": true,
  "data": {
    "email": "youremail@example.com",
    "name": "Your Full Name",
    "stack": "C# / ASP.NET Core"
  },
  "errors": []
}
```

### In case of error:

```json
{
  "isSuccess": false,
  "data": null,
  "errors": [
    { "code": "BadRequest", "description": "Invalid input" }
  ]
}
```
---
