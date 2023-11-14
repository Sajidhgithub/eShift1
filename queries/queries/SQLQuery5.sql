USE [eShift]
GO

/****** Object:  StoredProcedure [dbo].[addRequest]    Script Date: 9/2/2022 8:28:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addRequest]
	-- Add the parameters for the stored procedure here
	@email varchar(50),
	@noOfLots int,
	@source varchar(100),
	@destination varchar(100)
AS
BEGIN
	declare @custometID int = (select customerID from customer where customerEmail=@email)
	insert into job values(@custometID,@noOfLots,@source,@destination,0)
END
GO


