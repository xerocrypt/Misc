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