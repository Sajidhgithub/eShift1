USE [eShift]
GO

/****** Object:  Table [dbo].[admin]    Script Date: 9/2/2022 8:26:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[admin](
	[adminID] [int] IDENTITY(1,1) NOT NULL,
	[adminName] [varchar](50) NULL,
	[adminEmail] [varchar](100) NULL,
	[adminPassword] [varchar](20) NULL
) ON [PRIMARY]
GO


