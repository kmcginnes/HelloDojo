using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloDojo
{
	public class AddressBookViewModel
	{
		readonly AddressBook _addressBook;
		readonly PersonSelection _personSelection;

		public AddressBookViewModel(AddressBook addressBook, PersonSelection personSelection)
		{
			_addressBook = addressBook;
			_personSelection = personSelection;
		}

		public void AddPerson()
		{
			var person = _addressBook.NewPerson();
			person.Name = NewName;
			NewName = string.Empty;
		}

		public IEnumerable<PersonHeaderViewModel> People 
		{
			get 
			{ 
				return _addressBook.People
					.Select(x => new PersonHeaderViewModel(x))
					.OrderBy(x => x.Name);
			}
		}

		public string NewName
		{
			get { return _personSelection.NewName; }
			set { _personSelection.NewName = value; }
		}
	}
}

