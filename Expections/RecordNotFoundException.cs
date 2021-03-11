using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expections
{
    public class RecordNotFoundException:Exception//exceptiondan inherit ettik
    {
        public RecordNotFoundException(string message):base(message)
        {

        }
    }
}
