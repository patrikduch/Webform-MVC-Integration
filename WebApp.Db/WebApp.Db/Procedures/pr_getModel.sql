CREATE PROCEDURE [dbo].[pr_getModel]
	@controllerId INT,
	@actionName VARCHAR(50)
AS

SELECT M.id as modelId, M.[name] as modelName FROM [MODEL] M

WHERE m.id IN
(
	SELECT C.mid FROM [ControlLer] C JOIN [VIEW] V ON V.cid = C.id
	WHERE c.id = @controllerId and V.[name] = @actionName
);

