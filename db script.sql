USE [4097-Haseeb-Angular]
GO
/****** Object:  Table [dbo].[Calculator]    Script Date: 8/24/2022 7:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

if OBJECT_ID(N'Calculator', N'U') Is Null
Begin
  CREATE TABLE Calculator(
    ID [int] Identity(1,1) Not Null,
    SomeName [varchar](10) null
  )
End

if OBJECT_ID(N'Calculator', N'U') Is Null
Begin
CREATE TABLE [dbo].[Calculator](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[country] [varchar](50) NULL,
	[holidayDay] [int] NULL,
	[holidayMonth] [int] NULL,
 CONSTRAINT [PK_Calculator] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[countryDetail]    Script Date: 8/24/2022 7:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[countryDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[country] [varchar](50) NULL,
	[tax] [float] NULL,
	[currency] [varchar](50) NULL,
	[weekend1] [varchar](50) NULL,
	[weekend2] [varchar](50) NULL,
 CONSTRAINT [PK_countryDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[getcountry]    Script Date: 8/24/2022 7:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getcountry]
@country varchar(50)
AS
begin
SELECT * FROM countryDetail where country=@country
end
GO
/****** Object:  StoredProcedure [dbo].[getinfo]    Script Date: 8/24/2022 7:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getinfo]
@country varchar(50)
AS
begin
SELECT * FROM Calculator where country=@country
end
GO
