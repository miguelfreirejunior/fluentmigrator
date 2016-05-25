using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FluentMigrator.Runner
{
    public class DataSetContainer : IDataSet
    {
        public DataSet DataSet { get; private set; }

        public DataSetContainer(DataSet dataSet) {
            this.DataSet = dataSet;
        }

        public void Dispose() {
            DataSet.Dispose();
        }
    }
}
