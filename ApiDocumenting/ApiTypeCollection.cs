using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDocumenting
{
  public class ApiTypeCollection : KeyedCollection<string, ApiTypeDescriptor>
  {



    protected override string GetKeyForItem( ApiTypeDescriptor item )
    {
      return item.TypeName;
    }
  }
}
