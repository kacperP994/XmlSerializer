CREATE TABLE [dbo].[Requests](
	[Index] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Visits] [int] NULL,
	[Date] [datetime] not null
PRIMARY KEY CLUSTERED 
(
	[Index] ASC
));