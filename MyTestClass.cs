using System.Collections.Generic;
using System.Linq;

namespace MyTestLib
{
    // Test class with a single method
    public class MyTestClass
    {
        // Returns the sum of all the values in the list
        #region Methods
        public double SumListValues(List<double> values)
        {
            return values.Sum();
        }
        #endregion
    }
}
