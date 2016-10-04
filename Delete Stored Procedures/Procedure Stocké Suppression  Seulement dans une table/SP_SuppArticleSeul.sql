USE [IN5_CAISSE]
GO

/****** Object:  StoredProcedure [dbo].[SP_SuppArticleSeul]    Script Date: 04/25/2012 11:51:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[SP_SuppArticleSeul]
( @ART_ID int )

AS 

BEGIN TRANSACTION

ALTER TABLE COMMANDE_OF_ARTICLE
NOCHECK CONSTRAINT FK_COMMANDE_COMMANDE__ARTICLE

ALTER TABLE TARIF_OF_ARTICLE
NOCHECK CONSTRAINT FK_TARIF_OF_TARIF_OF__ARTICLE

DELETE FROM ARTICLE where ARTICLE.ART_ID=@ART_ID

ALTER TABLE COMMANDE_OF_ARTICLE
CHECK CONSTRAINT FK_COMMANDE_COMMANDE__ARTICLE

ALTER TABLE TARIF_OF_ARTICLE
CHECK CONSTRAINT FK_TARIF_OF_TARIF_OF__ARTICLE

COMMIT TRANSACTION

GO


