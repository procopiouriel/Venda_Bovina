
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace Venda_Bovina
{
    internal static class Program
    {

        public static List<Cadastro_Rebanho> rebanho;//= Cadastro_Rebanho.JsonDesserealizarLista("C:\\Users\\proco\\source\\repos\\Venda Bovina\\Venda Bovina\\Banco.json");
        public static List<Button> botaoFoto = new List<Button>();
        public static List<Button> botaoFotoUsuario = new List<Button>();
        public static List<Fazendeiro> usuarios = new List<Fazendeiro>();
        public static List<Fazendeiro> usuarioOnline = new List<Fazendeiro>();
        public static List<string> caminhoFoto = new List<string>();


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            usuarios = Fazendeiro.JsonDesserealizarListaUsuario("C:\\Users\\proco\\source\\repos\\Venda Bovina\\Venda Bovina\\Banco Usuario.json");
            rebanho = Cadastro_Rebanho.JsonDesserealizarLista("C:\\Users\\proco\\source\\repos\\Venda Bovina\\Venda Bovina\\Banco.json");
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLoginUsuario());

        }
    }
}