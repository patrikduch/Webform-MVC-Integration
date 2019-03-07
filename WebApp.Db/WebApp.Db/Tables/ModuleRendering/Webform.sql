CREATE TABLE [dbo].[Webform]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[name] varchar(80) not null,
	[type] varchar(80) not null,
	cid int,
	FOREIGN KEY (cid) REFERENCES [Control](id)
)
