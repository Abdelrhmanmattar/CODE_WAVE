--Day 5- Sql--Create a view that displays the student's full name, course name if the student has a grade more than 50.
USE ITI;

CREATE VIEW STUDENT_DETAILS 
AS
SELECT CONCAT(S.St_Fname,' ',S.St_Lname)AS FULL_NAME,
C.Crs_Name
FROM Student AS S
INNER JOIN Stud_Course AS ST_C ON S.St_Id=ST_C.St_Id
INNER JOIN Course AS C ON C.Crs_Id=ST_C.Crs_Id
WHERE ST_C.Grade>50

SELECT * FROM STUDENT_DETAILS;


--Create an Encrypted view that displays Instructor names and the topics they teach.USE ITI;

alter VIEW INSTRACTOR_TOPICS with encryption
AS
SELECT Ins.Ins_Name , T.Top_Name
FROM Instructor AS Ins
INNER JOIN Ins_Course AS Ins_c ON Ins.Ins_Id=Ins_c.Ins_Id
INNER JOIN Course AS C ON Ins_c.Crs_Id=c.Crs_Id
INNER JOIN Topic AS T ON C.Top_Id=T.Top_Id

sp_helptext 'INSTRACTOR_TOPICS';
select * from INSTRACTOR_TOPICS;