USE [MinimalApiUserDB]
GO

/****** Object:  StoredProcedure [dbo].[spUser_Get]    Script Date: 1/12/2023 7:03:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUser_Get]
@Id int
AS
begin
	select Id, FirstName, LastName 
	from  dbo.[User]
	where Id = @Id;
end
GO

