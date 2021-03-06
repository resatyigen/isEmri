USE [LogibaProject]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetWorks]    Script Date: 3.09.2018 00:30:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_GetWorks]
	@type VARCHAR(50)
AS
BEGIN

    IF (@type = 'user')
		BEGIN
			SELECT 
			mw.id AS MapId,
			wrk.id AS WorkId,
			usr.id AS UserId,
			wrk.Name AS WorkName,
			usr.FullName as FullName,
			wrk.StartDate,
			wrk.EndDate,
			wrk.Status
			FROM MapWork AS mw
			INNER JOIN Users AS usr ON mw.UserId = usr.id
			INNER JOIN Works AS wrk ON mw.WorkId = wrk.id
		END
	ELSE IF(@type='group')
		BEGIN
			SELECT
			mw.id AS MapId,
			wrk.id AS WorkId,
			grp.id AS GroupId,
			wrk.Name AS WorkName,
			grp.Name as GroupName,
			wrk.StartDate,
			wrk.EndDate,
			wrk.Status
			FROM MapWork AS mw
			INNER JOIN Groups AS grp ON mw.GroupId = grp.id
			INNER JOIN Works AS wrk ON mw.WorkId = wrk.id
		END
END
