    using System;
    using System.Data.SqlClient;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    namespace class_projecct_2
    {
        public partial class WebForm1 : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
            }

            protected void name_TextChanged(object sender, EventArgs e)
            {
            }

            protected void btn_reg_Click(object sender, EventArgs e)
            {
                if (Page.IsValid)
                {
                    string ConnectionString =
                        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.net Project\class_projecct-2\App_Data\Database1.mdf;Integrated Security=True";

                    SqlConnection con = new SqlConnection(ConnectionString);

                    try
                    {
                        // Save password values BEFORE database operation
                        string password = pass.Text;
                        string confirmPassword = confrim.Text;

                        string Query = @"
                       INSERT INTO Register
                       (Name, Email, Password, [Confirm Password], Age, [Contact No])
                       VALUES
                       (@Name, @Email, @Pass, @confirm, @age, @contact)";

                        SqlCommand cmd = new SqlCommand(Query, con);

                        cmd.Parameters.AddWithValue("@Name", name.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@Pass", password);
                        cmd.Parameters.AddWithValue("@Confirm Password", confirmPassword);
                        cmd.Parameters.AddWithValue("@age", age.Text);
                        cmd.Parameters.AddWithValue("@contact", contact.Text);


                        con.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            pass.Attributes["value"] = password;
                            confrim.Attributes["value"] = confirmPassword;

                            Response.Write(
                                "<script>alert('Registered Successfully');</script>"
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(
                            "<script>alert('" +
                            ex.Message.Replace("'", "\\'") +
                            "');</script>"
                        );
                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
        }
        }
