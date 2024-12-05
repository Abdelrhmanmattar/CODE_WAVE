--Day 4 - SQL
USE ITI;
--1//Select max two salaries in the instructor table.
SELECT DISTINCT TOP 2 SALARY
FROM Instructor
ORDER BY Salary DESC;


--2//Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
with rank_salary as
(
SELECT SALARY , ROW_NUMBER() OVER (partition by Dept_Id order by salary desc) AS Num,Dept_Id
FROM Instructor
)
SELECT SALARY ,Num , Dept_Id
FROM rank_salary
where Num<=2 and Salary is not null;


--3//write a query to select a random student from each department. “using one of Ranking Functions
with Ran_Stu as
(
	select CONCAT(S.St_Fname , ' ' , S.St_Lname) AS FULL_NAME 
	, S.Dept_Id
	, ROW_NUMBER() OVER (PARTITION BY S.Dept_Id order by NEWID()) AS R_Num
	from Student AS S
)
SELECT FULL_NAME , Dept_Id 
FROM Ran_Stu
WHERE R_Num=1;

--4//4.Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
SELECT * FROM GetValuesBetween(1,5);


--5. Create a table-valued function that takes Student No and returns Department Name with Student full name.
SELECT * FROM GET_STUDENT(1);
--6 function an integer which represents the format of the Manager hiring date
--and displays department name, Manager Name and hiring date with this format
SELECT * FROM GetFormattedManagerDetails(23);

