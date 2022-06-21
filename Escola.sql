create database sys_escola_db;
use sys_escola_db;

create table ProjetoEscola(
id_esc int primary key auto_increment,
nome_fantasia_esc varchar(255) not null,
razao_social_esc varchar(255) not null,
cnpj_esc varchar(18) not null,
insc_estadual_esc varchar(255) null,
tipo_esc varchar(20) not null,
data_criacao_esc date not null,
responsavel_esc varchar(300) not null,
responsavel_telefone_esc varchar(30) not null,
email_esc varchar(300) null,
telefone_esc varchar(30) not null,
rua_esc varchar(300) not null,
numero_esc varchar(300) not null,
bairro_esc varchar(300) not null,
complemento_esc varchar(300) not null,
cidade_esc varchar(300) not null,
estado_esc varchar(300) not null
);