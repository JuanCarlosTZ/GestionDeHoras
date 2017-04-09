Select 
SOLICITUD.ID as Solicitud
,USUARIO.Nombre as Usuario
,USUARIO.Cedula as Cedula
,CAMPUS.Nombre as Campus 
,EDIFICIO.Nombre as Edificio 
,AULA.Nombre as Aula
,AULA.Tipo as Tipo_Aula
,SOLICITUD.Fecha_Reservacion
, dateadd(hour, cantidad_hora, Fecha_reservacion) as Fecha_Fin 
,SOLICITUD.Cantidad_Hora
,SOLICITUD.Estado
,SOLICITUD.Ejecucion


from SOLICITUD 
inner join AULA on SOLICITUD.ID_Aula = aula.ID
inner join EDIFICIO on AULA.ID_Edificio = EDIFICIO.ID
inner join CAMPUS on EDIFICIO.ID_Campus = CAMPUS.ID 
inner join USUARIO on SOLICITUD.ID_Usuario = USUARIO.ID




select * from USUARIO