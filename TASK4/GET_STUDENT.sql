USE [ITI]
GO
/****** Object:  UserDefinedFunction [dbo].[GET_STUDENT]    Script Date: 12/5/2024 4:18:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER FUNCTION [dbo].[GET_STUDENT](@STUDENT_ID INT)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT CONCAT(S.St_Fname,' ' , S.St_Lname) AS FULL_NAME,
	D.Dept_Name
	FROM Student AS S
	INNER JOIN Department AS D
	ON D.Dept_Id=S.Dept_Id
	WHERE S.St_Id=@STUDENT_ID
);
