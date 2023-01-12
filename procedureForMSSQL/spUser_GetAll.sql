USE [MinimalApiUserDB]
GO

/****** Object:  StoredProcedure [dbo].[spUser_GetAll]    Script Date: 1/12/2023 7:03:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	select Id, FirstName, LastName 
	from  dbo.[User];
end
GO

