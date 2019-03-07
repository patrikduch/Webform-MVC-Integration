CREATE TABLE [dbo].[Controller]
(
	id int primary key,
	name varchar(255) not null,
	[type] varchar(255) not null,
	cid int unique
	FOREIGN KEY (cid) REFERENCES [Control](id),
	mid int
	FOREIGN KEY (mid) REFERENCES [Model](id)
)
