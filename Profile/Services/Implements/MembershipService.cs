using BaseBusiness.util;
using Microsoft.Data.SqlClient;
using Profile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Services.Implements
{
    public class MembershipService : IMembershipService
    {
        public DataTable SearchProfileMembership(int profileID, string inactive, string id)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@ProfileID", profileID),
                    new SqlParameter("@Inactive", inactive),
                    new SqlParameter("@ID", id),

                };

                DataTable myTable = DataTableHelper.getTableData("spProfileMemberTypeSearch", param);
                return myTable;
            }
            catch (SqlException ex)
            {

                throw new Exception($"ERROR: {ex.Message}", ex);
            }
        }
    }
}
