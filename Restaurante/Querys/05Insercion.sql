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
EXEC SP_InsertarTipoProducto 'Elaborado'
EXEC SP_InsertarTipoProducto 'Artificial'
--EXEC SP_InsertarTipoProducto 'Dieciocho'
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
EXEC SP_AgregarMesa 'Mesa 20'
EXEC SP_AgregarMesa 'Mesa 21'
EXEC SP_AgregarMesa 'Mesa 22'
EXEC SP_AgregarMesa 'Mesa 23'
EXEC SP_AgregarMesa 'Mesa 24'
EXEC SP_AgregarMesa 'Mesa 25'
EXEC SP_AgregarMesa 'Mesa 26'
EXEC SP_AgregarMesa 'Mesa 27'
EXEC SP_AgregarMesa 'Mesa 28'
EXEC SP_AgregarMesa 'Mesa 29'
EXEC SP_AgregarMesa 'Mesa 30'
EXEC SP_AgregarMesa 'Mesa 31'
EXEC SP_AgregarMesa 'Mesa 32'
EXEC SP_AgregarMesa 'Mesa 33'
EXEC SP_AgregarMesa 'Mesa 34'
EXEC SP_AgregarMesa 'Mesa 35'
EXEC SP_AgregarMesa 'Mesa 36'
EXEC SP_AgregarMesa 'Mesa 37'
EXEC SP_AgregarMesa 'Mesa 38'
EXEC SP_AgregarMesa 'Mesa 39'
EXEC SP_AgregarMesa 'Mesa 40'
EXEC SP_AgregarMesa 'Mesa 41'
EXEC SP_AgregarMesa 'Mesa 42'
EXEC SP_AgregarMesa 'Mesa 43'
EXEC SP_AgregarMesa 'Mesa 44'
EXEC SP_AgregarMesa 'Mesa 45'
EXEC SP_AgregarMesa 'Mesa 46'
EXEC SP_AgregarMesa 'Mesa 47'
EXEC SP_AgregarMesa 'Mesa 48'
EXEC SP_AgregarMesa 'Mesa 49'
EXEC SP_AgregarMesa 'Mesa 50'


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
 
 INSERT INTO Restaurante.ServicioPublico (Descripcion)
	VALUES('Otro'),
		  ('Energia Electrica')

INSERT INTO Restaurante.DetalleCaja(Descripcion)
	VALUES('Apertura'),
		  ('Cierre')