using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFractionCalculation
{
    
    
        public readonly struct ReadOnlyStruct
        {
            public readonly int ReadonlyField;
            public  readonly string NonReadonlyField;

            public ReadOnlyStruct(int readonlyValue, string nonReadonlyValue)
            {
                ReadonlyField = readonlyValue;
                NonReadonlyField = nonReadonlyValue;
            }
        }

    
}
