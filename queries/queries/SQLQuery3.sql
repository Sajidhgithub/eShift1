USE [eShift]
GO

/****** Object:  Table [dbo].[job]    Script Date: 9/2/2022 8:27:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[job](
	[jobID] [int] IDENTITY(1,1) NOT NULL,
	[customerID] [int] NULL,
	[noOfLoads] [int] NULL,
	[source] [varchar](100) NULL,
	[destination] [varchar](100) NULL,
	[isApproved] [bit] NULL
) ON [PRIMARY]
GO


