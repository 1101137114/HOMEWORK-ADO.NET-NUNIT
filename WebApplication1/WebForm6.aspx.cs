using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "select * from Student where id like @name or name like @name or age like @name or addr like @name ";
                    cmd.Parameters.Add(new SqlParameter("@name", "%" + txtSearch.Text + "%"));
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        gvResult.DataSource = dt;
                        gvResult.DataBind();
                        dr.Close();
                    }
                }
            }
        }

        //ExecuteScalar
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [dbo].[Student]([id],[name],[age],[addr])
                             VALUES
                               (@id
                               ,@name
                               ,@age
                               ,@addr);SELECT CAST(scope_identity() AS int);";
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("@id", txtID.Text));
                    cmd.Parameters.Add(new SqlParameter("@name", txtName.Text));
                    cmd.Parameters.Add(new SqlParameter("@age", txtAge.Text));
                    cmd.Parameters.Add(new SqlParameter("@addr", txtAddr.Text));

                    txtID.Text = cmd.ExecuteScalar().ToString();
                }
                btnSearch_Click(null, null);
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = @"update [Student] set [name] = @name, [age] = @age, [addr] = @addr
                             where id = @ID";
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ADODBConnectionString"].ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("@id", txtE_ID.Text));
                    cmd.Parameters.Add(new SqlParameter("@name", txtE_Name.Text));
                    cmd.Parameters.Add(new SqlParameter("@age", txtE_Age.Text));
                    cmd.Parameters.Add(new SqlParameter("@addr", txtE_Addr.Text));

                    cmd.ExecuteNonQuery();
                }
                btnSearch_Click(null, null);
            }
        }

        protected void gvResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}