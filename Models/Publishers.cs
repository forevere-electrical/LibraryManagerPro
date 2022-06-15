using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Publishers
    {
        // Publisher Id in the system
        public int PublisherId { get; set; }

        // Publisher Name in the system
        public string PublisherName { get; set; }   
    }
}
