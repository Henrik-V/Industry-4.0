using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TemperatureReader.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace TemperatureReader.Pages
{
    public class IndexModel : PageModel
    {
        public string chartUnit;
        public float sampleTime;
        
        readonly IConfiguration _configuration;

        public List<TemperatureStatistics> temperatureStatisticsList = new List<TemperatureStatistics>();
        public List<Temperature> temperatureList = new List<Temperature>();

        public string connectionString;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            Temperature temperature = new Temperature();

            TemperatureStatistics temperatureStatistics = new TemperatureStatistics();

            connectionString = _configuration.GetConnectionString("ConnectionString");

            temperatureStatisticsList = temperatureStatistics.GetTemperatureStatistics(connectionString);

            //chartUnit = temperatureStatisticsList[0].TemperatureUnit;

            temperatureList = temperature.GetTemperature(connectionString);
        }

        public async Task<IActionResult> OnPost()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);

            string sqlQuery = "select * from CONFIGURATIONDATA";

            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader != null)
            {
                while(dataReader.Read())
                {
                    chartUnit = dataReader["TemperatureUnit"].ToString();
                }
            }
            connection.Close();

            if (chartUnit == "Celsius         ")
                sqlQuery = "EXEC SetUnit Fahrenheit";
            else
                sqlQuery = "EXEC SetUnit Celsius";

            connection.Open();
            SqlCommand command2 = new SqlCommand(sqlQuery, connection);
            command2.ExecuteNonQuery();
            connection.Close();
            return RedirectToPage("./Index");
        }
    }
}
