USE [Assignments]
GO
/****** Object:  Table [dbo].[SearchResultTable]    Script Date: 11/02/2022 18:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SearchResultTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SearchResults] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_SearchResultTable_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SearchResultTable] ON 

INSERT [dbo].[SearchResultTable] ([ID], [SearchResults]) VALUES (1, N'c:\hellcat.jpg')
INSERT [dbo].[SearchResultTable] ([ID], [SearchResults]) VALUES (2, N'c:\Program Files (x86)\hellcat.txt')
INSERT [dbo].[SearchResultTable] ([ID], [SearchResults]) VALUES (3, N'c:\Program Files (x86)\VideoLAN\hellcat.doc')
SET IDENTITY_INSERT [dbo].[SearchResultTable] OFF
GO
