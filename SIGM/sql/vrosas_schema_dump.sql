﻿-- DBWScript v4.1
-- Database: D:\Drive\Coda\SIGM\Hacienda - Herramientas\vrosas.accdb

CREATE TABLE actas (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	fecha DATE,
	acta INT,
	libro INT,
	copia CHAR(255),
	nota CHAR(200),
	per_id BIGINT,
	opr_id INT DEFAULT 0,
	cat_id INT DEFAULT 0,
	com_id INT DEFAULT 0,
	opu_id INT DEFAULT 0
);
CREATE TABLE cat_documento (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	catastro_id INT,
	fecha DATE,
	descripcion CHAR(255),
	ruta CHAR(255)
	
);
CREATE TABLE cat_frente (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	catastro_id INT DEFAULT 0,
	calle CHAR(255),
	altura INT DEFAULT 0,
	metros DECIMAL(18, 2) DEFAULT 0,
	ubicacion BOOLEAN NOT NULL DEFAULT FALSE
	
);
CREATE TABLE cat_servicio (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	catastro_id INT DEFAULT 0,
	descripcion CHAR(255),
	activo BOOL NOT NULL DEFAULT FALSE
	
);
CREATE TABLE cat_superficie (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	catastro_id INT DEFAULT 0,
	proyecto DECIMAL(18, 2) DEFAULT 0,
	relevamiento DECIMAL(18, 2) DEFAULT 0,
	terreno DECIMAL(18, 2) DEFAULT 0,
	existente DECIMAL(18, 2) DEFAULT 0
	
);
CREATE TABLE catastro (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	user_id INT DEFAULT 0,
	opr_id INT DEFAULT 0,
	zona DECIMAL(2, 0) DEFAULT 0,
	circ DECIMAL(3, 0) DEFAULT 0,
	secc DECIMAL(3, 0) DEFAULT 0,
	manz DECIMAL(3, 0) DEFAULT 0,
	parc DECIMAL(3, 0) DEFAULT 0,
	lote DECIMAL(3, 0) DEFAULT 0,
	barrio CHAR(255),
	uso CHAR(255),
	cuenta INT DEFAULT 0,
	archivado BOOL NOT NULL DEFAULT FALSE
	
);
CREATE TABLE emp_asistencia (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	empleado_id INT,
	ingreso DATE,
	egreso DATE
);
CREATE TABLE emp_horario (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	empleado_id INT,
	ingreso DATE,
	horas INT,
	dia_semana INT
);
CREATE TABLE emp_vacaciones (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	empleado_id INT,
	tipo CHAR(255),
	inicio DATE,
	final DATE
);
CREATE TABLE empleado (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	per_id INT,
	alta CHAR(255),
	baja CHAR(255),
	jerarquia CHAR(255)
);
CREATE TABLE hac_adelanto (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	monto DECIMAL(12, 2) DEFAULT 0,
	fecha DATE NOT NULL,
	persona_id INT NOT NULL
);
CREATE TABLE hac_combustible_categoria_receptor (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	detalle CHAR(255),
	vehiculo BOOL NOT NULL DEFAULT FALSE
);
CREATE TABLE hac_combustible_items (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	ticket_id INT,
	tipo_item_id INT,
	litros INT,
	monto DECIMAL(19,4),
	unidades INT,
	user_id INT
);
CREATE TABLE hac_combustible_receptor (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	cuenta BIGINT,
	categoria_id INT,
	marca CHAR(255),
	mercosur BOOL NOT NULL DEFAULT FALSE,
	dominio CHAR(255),
	modelo INT,
	alta DATE,
	baja DATE,
	observaciones CHAR(255)
);
CREATE TABLE hac_combustible_responsable (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	receptor_id INT,
	persona_id INT
);
CREATE TABLE hac_combustible_ticket (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	proveedor_id INT,
	responsable_id INT,
	fecha DATE,
	ticket BIGINT,
	total DECIMAL(18, 2) DEFAULT 0,
	user_id INT
);
CREATE TABLE hac_combustible_tipo (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	descripcion CHAR(255),
	por_litro BOOL NOT NULL DEFAULT FALSE
);
CREATE TABLE hac_contrato (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	proveedor_id INT,
	inicio CHAR(255),
	dias INT,
	monto DECIMAL(19,4),
	detalle CHAR(255),
	autoridad1 INT,
	autoridad2 CHAR(255)
);
CREATE TABLE localidades (
	id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	cp CHAR(255),
	nombre CHAR(255),
	provincia_id INT,
	CONSTRAINT id UNIQUE (id)
);
CREATE TABLE multas_articulo (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	descripcion CHAR(255),
	articulo INT
);
CREATE TABLE multas_historial (
	id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	fecha_boleta DATE,
	observaciones TEXT,
	vehiculo_id INT,
	ubicacion CHAR(255),
	conductor_id INT,
	inspector_id INT,
	boleta INT,
	articulo_id INT,
	pago BOOL NOT NULL DEFAULT FALSE,
	fecha_pago DATE,
	user_id INT
);
CREATE TABLE numtostr_dict (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	num SMALLINT,
	str CHAR(255)
);
CREATE TABLE opciones (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	opcion CHAR(255),
	valor CHAR(255)
);
CREATE TABLE opr_documento (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	opr_id INT DEFAULT 0,
	fecha DATE,
	descripcion CHAR(255),
	ruta CHAR(255)
);
CREATE TABLE opr_pago (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	opr_id INT,
	tipo_deuda CHAR(255),
	cuota INT,
	deuda DECIMAL(18, 2) DEFAULT 0,
	vence DATE,
	fecha_pago DATE,
	pago DECIMAL(18, 2) DEFAULT 0
);
CREATE TABLE oprivadas (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	profesional_id BIGINT,
	user_id INT DEFAULT 0,
	expediente BIGINT,
	recibe CHAR(255),
	tarea CHAR(255),
	tarea2 CHAR(255),
	inicio_obra DATE,
	fin_obra DATE,
	temporal BOOL NOT NULL DEFAULT FALSE,
	visado BOOL NOT NULL DEFAULT FALSE,
	observaciones CHAR(255)
);
CREATE TABLE opu_nota_pedido (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	proveedor_id INT,
	numpedido INT,
	fecha DATE,
	descripcion CHAR(255),
	destino CHAR(255),
	responsable_id INT,
	autoriza_id INT
);
CREATE TABLE ordenanza (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	codigo INT,
	fecha CHAR(255),
	concepto CHAR(255),
	ruta_copia CHAR(255),
	user_id INT
);
CREATE TABLE per_documento (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	per_id INT DEFAULT 0,
	fecha DATE,
	descripcion CHAR(255),
	ruta CHAR(255)
);
CREATE TABLE per_domicilio (
	id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	per_id INT,
	calle CHAR(255),
	altura INT,
	piso INT DEFAULT 0,
	dpto CHAR(50),
	localidad_id INT DEFAULT 16250,
	principal BOOL NOT NULL DEFAULT FALSE
);
CREATE TABLE persona (
	id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	razon CHAR(255),
	cuil BIGINT DEFAULT 0,
	email CHAR(255),
	telefono BIGINT DEFAULT 0,
	difunto BOOL NOT NULL DEFAULT FALSE,
	fisica BOOL NOT NULL DEFAULT FALSE,
	ruta_defuncion CHAR(255)
);
CREATE TABLE profesional (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	per_id BIGINT,
	matricula CHAR(255),
	titulo_id INT
);
CREATE TABLE profesional_titulo (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	descripcion CHAR(255)
);
CREATE TABLE prov_actividad (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	actividad CHAR(255)
);
CREATE TABLE proveedor (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	per_id INT,
	actividad_id INT,
	responsable_iva_id INT
);
CREATE TABLE provincias (
	nombre CHAR(255),
	id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY
);
CREATE TABLE responsable_expediente (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	opr_id INT,
	per_id INT,
	principal BOOL NOT NULL DEFAULT FALSE
);
CREATE TABLE responsable_iva (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	descripcion CHAR(255)
);
CREATE TABLE seccion (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	descripcion CHAR(255)
);
CREATE TABLE sql_log (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	_user_id INT,
	_sql TEXT,
	_con CHAR(255),
	_date DATE
);
CREATE TABLE tablas_externas (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	actividad CHAR(255),
	cuentas CHAR(255),
	historial CHAR(255),
	muertos CHAR(255),
	personas CHAR(255),
	tipo CHAR(255),
	variables CHAR(255),
	vencimientos CHAR(255),
	zona CHAR(255)
);
CREATE TABLE titular_catastro (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	cat_id INT,
	per_id INT
);
CREATE TABLE transito_inspector (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	persona_id INT
);
CREATE TABLE usr_log (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	fecha_hora TEXT,
	user_id INT DEFAULT 0,
	token CHAR(255),
	equipo CHAR(255),
	sesion BOOL NOT NULL DEFAULT FALSE
);
CREATE TABLE usuarios (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	persona_id INT,
	usuario TEXT,
	pass TEXT,
	l_catastro BOOL NOT NULL DEFAULT FALSE,
	l_comercio BOOL NOT NULL DEFAULT FALSE,
	l_formularios BOOL NOT NULL DEFAULT FALSE,
	l_gobierno BOOL NOT NULL DEFAULT FALSE,
	l_hacienda BOOL NOT NULL DEFAULT FALSE,
	opcion BOOL NOT NULL DEFAULT FALSE,
	l_oprivadas BOOL NOT NULL DEFAULT FALSE,
	l_opublicas BOOL NOT NULL DEFAULT FALSE,
	l_persona BOOL NOT NULL DEFAULT FALSE,
	l_accionsocial BOOL NOT NULL DEFAULT FALSE,
	l_transito BOOL NOT NULL DEFAULT FALSE
);
CREATE TABLE vehiculo (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	vehiculo_tipo_id INT,
	vehiculo_marca_id INT,
	patente CHAR(255),
	propietario_id INT,
	mercosur BOOL NOT NULL DEFAULT FALSE
);
CREATE TABLE vehiculo_marca (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	marca CHAR(255)
);
CREATE TABLE vehiculo_tipo (
	Id INT GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
	tipo CHAR(255)
);
CREATE INDEX cat_id
	ON actas (cat_id);
CREATE INDEX com_id
	ON actas (com_id);
CREATE INDEX opr_actaexpediente
	ON actas (per_id);
CREATE INDEX opr_actas_id
	ON actas (opr_id);
CREATE INDEX opu_id
	ON actas (opu_id);
CREATE INDEX cat_documento_id
	ON cat_documento (catastro_id);
CREATE INDEX cat_frente_id
	ON cat_frente (catastro_id);
CREATE INDEX cat_servicio_id
	ON cat_servicio (catastro_id);
CREATE INDEX cat_superficie_id
	ON cat_superficie (catastro_id);
CREATE INDEX opr_catastro_id
	ON catastro (opr_id);
CREATE INDEX catastro_user_id
	ON catastro (user_id);
CREATE INDEX emp_asistencia_id
	ON emp_asistencia (empleado_id);
CREATE INDEX emp_horario_id
	ON emp_horario (empleado_id);
CREATE INDEX emp_vacaciones_id
	ON emp_vacaciones (empleado_id);
CREATE INDEX per_empleado_id
	ON empleado (per_id);
CREATE INDEX per_hac_adelanto_id
	ON hac_adelanto (persona_id);
CREATE INDEX ticket_id
	ON hac_combustible_items (ticket_id);
CREATE INDEX tipo_combustible_id
	ON hac_combustible_items (tipo_item_id);
CREATE INDEX hac_combustible_user_id
	ON hac_combustible_items (user_id);
CREATE INDEX area_id
	ON hac_combustible_receptor (cuenta);
CREATE INDEX categoria_id
	ON hac_combustible_receptor (categoria_id);
CREATE INDEX receptor_id
	ON hac_combustible_responsable (receptor_id);
CREATE INDEX hac_combustible_responsable_id
	ON hac_combustible_responsable (persona_id);
CREATE INDEX hac_comb_ticket_proveedor_id
	ON hac_combustible_ticket (proveedor_id);
CREATE INDEX hac_comb_ticket_responsable_id
	ON hac_combustible_ticket (responsable_id);
CREATE INDEX hac_comb_ticket_user_id
	ON hac_combustible_ticket (user_id);
CREATE INDEX hac_contrato_persona_id
	ON hac_contrato (proveedor_id);
CREATE INDEX prov_id
	ON localidades (provincia_id);
CREATE INDEX articulo_id
	ON multas_historial (articulo_id);
CREATE INDEX conductor_id
	ON multas_historial (conductor_id);
CREATE INDEX inspector_id
	ON multas_historial (inspector_id);
CREATE INDEX marca_id
	ON multas_historial (vehiculo_id);
CREATE INDEX multas_historial_user_id
	ON multas_historial (user_id);
CREATE INDEX opr_doc_expediente_id
	ON opr_documento (opr_id);
CREATE INDEX opr_pagoexpediente
	ON opr_pago (opr_id);
CREATE INDEX opr_expedienteexpediente
	ON oprivadas (expediente);
CREATE INDEX profesional_id
	ON oprivadas (profesional_id);
CREATE INDEX oprivadas_user_id
	ON oprivadas (user_id);
CREATE INDEX autoriza_id
	ON opu_nota_pedido (autoriza_id);
CREATE INDEX opu_nota_pedido_proveedor_id
	ON opu_nota_pedido (proveedor_id);
CREATE INDEX opu_nota_pedido_responsable_id
	ON opu_nota_pedido (responsable_id);
CREATE INDEX ordenanza_user_id
	ON ordenanza (user_id);
CREATE INDEX per_doc_expediente_id
	ON per_documento (per_id);
CREATE INDEX per_domicilio_id
	ON per_domicilio (id);
CREATE INDEX localidad_id
	ON per_domicilio (localidad_id);
CREATE INDEX domicilio_persona_id
	ON per_domicilio (per_id);
CREATE INDEX difunto
	ON persona (difunto);
CREATE INDEX razon
	ON persona (razon);
CREATE INDEX prof_persona_id
	ON profesional (per_id);
CREATE INDEX titulo_id
	ON profesional (titulo_id);
CREATE INDEX actividad_id
	ON proveedor (actividad_id);
CREATE INDEX prov_persona_id
	ON proveedor (per_id);
CREATE INDEX reponsable_iva_id
	ON proveedor (responsable_iva_id);
CREATE INDEX provincias_id
	ON provincias (id);
CREATE INDEX resp_exp_persona_id
	ON responsable_expediente (per_id);
CREATE INDEX opr_propietarioexpediente
	ON responsable_expediente (opr_id);
CREATE INDEX sql_log_user_id
	ON sql_log (_user_id);
CREATE INDEX titular_catastro_id
	ON titular_catastro (cat_id);
CREATE INDEX titular_catastro_persona_id
	ON titular_catastro (per_id);
CREATE INDEX tra_inspector_persona_id
	ON transito_inspector (persona_id);
CREATE INDEX usr_log_user_id
	ON usr_log (user_id);
CREATE INDEX usuarios_persona_id
	ON usuarios (persona_id);
CREATE INDEX usuarios_usuario
	ON usuarios (usuario);
CREATE INDEX marca_vehiculo_id
	ON vehiculo (vehiculo_marca_id);
CREATE INDEX propietario_id
	ON vehiculo (propietario_id);
CREATE INDEX tipo_vehiculo_id
	ON vehiculo (vehiculo_tipo_id);