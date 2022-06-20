DROP DATABASE IF EXISTS aplus_access;
CREATE database aplus_access  CHARACTER SET 'UTF8' COLLATE 'utf8_general_ci';
use aplus_access;

CREATE TABLE usuario(
    id int AUTO_INCREMENT primary key,
    nombre VARCHAR(350) NOT NULL,
    apellido VARCHAR(350) NOT NULL,
    email  VARCHAR(350) NOT NULL,
    celular VARCHAR(350) NOT NULL,
    dirrecion VARCHAR(350) NOT ,
    usuario VARCHAR(350) NOT NULL,
    rol VARCHAR(350) NOT NULL,
    password VARCHAR(350) NOT NULL
);