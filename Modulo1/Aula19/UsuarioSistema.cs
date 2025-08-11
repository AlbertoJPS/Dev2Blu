using Aula19.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19

{//validar -  verificar senha, usuarios e etc
 //autenticação - registro de um login bem sucedido, um token, etc

    internal class UsuarioSistema : IAutenticavel
    {     
        public static List<UsuarioSistema> _Autenticacoes = new List<UsuarioSistema>();

        public void Logar(string user, string password)
        {
            UserInfo usuarioSelecionado = null;

            foreach (var userInfo in UserInfo._AllUsers)
            {
                if (userInfo.User == user)
                {
                    usuarioSelecionado = userInfo;
                    break;
                }
            }

            if(usuarioSelecionado == null || usuarioSelecionado.Password != password)
            {
                throw new Exception("Usuário ou senha incorretos.");
            }
            
            Autenticar();
        }
        public void Autenticar()
        {
            _Autenticacoes.Add(this);
            Console.WriteLine("\nUsuário Autenticado!");
        }

        public void Deslogar()
        {
            _Autenticacoes.Remove(this);
        }

        //---------------------------------------------------------------------------------------

        //public static List<UsuarioSistema> _UsuarioSistemas = new List<UsuarioSistema>();
        //public static UsuarioSistema _UsuarioLogado = null;

        //private string _Senha = null;
        //public string UserName { get; set; }
        //public string Password { get; set; }

        //public void Autenticar()
        //{
        //    Console.Write("\nDigite seu nome de usuário: ");
        //    string userName = Console.ReadLine();
        //    Console.Write("\nDigite sua senha: ");
        //    string password = Console.ReadLine();

        //    if (this.UserName == userName && this.Password == password)
        //    {
        //        Console.WriteLine("\nLogin realizado com sucesso!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nUsuário ou senha inválidos. Tente novamente.");
        //    }
        //}
        //public void Deslogar()
        //{

        //}
        //public void CadastrarUsuario()
        //{
        //    PedirUserName();
        //    ConfirmarSenha();
        //    _UsuarioSistemas.Add(this);
        //}
        //public void PedirUserName()
        //{
        //    Console.WriteLine("\nDigite o nome de usuário:");
        //    UserName = Console.ReadLine();
        //}
        //public void ConfirmarSenha()
        //{
        //    bool senhaInvalida = true;
        //    _Senha = PedirSenha(1);

        //    do
        //    {
        //        if (string.IsNullOrEmpty(_Senha))
        //        {
        //            Console.WriteLine("\nSenha não pode ser vazia. Tente novamente.");
        //            PedirSenha(1);
        //            return;
        //        }
        //        else
        //        {
        //            if (_Senha != PedirSenha(2))
        //            {
        //                Console.WriteLine("\nAs senhas não coincidem. Tente novamente.");
        //                PedirSenha(2);
        //            }
        //            else
        //            {
        //                Password = _Senha;
        //                Console.WriteLine("\nUsuário cadastrado com sucesso!");
        //                senhaInvalida = false;
        //            }
        //        }

        //    }while (senhaInvalida);

        //}
        //public string PedirSenha(int step)
        //{
        //    if (step == 1)
        //    {
        //        Console.WriteLine("\nDigite a senha:");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nConfirme a senha:");
        //    }
        //    return Console.ReadLine();
        //}

    }
}
