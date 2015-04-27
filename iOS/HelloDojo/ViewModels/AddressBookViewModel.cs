using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloDojo
{
	public class AddressBookViewModel
	{
		readonly AddressBook _addressBook;

		public AddressBookViewModel(AddressBook addressBook)
		{
			_addressBook = addressBook;
		}

		public IEnumerable<PersonHeaderViewModel> People 
		{
			get { return _addressBook.People.Select(x => new PersonHeaderViewModel(x)); }
		}
	}
}

