USE
CONTRATO
GO
/*
Programador: Bryan Enrique Gonzalez Zambrano.
Fecha de elaboracion: 13 de enero de 2021.
Version: 1.0
Proposito del script:
Realizar un procedimento almacenado donde se consulten todos los registros de la tabla 'CONTRATISTA'
para posteriormente mostrar el listado en una aplicacion Windows Forms dentro de un control 'DataGridView'
*/

CREATE PROCEDURE SP_ListadoContratistas
AS
BEGIN
	SELECT
		C.IDE_CON AS [ID],
		(C.NOM_CON +' '+ C.PAT_CON +' '+ C.MAT_CON) AS [NOMBRE COMPLETO] ,
		C.FON_CON AS [TELEFONO],
		C.EMA_CON AS [CORREO]
	FROM
		DBO.CONTRATISTA AS C
END
GO

---VERIFICACION DE QUE EL PROCEDIMIENTO FUNCIONA:
EXECUTE SP_ListadoContratistas
GO