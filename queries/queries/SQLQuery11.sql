USE [eShift]
GO

/****** Object:  StoredProcedure [dbo].[isCustomer]    Script Date: 9/2/2022 8:29:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[isCustomer]
	-- Add the parameters for the stored procedure here
	@email varchar(50),
	@password varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from customer where customerEmail=@email and customerPassword=@password
END
GO


