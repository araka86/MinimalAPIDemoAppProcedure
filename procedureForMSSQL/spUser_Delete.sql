USE [MinimalApiUserDB]
GO

/****** Object:  StoredProcedure [dbo].[spUser_Delete]    Script Date: 1/12/2023 7:03:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUser_Delete]
@Id int
AS
begin
	delete
	from  dbo.[User]
	where Id = @Id;
end
GO

