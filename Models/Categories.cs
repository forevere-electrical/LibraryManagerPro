using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Categories
    {
        // Book Category Id: 1~5
        public int CategoryId { get; set; }

        // Book Category Name: 1. Computer Software, 2. Computer Hardware, 3. Software Engineering, 4. Network Engineering, 5. Security
        public string CategoryName { get; set; }

    }
}
