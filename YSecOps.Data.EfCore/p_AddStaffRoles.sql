Create Or ALTER PROCEDURE [dbo].[p_AddStaffRoles]
AS
SET XACT_ABORT ON;
SET NOCOUNT ON;

BEGIN TRY
	BEGIN TRAN
		MERGE Roles AS Target
		USING( VALUES
		(1,	'ADH'),
		(2,	'MANAGER'),
		(3,	'OPS'),
		(4,	'IT'),
		(5,	'GENERAL')
		) 
		AS Source(RoleId, [Role])
		ON Target.Id = Source.RoleId
		WHEN MATCHED THEN
		UPDATE SET [Role] = Source.[Role]
		WHEN NOT MATCHED BY TARGET THEN
		INSERT([Id],[Role])
		VALUES(Source.[RoleId], Source.[Role])
		WHEN NOT MATCHED BY SOURCE THEN DELETE;
	COMMIT;
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

RETURN 0