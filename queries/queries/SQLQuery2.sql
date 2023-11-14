USE [eShift]
GO

/****** Object:  Table [dbo].[customer]    Script Date: 9/2/2022 8:27:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[customer](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[customerName] [varchar](100) NULL,
	[customerEmail] [varchar](50) NULL,
	[customerPassword] [varchar](20) NULL
) ON [PRIMARY]
GO


