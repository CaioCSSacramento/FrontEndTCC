using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using appTCC.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using appTCC.Models;
using appTCC.Util;
using appTCC.ViewModel;

namespace appTCC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class login : ContentPage
	{
        public login ()
		{
			InitializeComponent ();

        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {

            try
            {
                Aluno aluno = null;

                //ativa o metodo de login na viewmodel, atribuindo os dados do aluno ao objeto criado na view.
                aluno = await ViewModelAutenticar.Login(txtEmail.Text, txtSenha.Text);

                if (aluno.alun_cpf != null)
                {
                    if (aluno.alun_email == "admin@puc.com.br")
                    {
                        await Navigation.PushModalAsync(new menuAdm(), true);
                    }
                    else
                    {
                        await Navigation.PushModalAsync(new menuAluno(), true);
                    }
                }
                else
                {
                    await DisplayAlert("", "Credenciais Inválidas", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }

            
        }
    }
}