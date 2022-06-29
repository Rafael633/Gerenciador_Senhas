using System;
using System.Linq;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class SenhaController
    {
        public static Senha IncluirSenha(string Nome, int CategoriaId, string Url, string Usuario, string SenhaEncrypt, string Procedimento)
        {
            if(String.IsNullOrEmpty(Nome))
            {
                throw new Exception("Nome inválido");
            }
            if(String.IsNullOrEmpty(Url))
            {
                throw new Exception("Url inválido");
            }
            if(String.IsNullOrEmpty(Usuario))
            {
                throw new Exception("Usuário inválido");
            }
            if(String.IsNullOrEmpty(SenhaEncrypt))
            {
                throw new Exception("Senha inválida");
            }
            if(String.IsNullOrEmpty(Procedimento))
            {
                throw new Exception("Procedimento inválido");
            }

            return new Senha(Nome, CategoriaId, Url, Usuario, SenhaEncrypt, Procedimento);
        }

        public static Senha AlterarSenha(int Id, string Nome, int CategoriaId, string Url, string Usuario, string SenhaEncrypt, string Procedimento)
        {
            Senha senha = Models.Senha.GetSenha(Id);
            if (!String.IsNullOrEmpty(Nome) && !String.IsNullOrEmpty(Url) && !String.IsNullOrEmpty(Usuario) && !String.IsNullOrEmpty(SenhaEncrypt) && !String.IsNullOrEmpty(Procedimento) && CategoriaId != 0)
            {
                senha.Nome = Nome;
                senha.Url = Url;
                senha.Usuario = Usuario;
                senha.SenhaEncrypt = SenhaEncrypt;
                senha.Procedimento = Procedimento;
                senha.CategoriaId = CategoriaId;
            }

            return senha;
        }

        public static Senha RemoverSenha(int Id)
        {
            Senha senha = GetSenha(Id);
            Senha.RemoverSenha(senha);
            return senha;
        }

        public static Senha GetSenha(int Id)
        {
            Senha senha = (
                from Senha in Senha.GetSenhas()
                    where Senha.Id == Id
                    select Senha
            ).First();

            if(senha == null)
            {
                throw new Exception("Senha não encontrada");
            }

            return senha;
        }

        public static IEnumerable<Senha> VisualizarSenha()
        {
            return Models.Senha.GetSenhas();
        }
    }
}