USE [MinimalApiUserDB]
GO

/****** Object:  StoredProcedure [dbo].[spUser_Insert]    Script Date: 1/12/2023 7:03:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	insert into dbo.[User] (FirstName,LastName)
	values (@FirstName,@LastName);
end
GO

