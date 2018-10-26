USE DBRestauranteMarias
GO
--hacer store procedure para la incersion de areas
insert into Acceso.Roles
	(
		nombreRol, 
		agregarUsuario,
		modificarUsuario, 
		eliminarUsuario,
		consultarUsario  ,
		agregarProveedor  ,
		modificarProveedor  ,
		eliminarProveedor  ,
		consultarProveedor  ,
		agregarMesero  ,
		modificarMesero  ,
		eliminarMesero  ,
		consultarMesero  ,
		anularFactura  ,
		aperturaCaja  ,
		cierreCaja  
		)
	VALUES
		(	'Administrador',
			1, 1, 1,1,1,1,1,1,1,1,1,1,1,1,1
			);

--SP_InsertarUsuario(nombre, apellido, usuario, clave, tipoArea)
EXEC SP_InsertarUsuario 'eduardo','calix','nose', 1