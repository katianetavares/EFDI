using System;

namespace Exceptions
{
    public class ProductException : Exception
    {
      public ProductException(string message) : base(message) {

      }
    }
}
