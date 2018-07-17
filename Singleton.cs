using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public sealed class Singleton
   {
      private Singleton()
      {
 
      }

      private Singleton instance = null;
      private object obj = new object();

      public Singleton getInstance 
      { 
         get
         {
            if (instance == null)
            {
               lock (obj)
               {
                  if (instance == null)
                     instance = new Singleton();
               }
            }
            return instance;
         }
      }
   }
}
   