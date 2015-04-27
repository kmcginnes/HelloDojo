using System;

namespace HelloDojo
{
	public class PersonHeaderViewModel
	{
		readonly Person _person;

		public PersonHeaderViewModel(Person person)
		{
			_person = person;
		}

		public string Name 
		{ 
			get 
			{
				return string.IsNullOrWhiteSpace(_person.Name)
					? "<no name>"
					: _person.Name;
			} 
		}
	}
}

