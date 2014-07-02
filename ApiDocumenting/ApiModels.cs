using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDocumenting
{
  public class ApiModels
  {

    public ApiModels()
    {
      Methods = new ApiMethodCollection();
    }


    public ApiMethodCollection Methods
    {
      get;
      private set;
    }

    public ApiTypeCollection Types
    {
      get;
      private set;
    }




    private static ApiModels _models;


    public static ApiModels Current
    {
      get { return _models; }
    }


    public ApiMethodDescriptor GetMethod( string methodName )
    {

      lock ( _sync )
      {

        if ( !Methods.Contains( methodName ) )
          return null;


        return Methods[methodName];
      }
    }


    private object _sync = new object();
  }
}
