Create Database LoginDemoDB
Go
use LoginDemoDB

Create Table Users (
	Email nvarchar(100) PRIMARY KEY,
	[Password] nvarchar(20) NOT NULL,
	PhoneNumber nvarchar(20) NULL,
	BirthDate DATETIME NULL,
	[Status] int NULL,
	[Name] nvarchar(50) NOT NULL
)

Create Table Grades (
	TestId int PRIMARY KEY Identity(1,1),
	Email nvarchar(100),
	[Date] DATETIME NOT NULL,
	[Name] nvarchar(200)NOT NULL,
	Grade int NOT NULL,
	Constraint FK_EmailToGrade FOREIGN KEY (Email) References Users(Email)
)
Go

INSERT INTO dbo.Users VALUES ('talsi@talsi.com', '1234', '+972506665835','20-may-1976',1,'Tal Simon')
Go
INSERT INTO dbo.Grades VALUES ('talsi@talsi.com','4-june-2024','Bagrut-CSI', 73)
INSERT INTO dbo.Grades VALUES ('talsi@talsi.com','4-june-2024','Bagrut-Module-G', 85)
INSERT INTO dbo.Grades VALUES ('talsi@talsi.com','4-june-2024','Bagrut-Math-581', 67)

--scaffold-DbContext "Server = (localdb)\MSSQLLocalDB;Initial Catalog=LoginDemoDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models -Context LoginDemoDbContext -DataAnnotations -force