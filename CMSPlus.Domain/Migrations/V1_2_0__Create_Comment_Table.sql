CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
    [CreatedOnUtc] [datetime] NOT NULL,
    [UpdatedOnUtc] [datetime] NOT NULL,
	[TopicId] [int] NOT NULL,
	CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Comment_Topic_TopicId] FOREIGN KEY([TopicId]) REFERENCES [dbo].[Topics]([Id]) ON DELETE CASCADE
)
GO