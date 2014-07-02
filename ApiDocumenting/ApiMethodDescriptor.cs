using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDocumenting
{
  public class ApiMethodDescriptor
  {

    public string MethodName { get; set; }

    public ApiParameterDescriptor[] Parameters { get; set; }

    public ApiTypeDescriptor Result { get; set; }


  }
}
