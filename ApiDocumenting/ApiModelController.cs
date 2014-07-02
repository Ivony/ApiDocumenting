using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ApiDocumenting
{
  public class ApiModelController : Controller
  {




    [HttpGet]
    public ActionResult ApiMethod( string methodName )
    {

      if ( methodName == null )
        return View( "AddMethod" );


      return View( ApiModels.Methods[methodName] );
    }

    [HttpPost]
    public ActionResult ApiMethod( ApiMethodDescriptor methodDescriptor )
    {

      ApiModels.Methods.Set( methodDescriptor );

      return RedirectToAction( "ApiMethod", new { methodName = methodDescriptor.MethodName } );

    }



    protected ApiModels ApiModels
    {
      get { return ApiModels.Current; }

    }

  }
}
