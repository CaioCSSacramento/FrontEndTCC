using appTCC.Models;
using appTCC.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace appTCC.ViewModel
{
    class ViewModelAutenticar
    {
        public static async Task<Aluno> Login(string email, string senha)
        {
            Aluno aluno = null;
            Web vWeb = new Web();

            //Chama o metodo GetAutenticar do WebService passando email e senha como parametro para retornar o aluno encontrado, ou um objeto nulo.
            HttpResponseMessage response = await vWeb.client.GetAsync("/webServiceTCC/api/Aluno?email=" + email + "&senha=" + senha);
            response.EnsureSuccessStatusCode(); //lança um código de erro
            aluno = await response.Content.ReadAsAsync<Aluno>();

            return aluno;
        }
    }
}
