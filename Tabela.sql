USE [Ushtrime4_DB]
GO

/****** Object:  Table [dbo].[Emails]    Script Date: 11/7/2015 4:19:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Emails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adresa] [nvarchar](50) NOT NULL,
	[subjekti] [nvarchar](50) NOT NULL,
	[trupi] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

