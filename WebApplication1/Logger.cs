using System;
using System.IO;
using System.Web;

namespace WebApplication1
{
    public class Logger
    {
        //variable estática de la clase Logger
        private static string _logFolder;

        //Constructor estáticco 
        static Logger()
        {
            // El objeto HttpContext, nos da acceso a objetos relativos a la session Web en curso, como es el objeto Server
            // (using System.Web)
            // HttpContext no va a esta disponible cuando expire la session
            var server = HttpContext.Current.Server;

            // Fijamos el directorio <miRootSite>\Log para gurdar los logs
            // MapPath nos dice para una url  http://mySite/Log, al directorio fisico donde esta instalado el site
            // C:\Seminario.Net\MiCarpeta\WebApplication1
            _logFolder = server.MapPath(@"/Log");
        }

        public static void WriteLog(string message)
        {
            //Verifica si el directorio existe y si no lo crea
            //Directory tiene funciones para manipular directoris(using System.IO)
            if (!Directory.Exists(_logFolder))
            {
                Directory.CreateDirectory(_logFolder);
            }

            //Agrega la fecha actual como prefijo del mensaje
            message = DateTime.Now.ToString("yyyy/MM/dd hh:mm") + " - " + message;

            //Define el nombre del archivo para guardar los logs
            //Uso la extensión txt para que se pueda ver en un browser sin necesidad de configuraciones extra
            var filePath = _logFolder + @"\SiteLog.txt";

            // This text is added only once to the file.
            // File, tiene funciones para manipulacion de archivos  (using System.IO;) 
            // Aqui verifica si el archivo existe
            if (!File.Exists(filePath))
            {
                // Crea el archivo con el mensaje como contenido.
                string[] lines = { message };
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                //Le agrega un salto de linea al mensaje para que los ponga en distintas líneas
                message += Environment.NewLine;
                //Como el archivo existe le concatena el nuevo texto
                File.AppendAllText(filePath, message);
            }

        }

        public static void Clean()
        {
            //Obtiene la direccion en el disco a la url del log
            string filePath = HttpContext.Current.Server.MapPath(@"/Log/SiteLog.txt");
            //Si el archivo existe lo borra
            if (File.Exists(filePath))
            {
                File.Delete(filePath);   
            }

        }

    }
}