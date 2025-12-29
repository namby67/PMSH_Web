using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Services.Interfaces
{
    public interface IMembershipService
    {
        /// <summary>
        /// DatVP: Lây danh sách profile history
        /// </summary>
        /// <param name="profileID">id profile</param>
        /// <param name="type">type</param>
        /// <param name="confirmationNo">confirmation no</param>
        /// <returns>Data table chứa danh sách profile history</returns>
        DataTable SearchProfileMembership(int profileID, string inactive, string id);
    }
}
