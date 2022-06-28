using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.InteropServices;

namespace zktco_access.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //arrancador 
        IntPtr h = IntPtr.Zero;
        //instanciando como  libreria externa
        [DllImport("plcommpro.dll", EntryPoint = "Connect")]
        public static extern IntPtr Connect(string Parameters);
       
        //get user 
        [DllImport("plcommpro.dll", EntryPoint = "GetDeviceData")]
        public static extern int GetDeviceData(IntPtr h, ref byte buffer, int buffersize, string tablename, string filename, string filter, string options);
        [DllImport("plcommpro.dll", EntryPoint = "PullLastError")]
        public static extern int PullLastError();
        // variables
        public string protocolo ="TCP";
        public string ipaddress = "192.168.88.10";
        public string port = "4370";
        public string timeout = "2000";
        public string passwd = "";
        private bool conexion_controller()
        {
            string cadena = "protocol="+ protocolo+",ipaddress=" + ipaddress + ",port="+ port + ",timeout="+ timeout + ",passwd="+ passwd;
          
                h = Connect(cadena);
                if (h != IntPtr.Zero)
                {
                    return true;
                }
                else
                {
                return false;
            }
           
           
        }
        /*
         * inicio de api test
         */
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "test")]
        public String Get()
        {
            if (this.conexion_controller())
            {

                return "conectado";

            }
            else
            {
                return "erro";
            }
            ;
            /*return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();*/
            
        }
    }
}