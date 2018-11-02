USE DBRestauranteMarias
GO
--Insercion de los principales datos
--Agregando Roles
insert into Acceso.Roles
	(
		nombreRol, 
		agregarUsuario,
		modificarUsuario, 
		eliminarUsuario,
		consultarUsario,
		agregarProveedor,
		modificarProveedor,
		eliminarProveedor,
		consultarProveedor,
		agregarMesero,
		modificarMesero,
		eliminarMesero,
		consultarMesero,
		anularFactura,
		aperturaCaja,
		cierreCaja  
		)
	VALUES
		(	'Administrador',
			1, 1, 1,1,1,1,1,1,1,1,1,1,1,1,1
			);
GO
INSERT INTO Acceso.Roles
	(
		nombreRol, 
		agregarUsuario,
		modificarUsuario, 
		eliminarUsuario,
		consultarUsario,
		agregarProveedor,
		modificarProveedor,
		eliminarProveedor,
		consultarProveedor,
		agregarMesero,
		modificarMesero,
		eliminarMesero,
		consultarMesero,
		anularFactura,
		aperturaCaja,
		cierreCaja  
		)
	VALUES
		(	'Usuario',
			0, 0, 0,0,1,1,1,1,0,0,0,1,0,0,0
			);

--SP_InsertarUsuario(nombre, apellido, usuario, clave, tipoArea)
EXEC SP_InsertarUsuario 'eduardo','calix','nose', 1
--Agregar Categorias 
EXEC SP_AgregarCategoriaProducto 'Comidas'
EXEC SP_AgregarCategoriaProducto 'Licores'
EXEC SP_AgregarCategoriaProducto 'Bebidas'
--Agregar Tipo productos
EXEC SP_InsertarTipoProducto 'Exento'
EXEC SP_InsertarTipoProducto 'Quince'
EXEC SP_InsertarTipoProducto 'Dieciocho'
--Agregar mesas
EXEC SP_AgregarMesa 'Mesa 1'
EXEC SP_AgregarMesa 'Mesa 2'
EXEC SP_AgregarMesa 'Mesa 3'
EXEC SP_AgregarMesa 'Mesa 4'
EXEC SP_AgregarMesa 'Mesa 5'
EXEC SP_AgregarMesa 'Mesa 6'
EXEC SP_AgregarMesa 'Mesa 7'
EXEC SP_AgregarMesa 'Mesa 8'
EXEC SP_AgregarMesa 'Mesa 9'
EXEC SP_AgregarMesa 'Mesa 10'
EXEC SP_AgregarMesa 'Mesa 11'
EXEC SP_AgregarMesa 'Mesa 12'
EXEC SP_AgregarMesa 'Mesa 13'
EXEC SP_AgregarMesa 'Mesa 14'
EXEC SP_AgregarMesa 'Mesa 15'
EXEC SP_AgregarMesa 'Mesa 16'
EXEC SP_AgregarMesa 'Mesa 17'
EXEC SP_AgregarMesa 'Mesa 18'
EXEC SP_AgregarMesa 'Mesa 19'

--SP_AgregarMesero(identidad,nombre, apellido)
EXEC SP_AgregarMesero '1111-1111-11111','Pedro','Picapiedra'
--SP_AgregarProveedor(nombre,telefono,direccion)
EXEC SP_AgregarProveedor 'Pablo Marmol','9999-9999','Piedra Dura'
-- SP_InsertarTipoUnidad(descripcion)
EXEC SP_InsertarTipoUnidad 'Libras'
EXEC SP_InsertarTipoUnidad 'Unidades'
EXEC SP_InsertarTipoUnidad 'Docena'
--SP_AgregarInsumo(nombre,costo,idTipoUnidad, descripcion,proveedor)
EXEC SP_AgregarInsumo 'tomate',10,5,1,1,'para condimentar',1
EXEC SP_AgregarInsumo 'Pescado',50,15,3,2,'de 100 lempiras',1
--SP_AgregarInventario(	descripcion,costo,precioVenta ,cantidad,cantidadMinima,idCategoria,idTipoProducto,idProveedor )
 