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
 
    
<img width="958" alt="Admin Dashboard" src="https://github.com/user-attachments/assets/77673380-9850-490b-9733-fe09f99f32ea" />
<img width="944" alt="My Bookings Page" src="https://github.com/user-attachments/assets/ac261005-1bf7-4205-ae18-03b0010bddca" />
<img width="951" alt="Book Room Page" src="https://github.com/user-attachments/assets/b18ceace-7527-4880-ad1d-0ba4c998602b" />
<img width="952" alt="Manage Rooms Page( CRUD functionalities) 2" src="https://github.com/user-attachments/assets/5eb067a2-c73f-4152-b97c-07c6fc66ea2d" />
<img width="959" alt="Login Page" src="https://github.com/user-attachments/assets/f16b2d63-4f69-43cc-a7f4-f7c8e9531b14" />
<img width="940" alt="Registration Page" src="https://github.com/user-attachments/assets/973da8d8-850a-4922-b65f-9de216f149ec" />
<img width="946" alt="Homepage of Project" src="https://github.com/user-attachments/assets/88d95cca-364d-48e9-b5ae-a8d6106c0db7" />


  
    
 

 


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


