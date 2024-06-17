namespace BlazorApp.Settings
{
    public class AppSettings
    {
        /// <summary>
        /// Mapeamento do endereço da API de usuários
        /// </summary>
        public static string ApiUsuarios => "http://localhost:5272/api/usuarios/";

        /// <summary>
        /// Mapeamento do endereço da API de agenda
        /// </summary>
        public static string ApiAgenda => "http://localhost:5198/api/tarefas/";
    }
}
