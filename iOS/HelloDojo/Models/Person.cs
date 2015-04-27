using System;
using Assisticant.Fields;

namespace HelloDojo
{
	public class Person
	{
		readonly Observable<string> _name = new Observable<string>();

		public string Name 
		{
			get { return _name.Value; }
			set { _name.Value = value; }
		}
	}
}

