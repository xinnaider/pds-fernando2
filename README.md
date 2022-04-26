# pds-fernando2

Repositório para serem postada atividades do Projeto de Desenvolvimento de Sistema

drop database if exists bd_escola;
create database bd_escola;
use bd_escola;

create table Escola (
id_esc int not null auto_increment,
nome_fantasia_esc varchar(300) not null,
razao_social_esc varchar(300) not null,
cnpj_esc varchar(300) not null,
insc_estadual_esc varchar(300) not null,
tipo_esc varchar(300) not null,
data_criacao_esc date not null,
responsavel_esc varchar(300) not null,
responsavel_telefone_esc varchar(300) not null,
email_esc varchar(300) not null,
telefone_esc varchar(300) not null,
rua_esc varchar(300) not null,
numero_esc varchar(300) not null,
bairro_esc varchar(300) not null,
complemento_Esc varchar(300) not null,
cep_esc varchar(300) not null,
cidade_esc varchar(300) not null,
estado_esc varchar(300) not null,
primary key(id_esc)
);
