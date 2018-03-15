/*************** Create New Table ****************/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	Id int NULL,
	English text NULL,
	German text NULL,
	Note text NULL,
	Category text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[English]
      ,[German]
      ,[Note]
      ,[Category]
  FROM [GermanPhraseBook].[dbo].[phrases]


/******** Script to Delete Row from Table **********/
DELETE TOP (1)
FROM phrases
WHERE  CONVERT(VARCHAR(MAX), [German]) = 'Phrase to be deleted'