using System;
using System.Collections;
using BaseBusiness.bc;
using BaseBusiness.util;


namespace BaseBusiness.bc
{
    /// <summary>
    /// Summary description for PMSBaseFacade.
    /// </summary>

    public class BaseFacadeDB : BaseFacade
    {
        protected BaseFacadeDB() : base(DBUtils.GetDBConnectionString())
        {
        }

        public BaseFacadeDB(BaseModel baseModel) : base(baseModel, DBUtils.GetDBConnectionString())
        {
        }

        protected override BaseModel PopulateModel(Microsoft.Data.SqlClient.SqlDataReader dr, string className)
        {
            Object model = Activator.CreateInstance(Type.GetType("BaseBusiness.Model." + className));
            return (BaseModel)PropertyUtils.PopulateObject(dr, model);
        }

        protected override BaseModel PopulateModel(Microsoft.Data.SqlClient.SqlDataReader dr, string className, ArrayList list)
        {
            Object model = Activator.CreateInstance(Type.GetType("BaseBusiness.Model." + className));
            return (BaseModel)PropertyUtils.PopulateObject(dr, model, list);
        }
    }
}
