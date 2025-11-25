using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BaseBusiness.util
{
	/// <summary>
	/// Summary description for Expression.
	/// </summary>
	public class Expression
	{
		public Expression() : this(1, 1, "=")
		{
			//
			// TODO: Add constructor logic here
			//

		}

		public Object exp1;
		public Object exp2;
		public String op;
		public static List<Expression> list = new List<Expression>();

		public Expression(Object exp1, Object exp2) : this(exp1, exp2, "=")
		{
		}

		public Expression(string exp1, string exp2, string Operator) : this((Object)exp1, (Object)exp2, Operator)
		{
		}

		public Expression(string exp1, int exp2, string Operator) : this((Object)exp1, (Object)exp2, Operator)
		{
		}

		public Expression(Object exp1, Object exp2, String op)
		{
			if (exp1 is string)
			{
				this.exp1 = "$" + (string)exp1;
			}
			else
			{
				this.exp1 = exp1;
			}
			if (op.ToUpper().Equals("IN"))
			{
				this.exp2 = "(" + exp2 + ")";
			}
			else if (op.ToUpper().Equals("NOT IN"))
			{
				this.exp2 = "(" + exp2 + ")";
			}
			else if (op.ToUpper().Equals("LIKE"))
			{
				this.exp2 = "%" + exp2 + "%";
			}
			else if (op.ToUpper().Equals("LIKE_STRICT"))
			{
				this.op = "LIKE";
				this.exp2 = exp2;
				return;
			}
			else
			{
				this.exp2 = exp2;
			}
			this.op = op;
		}


		public Expression And(Expression exp2)
		{
			return new Expression(this, exp2, "AND");
		}

		public Expression Or(Expression exp2)
		{
			return new Expression(this, exp2, "OR");
		}

		public Expression And(Object exp1, Object exp2, string op)
		{
			return new Expression(this, new Expression(exp1, exp2, op), "AND");
		}

		public Expression Or(Object exp1, Object exp2, string op)
		{
			return new Expression(this, new Expression(exp1, exp2, op), "OR");
		}

		public Expression And(Object exp1, Object exp2)
		{
			return And(exp1, exp2, "=");
		}

		public Expression Or(Object exp1, Object exp2)
		{
			return Or(exp1, exp2, "=");
		}

		public override string ToString()
		{
			return ToString(exp1) + " " + op + " " + ToString(exp2);
		}

		private String ToString(Object exp)
		{
			if (exp == null) return " ";
			if (exp is string)
			{
				string tmp = exp.ToString();
				if (tmp.StartsWith("$")) return tmp.Substring(1);
				if (tmp.StartsWith("(")) return tmp;
				return "N'" + exp.ToString().Replace("'", "''") + "'";
			}
			else if (exp is DateTime)
			{
				return "'" + ((DateTime)exp).ToString("yyyy/MM/dd HH:mm:ss") + "'";
			}
			else if (exp is Expression)
			{
				return "(" + exp.ToString() + ")";
			}
			return exp.ToString();
		}

		/*
		 * TuanLA@2023-08-22 added new function removeSpecialChars
		 * Function to remove all characters except these characters 1-9, a-z & A-Z
		 */
		private string removeSpecialChars(string input)
		{
			return Regex.Replace(input, @"[^1-9a-zA-Z]", "");
		}


		/*
		 * TuanLA@2023-08-21 added new function ToSQLParametersString
		 * Base on the expression, it convert SQL Command to use gets the result by passing the values through SQL Parameters
		 */
		public string ToSQLParametersString()
		{
			if (exp1 != null && exp2 != null)
			{
				if (exp1 is Expression && exp2 is Expression)
				{
					return ((Expression)exp1).ToSQLParametersString() + " " + op + " " + ((Expression)exp2).ToSQLParametersString();
				}
				else
				{
					return ToString(exp1) + " " + op + " @" + removeSpecialChars(exp1.ToString());
				}
			}

			return string.Empty;
		}

		/*
		 * TuanLA@2023-08-21 added new function ToList
		 * Base on the big expression, This function will split big expression into small expression(the list of small expression)
		 */
		public List<Expression> ToList(bool init = true)
		{
			if (init) list = new List<Expression>();

			if (exp1 != null && exp2 != null)
			{
				if (exp1 is Expression && exp2 is Expression)
				{
					((Expression)exp1).ToList(false);
					((Expression)exp2).ToList(false);
				}
				else
				{
					this.exp1 = removeSpecialChars(this.exp1.ToString());
					list.Add(this);
					return list;
				}
			}
			return list;

		}
	}
}