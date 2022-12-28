using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Components;
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
					var user = await connection.QueryFirstOrDefaultAsync<User>(
						"SELECT * FROM `christfashion`.`users` WHERE `email` = @Email AND `password` = @Password",
						new { Email, Password });

					if (user != null)
					{
						NavigationManager.NavigateTo("/userdashboard");
					}
					else
					{
						NavigationManager.NavigateTo("/display-items");
					}
				}
			}
		}
}



