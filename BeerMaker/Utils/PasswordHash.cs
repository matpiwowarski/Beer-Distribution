using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Utils
{
    // tutaj bez zmian
    public static class PasswordHash
    {
        public static string Create(Guid guid, string password)
        {
            return "hashed";
        }
    }
}
