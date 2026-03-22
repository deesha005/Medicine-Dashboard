# 💊 Medicine Inventory Dashboard

A **Windows Forms** desktop application built with **C#** and **SQL Server** for managing medicine inventory. This dashboard provides a simple and clean interface to manage medicines, handle billing, manage carts, and search products — all connected to a local SQL Server database.

---

## 🖥️ Tech Stack

| Technology | Details |
|------------|---------|
| Language | C# (.NET Framework) |
| UI Framework | Windows Forms (WinForms) |
| Database | SQL Server Express |
| IDE | Visual Studio 2022 |
| Connectivity | ADO.NET (SqlConnection) |

---

## ✨ Features

| Module | Features |
|--------|---------|
| 💊 **Add Medicine** | Add new medicines and view/manage existing stock |
| 🔍 **Search Medicine** | Search products by name instantly |
| 🛒 **Medicine Cart** | Add medicines to cart and view cart contents |
| 🧾 **Billing** | Add bills and view complete client billing history |

---

## 🖼️ Application Preview

### Main Dashboard
> The dashboard provides quick access to all modules — Add Medicine, Search Medicine, Medicine Cart, and Billing.

```
┌─────────────────────────────────────────┐
│          Medicine Dashboard             │
│                                         │
│  Add Medicine      Search Medicine      │
│  [ Add Medicine ]  [ Search Product ]   │
│  [ Show       ]    [ Search ]           │
│  [ Medicine   ]                         │
│                                         │
│  Medicine Cart     Billing              │
│  [ Add to Cart ]   [ Add Bill ]         │
│  [ Show Cart  ]    [ Client History ]   │
└─────────────────────────────────────────┘
```

---

## ⚙️ Setup & Installation

### Prerequisites
- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/)
- SQL Server Express (already installed on your machine as `DEESHA\SQLEXPRESS`)
- .NET Framework 4.7.2 or higher

---

### Step 1: Clone the Repository

```bash
git clone https://github.com/deesha005/Medicine-Inventory-Dashboard.git
cd Medicine-Inventory-Dashboard
```

---

### Step 2: Set Up the Database

Open **SQL Server Management Studio (SSMS)** and run:

```sql
-- Create Database
CREATE DATABASE workspace;
USE workspace;

-- Medicines Table
CREATE TABLE Medicines (
    MedicineID    INT PRIMARY KEY IDENTITY(1,1),
    Name          VARCHAR(100) NOT NULL,
    Category      VARCHAR(50),
    Quantity      INT NOT NULL,
    Price         DECIMAL(10, 2),
    ExpiryDate    DATE,
    Supplier      VARCHAR(100),
    AddedOn       DATETIME DEFAULT GETDATE()
);

-- Cart Table
CREATE TABLE Cart (
    CartID        INT PRIMARY KEY IDENTITY(1,1),
    MedicineID    INT FOREIGN KEY REFERENCES Medicines(MedicineID),
    Quantity      INT,
    AddedOn       DATETIME DEFAULT GETDATE()
);

-- Billing Table
CREATE TABLE Billing (
    BillID        INT PRIMARY KEY IDENTITY(1,1),
    ClientName    VARCHAR(100),
    MedicineID    INT FOREIGN KEY REFERENCES Medicines(MedicineID),
    Quantity      INT,
    TotalAmount   DECIMAL(10, 2),
    BillDate      DATETIME DEFAULT GETDATE()
);
```

---

### Step 3: Connection String

The database connection used in this project:

```csharp
String ConnectionString = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Trusted_Connection=true";
```

> This uses **Windows Authentication** (`Trusted_Connection=true`) so no username/password is needed.
> If you're running this on a different machine, replace `DEESHA` with your **computer name** or use `localhost\\SQLEXPRESS`.

---

### Step 4: Open & Run

1. Open `Medicine-Inventory-Dashboard.sln` in **Visual Studio**
2. Build: **Ctrl + Shift + B**
3. Run: **F5**

---

## 🔌 Database Connection Code

```csharp
using System.Data.SqlClient;

public class DBConnection
{
    public static SqlConnection GetConnection()
    {
        String ConnectionString = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Trusted_Connection=true";
        return new SqlConnection(ConnectionString);
    }
}
```

### Example — Fetch Medicines:

```csharp
private void LoadMedicines()
{
    SqlConnection con = DBConnection.GetConnection();
    SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines", con);
    con.Open();
    SqlDataReader reader = cmd.ExecuteReader();
    DataTable dt = new DataTable();
    dt.Load(reader);
    dataGridView1.DataSource = dt;
    con.Close();
}
```

---

## 🗂️ Project Structure

```
Medicine-Inventory-Dashboard/
│
├── Forms/
│   ├── Form1.cs              # Main Dashboard
│   ├── AddMedicine.cs        # Add / Show Medicine
│   ├── SearchMedicine.cs     # Search Product
│   ├── Cart.cs               # Add to Cart / Show Cart
│   └── Billing.cs            # Add Bill / Client History
│
├── DBConnection.cs           # SQL Connection Handler
├── App.config                # App configuration
├── Medicine-Inventory-Dashboard.sln
└── README.md
```

---

## 🚀 Future Enhancements

- [ ] Login page with Admin / Staff roles
- [ ] Low stock alerts and expiry notifications
- [ ] PDF bill generation
- [ ] Dashboard with stock statistics and charts
- [ ] Search filter by category or expiry date

---

## 👨‍💻 Author

**Deesha**
- GitHub: [@deesha005](https://github.com/deesha005)

---

## 📄 License

This project is licensed under the **MIT License** — free to use and modify.

---

> ⭐ If you found this project helpful, give it a star on GitHub!
