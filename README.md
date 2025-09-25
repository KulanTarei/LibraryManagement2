# Library Management System
A simple web-based Library Management System built with ASP.NET Core 8 MVC.  
This project uses only **in-memory collections** (no database needed) and provides a clean, Bootstrap-styled user interface for managing books, members, and borrowing operations.
---

## Features
- Add, edit, delete, and view books.
- Register, update, delete, and list library members.
- Borrow and return books, tracking borrowing history and available copies.
- UI built with Bootstrap for modern look and usability.
- All data handled in-memory—**nothing is stored after app restart** (excellent for quick demos and assignments).
---

## Getting Started
### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022+ or Visual Studio Code

### How to Run
1. **Clone or download the project.**
2. Open the solution or project folder in Visual Studio or VS Code.
3. Build the project.
4. Run the project (`dotnet run` or the green Play button in VS).
5. Open your browser at [http://localhost:5000](http://localhost:5000) or the specified URL in your terminal.
---

## Project Structure
- `Models/` - Entity classes: Book, Member, Borrowing
- `Controllers/` - MVC controllers for each entity, with full CRUD operations
- `Views/` - Razor pages for UI (Books, Members, Borrowings)
- `DataStore.cs` - In-memory static lists for all data
- `Program.cs` - App startup and minimal demo data seeding
- `Views/Shared/_Layout.cshtml` - Responsive Bootstrap page layout
---

## Usage
- Go to **Books** to add, edit, or delete books.
- Go to **Members** to add, edit, or delete members.
- Go to **Borrowings** to borrow or return books.
- All operations update live in the app until you quit. No installation or configuration of any database required.
---

## Screenshots
> <img width="960" height="494" alt="Screenshot 2025-09-25 174711" src="https://github.com/user-attachments/assets/2a98c94c-8fa1-466f-9c34-cf2056eba430" />
> <img width="960" height="379" alt="Screenshot 2025-09-25 174823" src="https://github.com/user-attachments/assets/67b50416-35ec-4179-8157-b294db104f18" />
> <img width="960" height="322" alt="Screenshot 2025-09-25 174849" src="https://github.com/user-attachments/assets/f71304b3-c13a-415f-8fa8-107fe7d292f5" />
> <img width="960" height="324" alt="Screenshot 2025-09-25 174605" src="https://github.com/user-attachments/assets/18b9aa7e-3605-4451-8f0b-6e453b04140b" />
> <img width="960" height="323" alt="Screenshot 2025-09-25 174620" src="https://github.com/user-attachments/assets/34ebdd68-1ebe-4a89-b9d4-6096af321c85" />
> <img width="960" height="386" alt="Screenshot 2025-09-25 174648" src="https://github.com/user-attachments/assets/8a60ffd5-348c-4729-8b57-8c10a95758a1" />
---

## Notes
- The data is **not persisted** when the app is stopped—refreshing or restarting clears all changes.
- Suitable as a base for learning, assignments, or prototyping with .NET MVC.
---

## Author
- [Kulan Tarei]
- Date: September 2025
---
