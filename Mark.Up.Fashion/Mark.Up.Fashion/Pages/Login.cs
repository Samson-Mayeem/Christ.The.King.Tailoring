using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Components;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using Mark.Up.Fashion.Models.Users;
using MySqlConnector;

namespace Mark.Up.Fashion.Pages
{
	
		public class Login : ComponentBase
		{
			[Inject]
			protected NavigationManager NavigationManager { get; set; }

			protected string Email { get; set; }
			protected string Password { get; set; }
		private string _connectionString = "MySQLConnection";
		protected async Task HandleValidSubmit()
			{

				using (var connection = new MySqlConnection(_connectionString))
				{
					// Query the database to check if the provided username and password match a user in the database
					var user = await connection.QueryFirstOrDefaultAsync<User>(
						"SELECT * FROM `christfashion.users` WHERE `email` = @Email AND `password` = @Password",
						new { Email, Password });

					if (user != null)
					{
						// The login was successful, so navigate to the home page
						NavigationManager.NavigateTo("/userdashboard");
					}
					else
					{
						// The login was unsuccessful, so display an error message
						
						// TODO: Display error message
					}
				}
			}
		}
}



