USE [IN5_CAISSE]
GO

/****** Object:  StoredProcedure [dbo].[SP_SupprimerRayon]    Script Date: 04/25/2012 12:04:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_SupprimerRayon]
( @RAY_ID INT )

AS 

BEGIN TRANSACTION
  
  ALTER TABLE FAMILLE
  NOCHECK CONSTRAINT FK_FAMILLE_ASSOCIATI_RAYON

  DELETE FROM RAYON WHERE RAYON.RAY_ID=@RAY_ID

  DELETE FROM FAMILLE WHERE FAMILLE.RAY_ID=@RAY_ID

  ALTER TABLE FAMILLE
  CHECK CONSTRAINT FK_FAMILLE_ASSOCIATI_RAYON

COMMIT TRANSACTION


GO


