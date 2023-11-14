USE [eShift]
GO

/****** Object:  StoredProcedure [dbo].[getCustomerRequests]    Script Date: 9/2/2022 8:29:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getCustomerRequests]
	-- Add the parameters for the stored procedure here
	@email varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from job where customerID=(select customerID from customer where customerEmail=@email)
END
GO


