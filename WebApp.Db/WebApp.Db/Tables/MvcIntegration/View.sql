CREATE TABLE [dbo].[View]
(
	id int primary key,
	name varchar(255) not null,
	cid int
	FOREIGN KEY (cid) REFERENCES [Controller](id)
)
