CREATE PROCEDURE pr_getControls
AS
SELECT * FROM viControlsAll
ORDER BY cId;