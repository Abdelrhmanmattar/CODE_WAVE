--Day 3 - SQL
USE ITI;
ALTER TABLE Instructor
ADD Bonus int;

--Part 01: Insert New Data

--INSERT Student
INSERT INTO Student (St_Id, St_Fname, St_Lname, St_Address, St_Age, Dept_Id, St_super)
VALUES 
(101, 'Ahmed', 'Ali', 'EGYPT', 20, 10, 1),
(102, 'Sara', 'Hassan', 'EGYPT', 22, 20,6);


--INSERT Instructor
INSERT INTO Instructor (Ins_Id, Ins_Name, Ins_Degree, Salary, Dept_Id, Bonus)
VALUES 
(201, 'Mahmoud Khalid', 'PhD', 7000, 10, 500),
(202, 'Fatima Zaki', 'Mastar', 7500, 20, 600);


--INSERT Course
INSERT INTO Course (Crs_Id, Crs_Name, Crs_Duration, Top_Id)
VALUES 
(301, 'Database', 15, 101),
(302, 'Networks', 12, 102);


--Part 02: Data Manipulation Language
--1//nsert a new student into the Students table with your personal data, assigning the student to department number 20.
INSERT INTO Student (St_Id, St_Fname, St_Lname, St_Address, St_Age, Dept_Id, St_super)
VALUES 
(105, 'ABDELRHMAN', 'KAMAL', 'EGYPT', 22, 20, 6);

--2//Insert a new instructor into the Instructors,assigning department number 20,salary to 4500,bonus column empty.

INSERT INTO Instructor (Ins_Id, Ins_Name, Ins_Degree, Salary, Dept_Id)
VALUES 
(205, 'ALI ESSAM', 'PhD', 4500, 20);

--3//Increase the salary of all instructors by 15% of their current values.
update Instructor set Salary*=1.15;

--4//Update the name of a specific course in the Courses table to "Code Wave".
update Course 
set Crs_Name = 'Code Wave'
where Crs_Id=100;
