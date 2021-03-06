Create Or ALTER Procedure [dbo].[p_AddStartingLocations]

As
Begin

Set XAct_Abort On;
Set NoCount On;

Begin Try
	Begin Tran

	Create Table #Locations(Id UniqueIdentifier Primary Key Default NewSequentialId(), [Name] nvarchar(100) , IsHotel  Bit Default 0);

	Insert Into #Locations(Name)
	Values
	 ('TCF Center Ops')
	,('RenCen Ops')
	,('Dealers')
	,('RenCen Food Court')
	,('Winter Gardens')
	,('RenCen Elevators Floor 1')
	,('RenCen Elevators Floor 2')
	,('RenCen Elevators Floor 3')
	,('RenCen Elevators Floor 4')
	,('RenCen Elevators Floor 5');

	Merge Into Locations As Target
	Using #Locations As Source
	On Target.Id = Source.Id
	When Matched Then
	Update Set
	 Target.[Name] = Source.[Name]
	,Target.[IsHotel] = Source.[IsHotel]
	When Not Matched By Target Then
	Insert([Id], [Name], [IsHotel])
	Values(Source.Id, Source.[Name], Source.[IsHotel])
	When Not Matched By Source Then Delete;

	Commit Tran;
End Try
Begin Catch
	Rollback Tran;
	Throw;
End Catch;

End