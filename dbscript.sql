USE [mylocalDB]
GO
/****** Object:  Table [dbo].[TblUserDetail]    Script Date: 7/5/2020 7:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUserDetail](
	[UserName] [nchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 7/5/2020 7:30:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[FeatureId] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TblUserDetail] ([UserName], [Password]) VALUES (N'dipak                                             ', N'mahadik')
GO
INSERT [dbo].[TblUserDetail] ([UserName], [Password]) VALUES (N'ashok                                             ', N'mahadik')
GO
INSERT [dbo].[TblUserDetail] ([UserName], [Password]) VALUES (N'babaso                                            ', N'mahadik')
GO
SET IDENTITY_INSERT [dbo].[Test] ON 
GO
INSERT [dbo].[Test] ([FeatureId], [IsDeleted], [Id]) VALUES (1, 0, 1)
GO
SET IDENTITY_INSERT [dbo].[Test] OFF
GO
