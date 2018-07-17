using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   class SingletonLazy
   {
      private static readonly Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(()=> new SingletonLazy());

      private SingletonLazy()
      {
 
      }

      public static SingletonLazy getInstace 
      {
         get{
              return instance.Value;
         }
      }
   }
}
