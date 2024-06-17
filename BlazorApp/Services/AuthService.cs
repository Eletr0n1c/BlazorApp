using BlazorApp.Reponses;
using BlazorApp.Responses;
using Blazored.LocalStorage;

namespace BlazorApp.Services
{
    /// <summary>
    /// Classe para implementar as rotinas de manipulação da local storage
    /// voltado para autenticação de usuários.
    /// </summary>
    public class AuthService
    {
        //atributos
        private readonly ILocalStorageService _localStorageService;

        public AuthService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        /// <summary>
        /// Método para gravar os dados do usuário autenticado na local storage
        /// </summary>
        public async Task SignIn(AutenticarResponse response)
        {
            await _localStorageService.SetItemAsync("auth", response);
        }

        /// <summary>
        /// Método para ler os dados do usuário autenticado na local storage
        /// </summary>
        public async Task<AutenticarResponse?> GetData()
        {
            return await _localStorageService.GetItemAsync<AutenticarResponse>("auth");
        }

        /// <summary>
        /// Método para apagar os dados gravados na local storage
        /// </summary>
        public async Task SignOut()
        {
            await _localStorageService.RemoveItemAsync("auth");
        }

    }
}
