using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod4.Components.Pages
{
    public partial class Register // partial class bc other half exists in Register.razor (where we have @code{ })
    {
        Employee emp = new Employee();
        List<CountryNames> countryNames = new List<CountryNames>()
        {
            new CountryNames(){CID = 1,CName = "Canada"},
            new CountryNames(){CID = 2,CName = "USA"},
            new CountryNames(){CID = 3,CName = "New Zealand"}
        };
    }
}
