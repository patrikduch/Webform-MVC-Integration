create view viControlsAll 
AS 
select cr.name, cr.type, cr.cid
from [Control] C  
JOIN controller cr ON c.id = cr.id 
UNION
select wb.name,wb.type, wb.cid from [Control] C  
JOIN webform wb ON wb.cId = c.id
UNION
select rz.name, rz.type, rz.cId from [Control] C  
JOIN razor rz ON rz.cId = c.id
