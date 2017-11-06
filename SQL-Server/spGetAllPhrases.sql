SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Michael>
-- Create date: <10.10.2017>
-- Description:	<Fetches all records>
-- =============================================
CREATE PROCEDURE GetAllPhrases
AS
SELECT * FROM [dbo].[allphrases]
GO