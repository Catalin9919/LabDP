using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Table:Element
    {
        private string _tableName;

        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        public Table(string tableTitle)
        {
            TableName = tableTitle;
        }

        public override void Print()
        {
            Console.WriteLine($"Table name: {_tableName}");
        }
    }
}
