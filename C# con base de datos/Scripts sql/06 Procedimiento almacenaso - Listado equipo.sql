USE
CONTRATO
GO
/*
Programador: Bryan Enrique Gonzalez Zambrano.
Fecha de elaboracion: 01 de febrero de 2021.
Version: 1.0
Proposito del script:
Realizar un procedimento almacenado que permita listar los datos de los equipos, además de mostrar la descripción del estado y
del tipo de equipo.
para posteriormente mostrar el listado en una aplicacion Windows Forms dentro de un control 'DataGridView'
*/

CREATE PROCEDURE SP_ListaEquipo
AS
BEGIN
	SELECT 
		EQU.DESC_EQU AS [DESCRIPCION PRODUCTO],
		EQU.PREC_EQU AS [PRECIO],
		EQU.COD_TIP_EQU AS [TIPO EQUIPO],
		T_EQU.DES_TIP AS [DESCRIPCION TIPO] ,
		E_EQU.DES_EST AS [ESTADO]
		FROM EQUIPO AS EQU
	INNER JOIN ESTADO_EQUIPO AS E_EQU ON EQU.COD_EST= E_EQU.COD_EST
	INNER JOIN TIPO_EQUIPO AS T_EQU ON EQU.COD_TIP_EQU=T_EQU.COD_TIP_EQU
END
GO
/*
Para realizar la consulta se necesito de las tablas:
EQUIPO;			CON EL ALIAS EQU
ESTADO_EQUIPO;	CON EL ALIAS E_EQU
TIPO_EQUIPO;	CON EL ALIAS T_EQU
Las tablas fueron enlazadas utilizando inner join.
*/

--Prueba del funcionamiento del procedimiento almacenado:
EXECUTE SP_ListaEquipo;
GO