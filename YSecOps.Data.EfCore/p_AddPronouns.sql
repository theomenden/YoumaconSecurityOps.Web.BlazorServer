Create Or ALTER PROCEDURE [dbo].[p_AddPronouns]
	AS
SET XACT_ABORT ON;
SET NOCOUNT ON;

BEGIN TRY
	BEGIN TRAN
		MERGE [dbo].[Pronouns] AS Target
		USING( VALUES
		 (1,	'She/Her')
		,(2,	'He/Him')
		,(3,	'They/Them')
		,(4,	'He/They')
		,(5,	'She/They')
		,(6,	'He/She')
		,(7,	'Zie/Zim')
		,(8,	'Xe/Xem')
		,(9,	'Fae/Faer')
		,(10,	'Ve/Ver')
		,(11,	'It/Its')
		,(12,	'Any')
		,(13,	'None')
		,(14,	'Ask')
		) 
		AS Source(PronounId, [Pronoun])
		ON Target.Id = Source.PronounId
		WHEN MATCHED THEN
		UPDATE SET [Name] = Source.[Pronoun]
		WHEN NOT MATCHED BY TARGET THEN
		INSERT([Id],[Name])
		VALUES (Source.[PronounId],Source.[Pronoun])
		WHEN NOT MATCHED BY SOURCE THEN DELETE;
	COMMIT;
END TRY
BEGIN CATCH
	ROLLBACK TRAN;
	THROW;
END CATCH

RETURN 0