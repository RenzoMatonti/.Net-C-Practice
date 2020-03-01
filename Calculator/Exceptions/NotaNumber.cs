using System;
using System.Collections.Generic;
using System.Text;

namespace Test {
    class NotaNumber : ApplicationException {

        public override string Message{
            get
            {
                return "Input is not a number";
            }
        }
    }
}
