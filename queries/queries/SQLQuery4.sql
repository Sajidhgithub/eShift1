USE [eShift]
GO

/****** Object:  StoredProcedure [dbo].[acceptRequest]    Script Date: 9/2/2022 8:28:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[acceptRequest]
	-- Add the parameters for the stored procedure here
	@jobID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update job set isApproved=1 where jobID=@jobID
END
GO


