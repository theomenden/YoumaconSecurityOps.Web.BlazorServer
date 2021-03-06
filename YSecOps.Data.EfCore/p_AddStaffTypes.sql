Create Or ALTER PROCEDURE [dbo].[p_AddStaffTypes]

AS

SET XACT_ABORT ON;
SET NOCOUNT ON;

BEGIN TRY
	BEGIN TRAN

	MERGE INTO StaffTypes AS Target
	USING(VALUES
	(1,	'Floor	', 'General Staff Designation - Given a zone to patrol'),
	(2,	'Elevator',	'Works elevators in RenCen'),
	(3,	'Ops',	'Responsible for Ops and App operations'),
	(4,	'Roaming',	'Patrols con-spaces, free roamers'),
	(5,	'Rave',	'Rave Approved Staff - REQUIRES ADH Approval to assign')
	) 
	AS Source(StaffTypeId, [Title], [Description])
	ON Target.Id = Source.StaffTypeId
	WHEN MATCHED THEN
	UPDATE SET [Title] = Source.Title, [Description] = Source.[Description]
	WHEN NOT MATCHED BY TARGET THEN
	INSERT([Id],[TItle],[Description])
	VALUES(Source.[StaffTypeId], Source.[Title], Source.[Description])
	WHEN NOT MATCHED BY SOURCE THEN DELETE;
	COMMIT TRAN;
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH;
RETURN 0;