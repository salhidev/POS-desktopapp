CREATE PROCEDURE SP_SuppTicketSeul

(@TIK_ID INT )

 AS
 
BEGIN TRAN

 ALTER TABLE PAYEMENT_OF_TICKET
 NOCHECK CONSTRAINT FK_PAYEMENT_PAYEMENT__TICKET
 
 DELETE FROM TICKET WHERE TICKET.TIK_ID=@TIK_ID

 ALTER TABLE PAYEMENT_OF_TICKET
 CHECK CONSTRAINT FK_PAYEMENT_PAYEMENT__TICKET

COMMIT TRAN