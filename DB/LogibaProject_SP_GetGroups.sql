USE [LogibaProject]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetGroups]    Script Date: 2.09.2018 22:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_GetGroups]

AS
BEGIN
	CREATE TABLE #Temp
	(
		id INT,
		[Name] VARCHAR(200),
		UserCount INT
	)

	INSERT INTO #Temp (id,[Name]) SELECT id,[Name] FROM Groups
	UPDATE #Temp SET UserCount = (SELECT COUNT(UserId) FROM MapGroupUser WHERE GroupId = #Temp.id)

	SELECT * FROM #Temp
	DROP TABLE #Temp
END
