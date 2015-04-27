using System;
using Assisticant.Fields;

namespace HelloDojo
{
	public class PersonSelection
	{
		readonly Observable<string> _newName = new Observable<string>();
		public string NewName
		{
			get { return _newName.Value; }
			set { _newName.Value = value; }
		}
	}
}

