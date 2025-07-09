# HostelDormWebApp
# 🏠 HostelDormWebApp

A full-stack **ASP.NET-based Hostel Management System** designed to manage student registrations, room allocations, and administrative operations within a dormitory environment. This web application supports role-based access and provides an intuitive interface for hostel administrators.

---

## 🚀 Features

- ✅ Student Registration & Listing  
- ✅ Room Allocation and Room Status Management  
- ✅ Dashboard Overview  
- ✅ Student Data Update & Deletion  
- ✅ SQL Server Integration  
- ✅ Responsive UI with Bootstrap  
- ✅ Entity Framework for ORM  
- ✅ Clean and Modular Codebase

---

## 🛠️ Built With

| Tool/Technology | Purpose |
|------------------|---------|
| **ASP.NET (C#)** | Backend development |
| **Visual Studio** | Primary IDE |
| **SQL Server** | Database management |
| **Entity Framework** | ORM (Object-Relational Mapping) |
| **HTML/CSS/JavaScript** | Frontend design |
| **Bootstrap** | Responsive UI components |
| **GitHub** | Version control and collaboration |
| **Trello** | Agile task management and planning |

---

## 📂 Project Structure

HostelDormWebApp/
├── Controllers/ # C# Controllers (MVC)
├── Models/ # Entity classes and DB context
├── Views/ # Razor Views (Frontend)
├── wwwroot/ # Static files (CSS, JS, Bootstrap)
├── Migrations/ # Entity Framework DB Migrations
├── appsettings.json # Database config
├── Program.cs / Startup.cs
└── README.md

yaml
Copy
Edit

---

## 🧑‍💻 Getting Started

### Prerequisites
- Visual Studio 2019 or later
- SQL Server / SQL Server Express
- .NET SDK (5.0 or above)

### Steps to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/HostelDormWebApp.git
Open in Visual Studio

Update Database Connection
Edit appsettings.json to match your local SQL Server setup:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=HostelDormDB;Trusted_Connection=True;"
}
Apply Migrations
Run the following in Package Manager Console:

powershell
Copy
Edit
Update-Database
Build and Run the App

📸 Screenshots
(You can add screenshots here to show the UI and key features)

🧪 Future Improvements
Authentication and Role-Based Access

Email Notifications to Students

Admin Dashboard with Analytics

Search and Filter Options

📌 Project Management
Tasks and backlog were managed using Trello, following Agile methodology.

Code was version-controlled and regularly committed via GitHub.

CI/CD integration via GitHub Actions (optional future scope).

🤝 Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

📄 License
This project is licensed under the MIT License.

📬 Contact
For questions or support, feel free to reach out:

Developer: Your Name

Email: your.email@example.com

GitHub: your-username


