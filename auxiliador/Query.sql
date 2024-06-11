CREATE TABLE usu_usuarios (
    usu_id SERIAL PRIMARY KEY,
    usu_login VARCHAR(255) NOT NULL UNIQUE,
    usu_senha VARCHAR(255) NOT NULL
);

CREATE TABLE pra_parametros (
    pra_id SERIAL PRIMARY KEY,
    usu_idusuario INTEGER NOT NULL UNIQUE,
	pra_caminhogespam VARCHAR(2550 NOT NULL,
    CONSTRAINT fk_usu_idusuario FOREIGN KEY (usu_idusuario) REFERENCES usu_usuarios (usu_id)
);