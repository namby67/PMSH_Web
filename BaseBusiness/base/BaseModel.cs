using System;
using System.Collections;
using System.Reflection;
using System.Text;
using BaseBusiness.util;

namespace BaseBusiness.bc
{
	/// <summary>
	/// Summary description for BaseModel.
	/// </summary>
	public class BaseModel : ICloneable
	{

		public virtual long GetID()
		{
			return 0;
		}
        public virtual string GetStringID()
        {
            return ""; // tr? v? giá tr? m?c ??nh, override ? model con n?u c?n
        }

        protected int userID = 0;
		public void SetUserID (int id)
		{
			this.userID = id;
		}

		public int GetUserID()
		{
			return this.userID;
		}

		

		/// <summary>
		/// Clone the object, and returning a reference to a cloned object.
		/// </summary>
		/// <returns>Reference to the new cloned 
		/// object.</returns>
		public object Clone()
		{
			//First we create an instance of this specific type.
			object newObject = Activator.CreateInstance(this.GetType());

			//We get the array of fields for the new type instance.
			FieldInfo[] fields = newObject.GetType().GetFields();

			int i = 0;

			foreach (FieldInfo fi in this.GetType().GetFields())
			{
				//We query if the fiels support the ICloneable interface.
				Type ICloneType = fi.FieldType.GetInterface("ICloneable", true);

				if (ICloneType != null)
				{
					//Getting the ICloneable interface from the object.
					ICloneable IClone = (ICloneable) fi.GetValue(this);

					if (IClone == null)
						continue; // Unitialized in source, so skip the copying

					//We use the clone method to set the new value to the field.
					fields[i].SetValue(newObject, IClone.Clone());
				}
				else
				{
					// If the field doesn't support the ICloneable 
					// interface then just set it.
					fields[i].SetValue(newObject, fi.GetValue(this));
				}

				//Now we check if the object support the 
				//IEnumerable interface, so if it does
				//we need to enumerate all its items and check if 
				//they support the ICloneable interface.
				Type IEnumerableType = fi.FieldType.GetInterface("IEnumerable", true);
				if (IEnumerableType != null)
				{
					//Get the IEnumerable interface from the field.
					IEnumerable IEnum = (IEnumerable) fi.GetValue(this);

					//This version support the IList and the 
					//IDictionary interfaces to iterate on collections.
					Type IListType = fields[i].FieldType.GetInterface("IList", true);
					Type IDicType = fields[i].FieldType.GetInterface("IDictionary", true);

					int j = 0;
					if (IListType != null)
					{
						//Getting the IList interface.
						IList list = (IList) fields[i].GetValue(newObject);

						foreach (object obj in IEnum)
						{
							//Checking to see if the current item 
							//support the ICloneable interface.
							ICloneType = obj.GetType().GetInterface("ICloneable", true);

							if (ICloneType != null)
							{
								//If it does support the ICloneable interface, 
								//we use it to set the clone of
								//the object in the list.
								ICloneable clone = (ICloneable) obj;
								list[j] = clone.Clone();
							}

							//NOTE: If the item in the list is not 
							//support the ICloneable interface then in the 
							//cloned list this item will be the same 
							//item as in the original list
							//(as long as this type is a reference type).

							j++;
						}
					}
					else if (IDicType != null)
					{
						//Getting the dictionary interface.
						IDictionary dic = (IDictionary) fields[i].GetValue(newObject);
						j = 0;

						foreach (DictionaryEntry de in IEnum)
						{
							//Checking to see if the item 
							//support the ICloneable interface.
							ICloneType = de.Value.GetType().GetInterface("ICloneable", true);

							if (ICloneType != null)
							{
								ICloneable clone = (ICloneable) de.Value;
								dic[de.Key] = clone.Clone();
							}
							j++;
						}
					}
				}
				i++;
			}
			return newObject;
		}

		public StringBuilder ToXML()
		{
			PropertyInfo[] propertiesName = this.GetType().GetProperties();
			string name = this.GetType().Name;
			name = name.Substring(0, name.Length - 5);

			StringBuilder xml = new StringBuilder();
			xml.Append("<record id='" + this.GetType().GetProperty(name + "ID").GetValue(this, null) + "'>");
			for (int i = 0; i < propertiesName.Length; i++)
			{
				//if(!propertiesName[i].Name.Equals(this.GetType().Name.Substring(0,this.GetType().Name.Length-5)+"ID"))
				{
					xml.Append("<" + propertiesName[i].Name + ">" + propertiesName[i].GetValue(this, null) + "</" + propertiesName[i].Name + ">");
				}
			}
			return xml.Append("</record>");
		}


		public virtual string CompareTo(BaseModel model)
		{
			StringBuilder result = new StringBuilder();
			string modelName = this.GetType().Name;
			string fID = modelName.Substring(0, modelName.Length - 5) + "ID";
			string[] fields = GetAuditFields();
			if(model==null)
			{
				foreach (string field in fields)
				{
					if(field.Equals(fID)) continue;
					object value1 = PropertyUtils.GetValue(this, field);
					result.Append(string.Format("- {0}: {1}<br>", field, value1));
				}
			}
			else
			{
				if (this.GetType() != model.GetType()) return "None";
				
				foreach (string field in fields)
				{
					if(field.Equals(fID)) continue;
					object value1 = PropertyUtils.GetValue(this, field);
					object value2 = PropertyUtils.GetValue(model, field);
					if (!value1.Equals(value2))
					{
						result.Append(string.Format("- {0}: {1} -> {2}<br>", field, value2, value1));
					}
				}
			}
			return result.Length > 0 ? result.ToString() : "None";
		}

		public virtual string[] GetAuditFields()
		{
			PropertyInfo[] list = this.GetType().GetProperties();
			string[] r = new string[list.Length];
			for (int i = 0; i < list.Length; i++)
			{
				r[i] = list[i].Name;
			}
			return r;
		}

		protected int auditType = -100;
		public void SetAuditType (int id)
		{
			this.auditType = id;
		}

		public virtual int GetAuditType()
		{
			return this.auditType;
		}
		public virtual string GetOrderBy()
		{
			return "";
		}
		public string orderFieldName;
		public string GetOrderFieldName()
		{
			if(orderFieldName != null && orderFieldName.Length > 0)
				return orderFieldName;
			else
				return this.GetID().ToString();

		}
		public void SetOrderFieldName(string value)
		{
			this.orderFieldName = value;
		}
		public virtual string ToString()
		{
			return "";
		}
        public virtual string GetTableName()
        {
            return this.GetType().Name.Replace("Model", "");
        }
        public virtual string GetPrimaryKeyName()
        {
            return "ID";
        }

    }
	
}