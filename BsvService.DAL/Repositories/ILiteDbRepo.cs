using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsvService.DAL.Repositories
{
    interface ILiteDbRepo
    {
        string CollectionName { get; set; }
    }
}
