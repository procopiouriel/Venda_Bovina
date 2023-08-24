
using Newtonsoft.Json;

namespace Venda_Bovina
{
    internal static class Program
    {
        
        public static List<Cadastro_Rebanho> rebanho = new List<Cadastro_Rebanho>();
        public static List<Button> botaoFoto = new List<Button>();
        public static List<Button> botaoFotoUsuario = new List<Button>();
        public static List<Label> labelList = new List<Label>();
        public static List<Fazendeiro> usuarios = new List<Fazendeiro>();


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormCadastroUsuario());
            
        }
    }
}