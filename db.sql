DROP DATABASE IF EXISTS aplus_access;

CREATE database aplus_access CHARACTER SET 'UTF8' COLLATE 'utf8_general_ci';

use aplus_access;

DROP TABLE IF EXISTS usuario;

CREATE TABLE usuario(
    id int AUTO_INCREMENT primary key,
    ci VARCHAR(350) NOT NULL,
    num_tarjeta VARCHAR(350) NOT NULL,
    nombre VARCHAR(350) NOT NULL,
    image VARCHAR(500) DEFAULT '',
    fecha_nac DATE NOT NULL,
    apellido VARCHAR(350) NOT NULL,
    email VARCHAR(350) NOT NULL,
    celular VARCHAR(350) NOT NULL,
    nota VARCHAR(350) NULL default '',
    dirrecion VARCHAR(350) NOT NULL,
    usuario VARCHAR(350) NOT NULL,
    password VARCHAR(350) NOT NULL,
    estado VARCHAR(350) DEFAULT 'creado',
    proyecto_id int NOT NULL,
    rol_id int NOT NULL,
    creado_por int NOT NULL
);

DROP TABLE IF EXISTS controlador;

CREATE TABLE controlador(
    id int AUTO_INCREMENT primary key,
    nombre VARCHAR(350) NOT NULL,
    decripcion VARCHAR(350) NOT NULL,
    protocolo VARCHAR(350) NOT NULL,
    ip_address VARCHAR(350) DEFAULT '',
    port int NOT NULL,
    timeout int NOT NULL,
    password VARCHAR(350) NOT NULL
);

DROP TABLE IF EXISTS proyecto;
CREATE TABLE proyecto(
    id int AUTO_INCREMENT primary key,
    nombre VARCHAR(350) NOT NULL,
    descripcion VARCHAR(350) NOT NULL,
    dirrecion VARCHAR(350) NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NULL,
    telefono VARCHAR(20) NOT NULL,
    email VARCHAR(350) NOT NULL,
    estado VARCHAR(350) DEFAULT 'creado'
);