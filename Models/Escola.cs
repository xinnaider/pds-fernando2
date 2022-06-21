using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscEstadual { get; set; }
        public string Tipo { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string Responsavel { get; set; }
        public string ResponsavelTelefone { get; set; }
        public string Email { get; set; } 
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        /*
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

            create table Curso(
            id_cur int primary key auto_increment,
            nome_cur varchar(300),
            cargaH_cur varchar(300),
            turno_cur varchar(300),
            descricao_cur varchar(300)
            );
         */



    }
}
