using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDocumenting
{
  public class ApiMethodCollection : KeyedCollection<string, ApiMethodDescriptor>
  {
    protected override string GetKeyForItem( ApiMethodDescriptor item )
    {
      return item.MethodName;
    }

    public void Set( ApiMethodDescriptor methodDescriptor )
    {

      Remove( methodDescriptor.MethodName );
      Add( methodDescriptor );
    }
  }
}
