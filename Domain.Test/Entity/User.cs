using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test.Entity
{
	public class User
	{
		public static List<User> users = new List<User>();

		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Patronymic { get; set; }
		public int Role { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public User()
		{

		}

		public User(int Id, string Name, string Surname, string Patronymic, int Role, string Login, string Password)
		{
			this.Id = Id;
			this.Name = Name;
			this.Surname = Surname;
			this.Patronymic = Patronymic;
			this.Role = Role;
			this.Login = Login;
			this.Password = Password;
		}
	}
}
