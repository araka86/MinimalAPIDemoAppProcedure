USE [MinimalApiUserDB]
GO

/****** Object:  StoredProcedure [dbo].[spUser_Update]    Script Date: 1/12/2023 7:04:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	update dbo.[User] 
	set FirstName =@FirstName, LastName=@LastName
	where Id = @Id;
end
GO

