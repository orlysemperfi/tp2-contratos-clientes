INSERT INTO [TMD].[CC].[TABLA_CORRELATIVO]
           ([NOMBRE_TABLA]
           ,[CORRELATIVO]
           ,[EN_USO])
     VALUES
           ('SOLICITUD'
           ,0
           ,0)
GO
INSERT INTO [TMD].[CC].[TABLA_CORRELATIVO]
           ([NOMBRE_TABLA]
           ,[CORRELATIVO]
           ,[EN_USO])
     VALUES
           ('CONTRATO'
           ,0
           ,0)
GO

INSERT INTO [TMD].[CC].[MONEDA]
           ([CODIGO_MONEDA]
           ,[NOMBRE])
     VALUES
           ('PEN'
           ,'NUEVO SOL')
GO


INSERT INTO [TMD].[CC].[LINEA_SERVICIO]
           ([DESCRIPCION])
     VALUES
           ('OURTSOURCING')
GO


INSERT INTO [TMD].[CC].[SERVICIO]
           ([DESCRIPCION]
           ,[CODIGO_LINEA_SERVICIO])
     VALUES
           ('SERV FACTORY'
           ,1)
GO



INSERT INTO [TMD].[CC].[CLIENTE]
           ([RAZON_SOCIAL]
           ,[RUC]
           ,[DIRECCION]
           ,[TELEFONO]
           ,[ANEXO]
           ,[CORREO]
           ,[FAX]
           ,[TIPO_CLIENTE]
           ,[ESTADO])
     VALUES
           ('CLARO SAC'
           ,'20142536981'
           ,'AV JAVIER PRADO 2145'
           ,'123-9658'
           ,'251'
           ,'CLARO.SERV@CLARO.COM.PE'
           ,'3245-4185'
           ,'R'
           ,1)
GO






INSERT INTO [TMD].[CC].[CONTRATO]
           ([NUMERO_DOCUMENTO]
           ,[TIPO_DOCUMENTO]
           ,[FECHA_INICIO]
           ,[FECHA_FIN]
           ,[TIPO_CAMBIO]
           ,[MONTO_MONEDA_NACIONAL]
           ,[MONTO_MONEDA_EXTRANJERA]
           ,[GARANTIA]
           ,[BONIFICACION]
           ,[ESTADO]
           ,[FECHA_TERMINO]
           ,[MOTIVO_TERMINO]
           ,[CODIGO_SOLICITUD]
           ,[CODIGO_CLIENTE]
           ,[CODIGO_SERVICIO]
           ,[CODIGO_MONEDA]
           ,[CODIGO_CONTRATO_PADRE])
     VALUES
           ('CON0000001'
           ,'C'
           ,GETDATE()
           ,'10/05/2013'
           ,'2.63'
           ,'30000.00'
           ,NULL
           ,'SR.C'
           ,'CONTRATO PENDIENTE'
           ,'A'
           ,NULL
           ,NULL
           ,1
           ,1
           ,1
           ,'PEN'
           ,NULL)
GO

INSERT INTO [TMD].[CC].[CONTRATO]
           ([NUMERO_DOCUMENTO]
           ,[TIPO_DOCUMENTO]
           ,[FECHA_INICIO]
           ,[FECHA_FIN]
           ,[TIPO_CAMBIO]
           ,[MONTO_MONEDA_NACIONAL]
           ,[MONTO_MONEDA_EXTRANJERA]
           ,[GARANTIA]
           ,[BONIFICACION]
           ,[ESTADO]
           ,[FECHA_TERMINO]
           ,[MOTIVO_TERMINO]
           ,[CODIGO_SOLICITUD]
           ,[CODIGO_CLIENTE]
           ,[CODIGO_SERVICIO]
           ,[CODIGO_MONEDA]
           ,[CODIGO_CONTRATO_PADRE])
     VALUES
           ('CON0000002'
           ,'C'
           ,GETDATE()
           ,'10/05/2013'
           ,'2.63'
           ,'30000.00'
           ,NULL
           ,'SR.C'
           ,'CONTRATO PENDIENTE'
           ,'A'
           ,NULL
           ,NULL
           ,1
           ,1
           ,1
           ,'PEN'
           ,5)
GO


SELECT * FROM CC.SOLICITUD
SELECT * FROM CC.CONTRATO



