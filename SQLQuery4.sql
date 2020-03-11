create  PROCEDURE [dbo].[pCAT_PACIENTES_G]
(
@Id INT=-99,
@Paterno	varchar(50)='',
@Materno	varchar(50)='',
@Nombre	varchar(255)='',
@Fecha_Alta	datetime=NULL,
@Sexo varchar(20)='',
@Fecha_Nacimiento	datetime=NULL,
@Cve_Municipio	int=0,
@Cve_Estado	int=0,
@EsNuevo bit =0,
@bGenera_Clave bit=0,
@Parametro varchar(50) OUTPUT
)
AS
set nocount on






IF @Fecha_Alta=NULL
 set @Fecha_Alta=getdate()

IF	@EsNuevo=1
	BEGIN
	


	IF @Id= -99
	BEGIN
----
		
				SELECT @Id=ISNULL(MAX(Id),0) 
				FROM PACIENTE									
				SET @Id= ISNULL(@Id,0)+1


		INSERT INTO PACIENTE
			(Id,[A.P],[A.M],Nombre,
			Sexo,
			[F.NAC],
			ESTADO,MUNICIPIO,Fecha
		
				)
		VALUES(
			@Id,
			ISNULL(@Paterno,''),ISNULL(@Materno,''),@Nombre,
			@Sexo,
			@Fecha_Nacimiento,		
			@Cve_Estado,@Cve_Municipio, GETDATE()
			

		)		
		END

		END
			

	



GO
