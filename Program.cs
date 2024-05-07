using System.Data;
using MySql.Data.MySqlClient;

int deptid; 
string deptname;
// Console.WriteLine("Enter Dept id");
// deptid = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter dept name");
// deptname = Console.ReadLine();

string connectionstr = "server=3.7.198.191;port=8993;user=bu-trausr;password=r9*rwr$!usFw0MCPj#fJ;database=bu-training;";
MySqlConnection con = new MySqlConnection(connectionstr);
// Con.ConnectionString=connectionstr;
MySqlCommand cmd = con.CreateCommand();
con.Open();
// try
// {
//     Console.WriteLine(con.State);
//     cmd.CommandType = CommandType.Text;

    // //insert
    // string insertq = "insert into tableShenba values (@deptid,@deptname)";
    // cmd.CommandText = insertq;
    // cmd.Parameters.AddWithValue("@deptid", deptid);
    // cmd.Parameters.AddWithValue("@deptname", deptname);
    // cmd.ExecuteNonQuery();

    // //update
    // string updateq="update tableShenba set department_name = @deptname where department_id = @deptid ";
    // cmd.CommandText=updateq;
    // cmd.Parameters.AddWithValue("@deptid",deptid);
    // cmd.Parameters.AddWithValue("deptname",deptname);
    // cmd.ExecuteNonQuery();

    // //delete
    // string deleteq="delete from tableShenba where department_id=@deptid";
    // cmd.CommandText=deleteq;
    // cmd.Parameters.AddWithValue("@deptid",deptid);
    // cmd.ExecuteNonQuery();

    // //select
    // cmd.CommandText = "select * from tableShenba";
    // MySqlDataReader reads = cmd.ExecuteReader();
    // if (reads.HasRows)
    // {
    //     while (reads.Read())
    //     {
    //         Console.WriteLine(reads.GetInt16(0) + " " + reads.GetString(1));
    //     }
    // }
    // else
    // {
    //     Console.WriteLine("Table doesn't have rows");
    // }
    // reads.Close();
//     con.Close();
//     Console.WriteLine(con.State);
// }
// catch (MySqlException ex)
// {
//     Console.WriteLine(ex.Message);
// }



// cmd.CommandType = CommandType.Text;
// int department_id;
// string department_name;

// //select by id
// Console.WriteLine("Enter Dept id");
// department_id = Convert.ToInt16(Console.ReadLine());
// string selectbyid = "select * from tableShenba where department_id=@deptid";
// cmd.CommandText = selectbyid;
// cmd.Parameters.AddWithValue("@deptid", department_id);
// // cmd1.ExecuteNonQuery();
// MySqlDataReader reads = cmd.ExecuteReader();
// while (reads.Read())
// {
//     Console.WriteLine(reads["department_id"] + " " + reads["department_name"]);
// }


cmd.CommandType = CommandType.StoredProcedure;
// //update
// Console.WriteLine("Enter Dept id");
// department_id = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter dept name");
// department_name = Console.ReadLine();
// string update ="proshenbaupdate";
// cmd.CommandText=update;
// cmd.Parameters.AddWithValue("@deptid",department_id);
// cmd.Parameters.AddWithValue("@deptname",department_name);
// cmd.ExecuteNonQuery();

// //insert
// Console.WriteLine("Enter Dept id");
// department_id = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter dept name");
// department_name = Console.ReadLine();
// string spinsert="proshenbainsert";
// cmd.CommandText=spinsert;
// cmd.Parameters.AddWithValue("@deptid",department_id);
// cmd.Parameters.AddWithValue("@deptname",department_name);
// cmd.ExecuteNonQuery();

// //select
// string sp = "proshenba";
// cmd.CommandText = sp;
// MySqlDataReader reads=cmd.ExecuteReader();
// while (reads.Read())
// {
//     Console.WriteLine(reads.GetInt16(0) + " " + reads.GetString(1));
// }
// // con.Close();

// oper p = new oper();
// p.dataset1();
// class oper
// {
//     public void dataset1()
//     {
//         // DataSet
//         string connectionstr = "server=3.7.198.191;port=8993;user=bu-trausr;password=r9*rwr$!usFw0MCPj#fJ;database=bu-training;";
//         string selectq = "select * from tableShenba";
//         MySqlDataAdapter da = new MySqlDataAdapter(selectq, connectionstr);
//         DataSet ds = new DataSet();
//         da.Fill(ds, "tableShenba");
//         foreach (DataRow i in ds.Tables["tableShenba"].Rows)
//         {
//             Console.WriteLine(i["department_id"] + " " + i["department_name"]);
//         }
//     }
//     public void datatable1()
//     {
//         // DataTable
//         string connectionstr = "server=3.7.198.191;port=8993;user=bu-trausr;password=r9*rwr$!usFw0MCPj#fJ;database=bu-training;";
//         string selectq = "select * from tableShenba";
//         MySqlDataAdapter da = new MySqlDataAdapter(selectq, connectionstr);
//         DataTable ds = new DataTable();
//         da.Fill(ds);
//         foreach (DataRow i in ds.Rows)
//         {
//             Console.WriteLine(i["department_id"] + " " + i["department_name"]);
//         }
//     }
// }


