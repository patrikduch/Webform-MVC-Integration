CREATE PROCEDURE pr_getView
@controllerId INT
AS
SELECT * FROM [view] V WHERE V.cId = @controllerId
