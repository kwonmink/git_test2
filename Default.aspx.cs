using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class _Default : System.Web.UI.Page 
{

    public SqlConnection db_Connect()
    {
        return new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
       


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TableRow tableRow;
        TableCell tableCell;

        tableRow = new TableRow();

        tableCell = new TableCell();
        tableCell.Text = "employeeid";
        tableRow.Cells.Add(tableCell);

        tableCell = new TableCell();
        tableCell.Text = "employname";
        tableRow.Cells.Add(tableCell);


        Table1.Rows.Add(tableRow);

        String InputStr1;
        String strdEmployname;

        InputStr1 = TextBox1.Text;
        Label1.Text = InputStr1 + " が入力されました。";

        string connString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        string queryString = "SELECT employeeid, employname FROM employee WHERE employname=" + "'" + InputStr1 + "'";

        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlCommand comm = new SqlCommand(queryString, conn);
            conn.Open();

            using (SqlDataReader dr = comm.ExecuteReader())
            {
                while (dr.Read())
                {
                    strdEmployname = dataread(1).ToString;

                    //TABLE生成
                    tableRow = new TableRow();

                    tableCell = new TableCell();
                    tableCell.text = dataread(0).ToString;
                    tableRow.Cells.Add(tableCell);

                    tableCell = new TableCell();
                    tableCell.text = dataread(1).ToString;
                    tableRow.Cells.Add(tableCell);

                    Table1.Rows.Add(tableRow);
                }
            }
        }

       

      

    }
}
