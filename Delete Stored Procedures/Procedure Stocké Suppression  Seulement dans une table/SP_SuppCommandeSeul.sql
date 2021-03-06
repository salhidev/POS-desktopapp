CREATE PROCEDURE SP_SuppCommandeSeul
( @CMD_ID int )

AS
BEGIN TRANSACTION

 ALTER TABLE COMMANDE_OF_ARTICLE
 NOCHECK CONSTRAINT FK_COMMANDE_COMMANDE__COMMANDE

 ALTER TABLE FACTURE 
 NOCHECK CONSTRAINT FK_FACTURE_F_C_COMMANDE

 ALTER TABLE TICKET 
 NOCHECK CONSTRAINT FK_TICKET_C_T_COMMANDE

 DELETE FROM COMMANDE WHERE COMMANDE.CMD_ID=@CMD_ID

 ALTER TABLE COMMANDE_OF_ARTICLE
 CHECK CONSTRAINT FK_COMMANDE_COMMANDE__COMMANDE

 ALTER TABLE FACTURE 
 CHECK CONSTRAINT FK_FACTURE_F_C_COMMANDE

 ALTER TABLE TICKET 
 CHECK CONSTRAINT FK_TICKET_C_T_COMMANDE
 
 COMMIT TRANSACTION