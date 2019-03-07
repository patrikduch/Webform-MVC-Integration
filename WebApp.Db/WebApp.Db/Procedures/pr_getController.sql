CREATE PROCEDURE pr_getController 

@controllerName VARCHAR(25)

AS

select * from [Controller] C 
JOIN [View] V ON v.cId = C.id
WHERE c.name = @controllerName;