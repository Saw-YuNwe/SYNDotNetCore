using SYNDotNetCore.ConsoleApp.EfCoreExamples;
using System.Data;
using System.Data.SqlClient;
using System.Text;

//Console.WriteLine("Hello, World!");
//stringBuilder.DataSource = "DESKTOP-SM8F9VJ";//server name
//stringBuilder.UserID = "sa";
//string conect = stringBuilder.ConnectionString;
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//.DataSource = "";
//Console.WriteLine("Connection open");
//String query = "select * from tbl_blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);
//connection.Close();
//Console.WriteLine("Connection close");
//foreach (DataRow dr in dt.Rows)
//{
// Console.WriteLine("BLog Id=>" + dr["BlogId"]);
// Console.WriteLine("BLog Title=>" + dr["BlogTitle"]);
// Console.WriteLine("BLog Author=>" + dr["BlogAuthor"]);
//Console.WriteLine("BLog Content=>" + dr["BlogContent"]);
//Console.WriteLine("======================================");



//}
//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title","author","content");
//adoDotNetExample.Update(12,"saw","YU","nwe");
//adoDotNetExample.Delete(11);
//adoDotNetExample.Edit(11);

//adoDotNetExample.Edit(13);
//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();
EfCoreExample efCoreExample = new EfCoreExample();
efCoreExample.Run();
Console.ReadLine();

