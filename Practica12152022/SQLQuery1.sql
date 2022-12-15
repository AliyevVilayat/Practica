CREATE TABLE Employee(

Id int PRIMARY KEY IDENTITY,
Name nvarchar(50) NOT NULL,
Surname nvarchar(50) NOT NULL,
Salary float NOT NULL
)

INSERT INTO Employee
VALUES('Vilayat','Aliyev',99999)

SELECT * FROM Employee
