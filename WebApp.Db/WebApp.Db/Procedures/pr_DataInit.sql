CREATE PROCEDURE [dbo].[pr_DataInit]
AS
	
INSERT INTO [dbo].[Control] values (1)
INSERT INTO [dbo].[Control] values (2)

INSERT INTO [dbo].[Control] values (3)
INSERT INTO [dbo].[Control] values (4)

INSERT INTO [dbo].[Control] values (5)

INSERT INTO Model VALUES (1,'Test');
-- CONTROLLER
INSERT INTO Controller VALUES (1,'Default', 'Controller',1,1);
-- VIEW
INSERT INTO [View] VALUES(1,'Index',1);
--- RAZOR
INSERT INTO Razor values (1, 'TestRazor', 'Razor',3);
INSERT INTO Razor values (2, 'TestRazor2', 'Razor',4);

-- WEBFORM
INSERT INTO Webform values (1, 'TestControl', 'Webform',5);
