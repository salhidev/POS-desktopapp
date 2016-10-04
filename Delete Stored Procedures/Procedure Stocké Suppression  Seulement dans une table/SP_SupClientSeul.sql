CREATE PROCEDURE SP_SuppClientSeul
( @CLT_MAT INT ) 

AS 

BEGIN TRANSACTION

 ALTER TABLE COMMANDE
 NOCHECK CONSTRAINT FK_COMMANDE_ASSOCIATI_CLIENT

 DELETE FROM CLIENT WHERE CLIENT.CLT_MAT=@CLT_MAT

  ALTER TABLE COMMANDE
  CHECK CONSTRAINT FK_COMMANDE_ASSOCIATI_CLIENT

COMMIT TRANSACTION