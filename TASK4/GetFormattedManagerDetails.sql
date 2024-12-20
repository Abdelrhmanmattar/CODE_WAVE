USE [ITI]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFormattedManagerDetails]    Script Date: 12/5/2024 4:18:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER FUNCTION [dbo].[GetFormattedManagerDetails](@Style_Code INT)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT D.Dept_Name , 
	MANGER.Ins_Name AS MANGER_NAME,
	CONVERT(VARCHAR , D.Manager_hiredate , @Style_Code) AS HIRING_DATE
	FROM Department AS D
	INNER JOIN Instructor AS MANGER
	ON D.Dept_Manager = MANGER.Ins_Id AND D.Manager_hiredate IS NOT NULL AND D.Dept_Manager IS NOT NULL
)
