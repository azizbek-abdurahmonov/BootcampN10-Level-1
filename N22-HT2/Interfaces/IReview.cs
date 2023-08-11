using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2.Interfaces
{
    internal interface IReview
    {
        Guid Id { get; set; }
        int Star { get; set; }
        string Message { get; set; }
    }
}
