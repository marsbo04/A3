using dimvetral.Models.Repo;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace dimvetral.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly ILoginAuthenticator _authenticator;
        private string _userId;
        private string _password;
        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value;  }
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        public LoginViewModel()
        {

        }
        public LoginViewModel(ILoginAuthenticator authenticator)
        {
   
        }

        public bool ValidateLogin(string username, string pass)
        {
            return true; 
        }


    }
}