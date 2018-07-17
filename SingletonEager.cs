﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public sealed class SingletonEager
   {
      private static readonly SingletonEager instance = new SingletonEager();

      private SingletonEager()
      {
 
      }

      public static SingletonEager getInstace 
      {
         get{
              return instance;
         }
      }
      
   }
}
