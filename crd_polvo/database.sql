create database crud_polvo;
create table polvo(
	codigo_polvo int primary key not null,
	especie VARCHAR(20) not null,
	habitat VARCHAR(25) NOT NULL,
	tamanho VARCHAR(10) not NULL,
	peso INT NOT NULL,
	cor VARCHAR(15) not null
);