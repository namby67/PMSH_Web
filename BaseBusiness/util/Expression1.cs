using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BaseBusiness.util
{
	/// <summary>
	/// Summary description for Expression.
	/// </summary>
	public class Expression1
    {
        private object exp1;
        private object exp2;
        private string op;
        private ArrayList parameters;

        public Expression1(Object exp1, Object exp2) : this(exp1, exp2, "=")
        {
        }

        public Expression1(string exp1, string exp2, string op) : this((Object)exp1, (Object)exp2, op)
        {
        }

        public Expression1(string exp1, int exp2, string op) : this((Object)exp1, (Object)exp2, op)
        {
        }

        public Expression1(Object exp1, Object exp2, string op)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
            this.op = op;

            parameters = new ArrayList();
            if (exp1 is string)
            {
                parameters.Add(new SqlParameter("@param1", exp2));
            }
            else
            {
                parameters.Add(new SqlParameter("@param2", exp2));
            }
        }

        public Expression1 And1(Expression1 exp2)
        {
            return new Expression1(this, exp2, "AND");
        }

        public Expression1 Or1(Expression1 exp2)
        {
            return new Expression1(this, exp2, "OR");
        }

        public void SetParameters(SqlCommand command)
        {
            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
        }

        public override string ToString()
        {
            return ToString(exp1) + " " + op + " " + ToString(exp2);
        }

        private string ToString(object exp)
        {
            return exp.ToString();
        }
    }
}