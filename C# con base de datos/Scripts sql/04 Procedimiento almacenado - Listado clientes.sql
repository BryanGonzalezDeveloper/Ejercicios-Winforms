USE
CONTRATO
GO
/*
Programador: Bryan Enrique Gonzalez Zambrano.
Fecha de elaboracion: 08 de enero de 2021.
Version: 1.0
Proposito del script: 
Realizar un procedimiento almacenado que muestre todos los registros de la tabla 'CLIENTE' que se encuentra en la base de datos
llamada 'CONTRATO' 
Este procedimiento almacenado sera utilizado en una aplicacion de escritorio realizada con C# mostrando los registros en un
DataGridView.
*/

CREATE PROCEDURE SP_ListadoClientes
AS
BEGIN
SELECT 
	C.IDE_CLI [CODIGO],
	DNI_CLI [DNI],
	(NOM_CLI+SPACE(1)+MAT_CLI+SPACE(1)+PAT_CLI) [NOMBRE],
	FON_CLI [TELEFONO],
	DIR_CLI [DIRECCION]
FROM CLIENTE AS C
END
GO

--Prueba del funcionamiento del procedimiento almacenado:
EXECUTE SP_ListadoClientes;
GO