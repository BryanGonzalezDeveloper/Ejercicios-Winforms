use
master
go
--DEFINIENDO EL FORMATO DE LA FECHA
SET DATEFORMAT DMY
---Verificando la existencia de la BD CONTRATO
IF DB_ID('CONTRATO') IS NOT NULL
BEGIN
USE MASTER
DROP DATABASE CONTRATO
END
GO
--Creando la BD CONTRATO
CREATE DATABASE CONTRATO
GO
--Activando la BD CONTRATO
USE CONTRATO
GO
CREATE TABLE CONTRATISTA(
IDE_CON CHAR(6) NOT NULL,
NOM_CON VARCHAR(30) NOT NULL,
PAT_CON VARCHAR(20) NOT NULL,
MAT_CON VARCHAR(20) NOT NULL,
FON_CON VARCHAR(15) NOT NULL,
EMA_CON VARCHAR(50) NOT NULL)
GO
CREATE TABLE CLIENTE(
IDE_CLI CHAR(6) NOT NULL,
NOM_CLI VARCHAR(30) NOT NULL,
PAT_CLI VARCHAR(20) NOT NULL,
MAT_CLI VARCHAR(50) NOT NULL,
FON_CLI VARCHAR(15) NOT NULL,
DNI_CLI CHAR(8) NOT NULL,
DIR_CLI VARCHAR(50) NULL)
GO
CREATE TABLE EQUIPO(
IDE_EQU CHAR(6) NOT NULL,
COD_TIP_EQU CHAR(6) NOT NULL,
DESC_EQU VARCHAR(50) NOT NULL,
PREC_EQU MONEY NULL,
COD_EST CHAR(6) NULL)
GO
CREATE TABLE CONTRATOALQUILER(
COD_CON CHAR(6) NOT NULL,
IDE_CLI CHAR(6) NOT NULL,
IDE_CON CHAR(6) NOT NULL,
FIN_CON DATE NOT NULL,
FFI_CON DATE NOT NULL,
TIP_CON VARCHAR(50) NOT NULL)
GO
CREATE TABLE ESTADO_EQUIPO(
COD_EST CHAR(6) NOT NULL,
DES_EST VARCHAR(100) NOT NULL)
GO
CREATE TABLE DETALLE_CONTRATO_ALQUILER(
COD_CON CHAR(6) NOT NULL,
IDE_EQU CHAR(6) NOT NULL,
UNI_CON INT NOT NULL,
DIA_CON INT NOT NULL)
GO
CREATE TABLE TIPOMANTENIMIENTO(
COD_TIP_MAN CHAR(6) NOT NULL,
DES_TIP_MAN VARCHAR(100) NOT NULL)
GO
CREATE TABLE CONTRATOMANTENIMIENTO(
COD_CON CHAR(6) NOT NULL,
IDE_CLI CHAR(6) NOT NULL,
IDE_CON CHAR(6) NOT NULL,
FEC_CON DATE NOT NULL)
GO
CREATE TABLE DETALLE_CONTRATO_MANTENIMIENTO(
COD_CON CHAR(6) NOT NULL,
IDE_EQU CHAR(6) NOT NULL,
COD_EQU_MAN CHAR(6) NOT NULL)
GO
CREATE TABLE FICHADEDA�OS(
COD_FIC CHAR(6) NOT NULL,
IDE_CON CHAR(6) NOT NULL,
IDE_CLI CHAR(6) NOT NULL,
FFI_FIC DATE NOT NULL)
GO
CREATE TABLE DETALLE_FICHA_DA�O(
COD_FIC CHAR(6) NOT NULL,
IDE_EQU CHAR(6) NOT NULL,
COD_TIP_DA� CHAR(6) NOT NULL,
DES_DET VARCHAR(100) NOT NULL)
GO
CREATE TABLE TIPO_DA�O(
COD_TIP_DA� CHAR(6) NOT NULL,
DES_TIP_DA� VARCHAR(100) NOT NULL)
GO
CREATE TABLE FICHARECLAMO(
COD_FIC CHAR(6) NOT NULL,
IDE_CON CHAR(6) NOT NULL,
IDE_CLI CHAR(6) NOT NULL,
FFI_FIC DATE NOT NULL)
GO
CREATE TABLE DETALLE_FICHA_RECLAMO(
COD_FIC CHAR(6) NOT NULL,
IDE_EQU CHAR(6) NOT NULL,
COD_TIP_REC CHAR(6) NOT NULL,
DES_DET VARCHAR(100) NOT NULL)
GO
CREATE TABLE TIPO_RECLAMO(
COD_TIP_REC CHAR(6) NOT NULL,
DESCTIP VARCHAR(100) NOT NULL)
GO
CREATE TABLE TIPO_EQUIPO(
COD_TIP_EQU CHAR(6) NOT NULL,
DES_TIP VARCHAR(100) NOT NULL)
GO
CREATE TABLE FICHA_DEVOLUCION(
COD_FIC CHAR(6) NOT NULL,
IDE_CON CHAR(6) NOT NULL,
IDE_CLI CHAR(6) NOT NULL,
IDE_EQU CHAR(6) NOT NULL,
FDE_FIC DATE NOT NULL,
MOR_FIC MONEY NULL)
GO