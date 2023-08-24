using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data.Linq;
using System.IO;
using System.Drawing;
namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    //Todo instead of clearing panels check database for new info and just add that to the panel keeping previous info and deleting info that was deleted
    //Todo Clean code up, and put code into class objects

    class db
    {
        private SqlConnection conn;
        private string connectionString = "";
        public bool testConnection()
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public db()
        {
            string database = ConfigurationManager.AppSettings.Get("database");
            string server = ConfigurationManager.AppSettings.Get("server");
            string username = ConfigurationManager.AppSettings.Get("username");
            string password = ConfigurationManager.AppSettings.Get("password");
            connectionString = $"server={server};database={database};User ID={username};password={password}";
            conn = new SqlConnection(connectionString);
        }
        public bool CreateUser(string name, string password, string email, Image img)
        {
            try
            {
                byte[] a = ImageToByteArray((Bitmap)img);
                int AvatarID;
                int check = 0;
                SqlCommand cmd8 = new SqlCommand($@"Select Count(*) From Avatars", conn);
                conn.Open();
                if ((int)cmd8.ExecuteScalar() < 1)
                {
                    SqlCommand cmd9 = new SqlCommand($@"INSERT INTO [dbo].[Avatars]
           ([AvatarImage])
     VALUES
           (Default)", conn);
                    cmd9.ExecuteNonQuery();
                }
                conn.Close();
                SqlCommand cmd5 = new SqlCommand($@"Select Count(*) From Users
Where Email like '{email}' or UserName like '{name}'", conn);
                conn.Open();
                if ((int)cmd5.ExecuteScalar() > 0)
                {
                    conn.Close();
                    return false;
                }
                else
                {
                    conn.Close();
                    SqlCommand cmd = new SqlCommand($@"Select Count(*) From Avatars
where AvatarImage = @img", conn);
                    cmd.Parameters.AddWithValue("@img", a);
                    conn.Open();
                    check = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (check > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand($@"Select AvatarID From Avatars
where AvatarImage = @img", conn);
                        cmd2.Parameters.AddWithValue("@img", a);
                        conn.Open();
                        AvatarID = (int)cmd2.ExecuteScalar();
                        conn.Close();
                    }
                    else
                    {
                        SqlCommand cmd3 = new SqlCommand($@"INSERT INTO [dbo].[Avatars]
               ([AvatarImage])
                output INSERTED.AvatarID
         VALUES
               (@img)", conn);
                        cmd3.Parameters.AddWithValue("@img", a);
                        conn.Open();
                        AvatarID = (int)cmd3.ExecuteScalar();
                        conn.Close();
                    }
                    SqlCommand cmd4 = new SqlCommand($@"INSERT INTO [dbo].[Users]
               ([Username]
               ,[Password]
               ,[Email]
               ,[Avatar])
                output Inserted.UserID
         VALUES
               (@name
               ,@pass
               ,@email
               ,{AvatarID})", conn);
                    cmd4.Parameters.AddWithValue("@img", a);
                    cmd4.Parameters.AddWithValue("@name", name);
                    cmd4.Parameters.AddWithValue("@pass", password);
                    cmd4.Parameters.AddWithValue("@email", email);
                    conn.Open();
                    int userID = (int)cmd4.ExecuteScalar();
                    conn.Close();
                    SqlCommand cmd6 = new SqlCommand($@"Select Count(*) From Users", conn);
                    conn.Open();
                    if((int)cmd6.ExecuteScalar() == 1)
                    {
                        SqlCommand cmd7 = new SqlCommand($@"INSERT INTO [dbo].[Admins]
               ([UserID])
         VALUES
               ({userID})", conn);
                        cmd7.ExecuteNonQuery();
                        conn.Close();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static byte[] ImageToByteArray(Bitmap img1)
        {
            ImageConverter converter = new ImageConverter();
            byte[] x = (byte[])converter.ConvertTo(img1, typeof(byte[]));
            MemoryStream stream = new MemoryStream();
            stream.Write(x, 0, Convert.ToInt32(x.Length));
            return x;
        }
        public static Bitmap ByteArrayToImage(byte[] arr)
        {
            MemoryStream stream = new MemoryStream();
            byte[] data = arr;
            stream.Write(data, 0, Convert.ToInt32(data.Length));
            Bitmap img = new Bitmap(stream, false);
            return img;
        }
        public bool CreateUser(string name, string password, string email)
        {
            try
            {
                SqlCommand cmd3 = new SqlCommand($@"Select Count(*) From Avatars", conn);
                conn.Open();
                if ((int)cmd3.ExecuteScalar() < 1)
                {
                    SqlCommand cmd4 = new SqlCommand($@"INSERT INTO [dbo].[Avatars]
           ([AvatarImage])
     VALUES
           (Default)", conn);
                    cmd4.ExecuteNonQuery();
                }
                conn.Close();
                SqlCommand cmd2 = new SqlCommand($@"Select Count(*) From Users
Where Email like '{email}' or UserName like '{name}'", conn);
                conn.Open();
                if ((int)cmd2.ExecuteScalar() > 0)
                {
                    conn.Close();
                    return false;
                }
                else
                {
                    conn.Close();
                    SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[Users]
               ([Username]
               ,[Password]
               ,[Email])
         VALUES
               (@name
               ,@pass
               ,@email)", conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool Login(string name, string password)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($@"Select Count(*) From Users
Where (Username like '{name}') and (Password like '{password}')", conn);
                if (Convert.ToInt32(cmd.ExecuteScalar()) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; 
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadUser(string user, string pass)
        {
            DataTable dat01 = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($@"Select [UserID]
      ,[Username]
      ,[Password]
      ,[Email]
      ,[JoinDate]
      ,[NumPosts]
      ,[NumPages]
      ,[NumComments]
      ,[Banned]
	  ,Avatars.AvatarImage
From Users
Join Avatars on Users.Avatar = Avatars.AvatarID
  Where Username like '{user}' and Password like '{pass}'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                dat01.Columns.Add("Admin", typeof(int));
                SqlCommand cmd2 = new SqlCommand($@"Select Count(*) From Admins Where UserID = {dat01.Rows[0]["UserID"]}", conn);
                dat01.Rows[0]["Admin"] = (int)(cmd2.ExecuteScalar()); 
                conn.Close();
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadUsers()
        {
            DataTable dat01 = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($@"Select [UserID]
      ,[Username]
      ,[Email]
      ,[JoinDate]
      ,[NumPosts]
      ,[NumPages]
      ,[NumComments]
      ,[Banned]
	  ,Avatars.AvatarImage
From Users
Join Avatars on Users.Avatar = Avatars.AvatarID", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                dat01.Columns.Add("Admin", typeof(int));
                foreach (DataRow row in dat01.Rows)
                {
                    SqlCommand cmd2 = new SqlCommand($@"Select Count(*) From Admins Where UserID = {row["UserID"].ToString()}", conn);
                    row["Admin"] = (int)(cmd2.ExecuteScalar());
                }
                conn.Close();
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadUserUsername(string user, string pass)
        {
            DataTable dat01 = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand($@"Select [UserID]
      ,[Username]
      ,[Email]
      ,[JoinDate]
      ,[NumPosts]
      ,[NumPages]
      ,[NumComments]
      ,[Banned]
	  ,Avatars.AvatarImage
From Users
Join Avatars on Users.Avatar = Avatars.AvatarID
Where Username like '%{user}%'", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                dat01.Columns.Add("Admin", typeof(int));
                SqlCommand cmd2 = new SqlCommand($@"Select Count(*) From Admins Where UserID = {dat01.Rows[0]["UserID"]}", conn);
                dat01.Rows[0]["Admin"] = (int)(cmd2.ExecuteScalar());
                conn.Close();
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public void PromoteDemoteUser(string userID, bool choice)
        {
            try
            {
                if (choice)
                {
                    SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[Admins]
           ([UserID])
     VALUES
           ({userID})", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($@"DELETE FROM [dbo].[Admins]
      WHERE UserID = {userID}", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void BanUser(string userID, bool choice)
        {
            try
            {
                if (choice)
                {
                    SqlCommand cmd = new SqlCommand($@"UPDATE [dbo].[Users]
   SET [Banned] = 1
 WHERE UserID = {userID}", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($@"UPDATE [dbo].[Users]
   SET [Banned] = 0
 WHERE UserID = {userID}", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeletePostorPage(string type, string id)
        {
            try
            {
                if(type == "Page")
                {
                    SqlCommand cmd = new SqlCommand($@"DELETE FROM [dbo].[PageContent]
      WHERE PageID = {id}", conn);
                    SqlCommand cmd2 = new SqlCommand($@"DELETE FROM [dbo].[PageImage]
      WHERE PageID = {id}", conn);
                    SqlCommand cmd3 = new SqlCommand($@"DELETE FROM [dbo].[Pages]
      WHERE PageID = {id}", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($@"DELETE FROM [dbo].[PostContent]
      WHERE PostID = {id}", conn);
                    SqlCommand cmd2 = new SqlCommand($@"DELETE FROM [dbo].[PostImage]
      WHERE PostID = {id}", conn);
                    SqlCommand cmd3 = new SqlCommand($@"DELETE FROM [dbo].[Comments]
      WHERE PostID = {id}", conn);
                    SqlCommand cmd4 = new SqlCommand($@"DELETE FROM [dbo].[Posts]
      WHERE PostID = {id}", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public int CreatePost(string user, string title)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[Posts]
           ([UserID]
           ,[Title])
            output INSERTED.PostID
     VALUES
           ({user}
           ,@title)", conn);
                cmd.Parameters.AddWithValue("@title", title);
                SqlCommand cmd2 = new SqlCommand($@"UPDATE [dbo].[Users]
   SET 
      [NumPosts] = NumPosts + 1
	  Where UserID = {user}", conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                int postID = (int)cmd.ExecuteScalar();
                conn.Close();
                return postID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
            public void CreatePostContent(string PostID, string Content, string Order)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[PostContent]
           ([PostID]
      ,[PostContent]
      ,[PostOrderNum])
     VALUES
           ({PostID}
           ,@content
            ,{Order})", conn);
                cmd.Parameters.AddWithValue("@content", Content);
                conn.Open();
                cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        public void CreatePostImage(string PostID, Image img, string Order)
        {
            try
            {
                byte[] a = ImageToByteArray((Bitmap)img);
               
                SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[PostImage]
           ([PostID]
      ,[PostImage]
      ,[PostOrderNum])
     VALUES
           ({PostID}
           ,@img
            ,{Order})", conn);
                cmd.Parameters.AddWithValue("@img", a);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadPostInfo()
        {
            DataTable dat01 = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand($@"Select p.PostID
,p.Title
,u.UserName
,p.PostDate 
From Posts p
Join Users u on p.UserID = u.UserID", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                dat01.Columns.Add("TimeAgo");
                dat01.Columns[4].DataType = typeof(string);
                foreach (DataRow row in dat01.Rows)
                    row["TimeAgo"] = TimePosted((DateTime)row["PostDate"]);
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadFullPostInfo(string PostID)
        {
            DataTable dat01 = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand($@"Select p.PostID
,p.Title
,u.UserName
,p.PostDate 
From Posts p
Join Users u on p.UserID = u.UserID
Where p.PostID = {PostID}", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                dat01.Columns.Add("TimeAgo");
                dat01.Columns[4].DataType = typeof(string);
                foreach (DataRow row in dat01.Rows)
                    row["TimeAgo"] = TimePosted((DateTime)row["PostDate"]);
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadPostContent(string PostID)
        {
            DataTable dat01 = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand($@"SELECT * From PostContent pc
Where pc.PostID = {PostID}", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadPostImage(string PostID)
        {
            DataTable dat01 = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand($@"Select * From PostImage pim
Where pim.PostID = {PostID}", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public void CreateComment(string PostID, string UserID, string CommentContent)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[Comments]
           ([PostID]
           ,[UserID]
           ,[CommentContent])
     VALUES
           ({PostID}
           ,{UserID}
           ,@content)", conn);
                cmd.Parameters.AddWithValue("@content", CommentContent);
                SqlCommand cmd2 = new SqlCommand($@"UPDATE [dbo].[Users]
   SET 
      [NumComments] = NumComments + 1
	  Where UserID = {UserID}", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteComment(string CommentID, string UserName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($@"DELETE FROM [dbo].[Comments]
      Where CommentID = {CommentID}", conn);
                SqlCommand cmd2 = new SqlCommand($@"UPDATE [dbo].[Users]
   SET 
      [NumComments] = NumComments - 1
	  Where Username = '{UserName}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadComments(string PostID)
        {
            DataTable dat01 = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand($@"Select c.CommentID, c.CommentContent, u.UserName, c.CommentDate From Comments c
Join Users u on c.UserID = u.UserID
Where c.PostID = {PostID}", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                dat01.Columns.Add("TimeAgo");
                dat01.Columns[4].DataType = typeof(string);
                foreach (DataRow row in dat01.Rows)
                    row["TimeAgo"] = TimePosted((DateTime)row["CommentDate"]);
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }










        public int CreatePage(string user, string title, string description)
        {
            try
            {

                SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[Pages]
           ([UserID]
           ,[Title]
            ,[Description])
            output INSERTED.PageID
     VALUES
           ({user}
           ,@title
            ,@desc)", conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", description);
                SqlCommand cmd2 = new SqlCommand($@"UPDATE [dbo].[Users]
   SET 
      [NumPages] = NumPages + 1
	  Where UserID = {user}", conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                int PageID = (int)cmd.ExecuteScalar();
                conn.Close();
                return PageID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public void CreatePageContent(string PageID, string Content, string Order)
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[PageContent]
           ([PageID]
      ,[PageContent]
      ,[PageOrderNum])
     VALUES
           ({PageID}
           ,@content
            ,{Order})", conn);
                cmd.Parameters.AddWithValue("@content", Content);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void CreatePageImage(string PageID, Image img, string Order)
        {
            try
            {
                byte[] a = ImageToByteArray((Bitmap)img);
                
                SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[PageImage]
           ([PageID]
      ,[PageImage]
      ,[PageOrderNum])
     VALUES
           ({PageID}
           ,@img
            ,{Order})", conn);
                cmd.Parameters.AddWithValue("@img", a);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadPageInfo()
        {
            DataTable dat01 = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand($@"Select p.PageID
,p.Title
,p.Description
,u.UserName
,p.DateCreated
From Pages p
Join Users u on p.UserID = u.UserID", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                dat01.Columns.Add("TimeAgo");
                dat01.Columns[5].DataType = typeof(string);
                foreach (DataRow row in dat01.Rows)
                    row["TimeAgo"] = TimePosted((DateTime)row["DateCreated"]);
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadFullPageInfo(string PageID)
        {
            DataTable dat01 = new DataTable();
            try
            {
                
                SqlCommand cmd = new SqlCommand($@"Select p.PageID
,p.Title
,u.UserName
,p.DateCreated
From Pages p
Join Users u on p.UserID = u.UserID
Where p.PageID = {PageID}", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                dat01.Columns.Add("TimeAgo");
                dat01.Columns[4].DataType = typeof(string);
                foreach (DataRow row in dat01.Rows)
                    row["TimeAgo"] = TimePosted((DateTime)row["DateCreated"]);
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadPageContent(string PageID)
        {
            DataTable dat01 = new DataTable();
            try
            {
                
                SqlCommand cmd = new SqlCommand($@"SELECT * From PageContent pc
Where pc.PageID = {PageID}", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadPageImage(string PageID)
        {
            DataTable dat01 = new DataTable();
            try
            {
                
                SqlCommand cmd = new SqlCommand($@"Select * From PageImage pim
Where pim.PageID = {PageID}", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int CheckPost(string PostID)
        {
            int check = 0;
            try
            {
                SqlCommand cmd = new SqlCommand($@"Select Count(*) From Posts
Where PostID = {PostID}", conn);
                conn.Open();
                check = (int)cmd.ExecuteScalar();
                conn.Close();
                return check;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
           
        }
        public int CheckPage(string PageID)
        {
            int check = 0;
            try
            {
                SqlCommand cmd = new SqlCommand($@"Select Count(*) From Pages
Where PageID = {PageID}", conn);
                conn.Open();
                check = (int)cmd.ExecuteScalar();
                conn.Close();
                return check;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadNewWhispers(string UserID, string WhisperID)
        {
            DataTable dat01 = new DataTable();
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (WhisperID == "")
                {
                    cmd = new SqlCommand($@"Select w.WhisperID, w.SendingUser, w.ReceivingUser, w.WhisperContent, w.WhisperDate From Whispers w
Where (SendingUser = {UserID} or ReceivingUser = {UserID}) and (w.WhisperID > 0)
Order by w.WhisperDate", conn);
                }
                else
                {
                    cmd = new SqlCommand($@"Select w.WhisperID, w.SendingUser, w.ReceivingUser, w.WhisperContent, w.WhisperDate From Whispers w
Where (SendingUser = {UserID} or ReceivingUser = {UserID}) and (w.WhisperID > {WhisperID})
Order by w.WhisperDate", conn);
                }
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dat01);
                conn.Close();
                dat01.Columns.Add("UserName");
                dat01.Columns.Add("SentUser");
                dat01.Columns[5].DataType = typeof(string);
                dat01.Columns[6].DataType = typeof(string);
                foreach (DataRow row in dat01.Rows)
                {
                    SqlCommand cmd2 = new SqlCommand($@"Select UserName From Users
Where UserID = {row["SendingUser"].ToString()}", conn);
                    SqlCommand cmd3 = new SqlCommand($@"Select UserName From Users
Where UserID = {row["ReceivingUser"].ToString()}", conn);
                    conn.Open();
                    row["SentUser"] = cmd3.ExecuteScalar().ToString();
                    row["Username"] = cmd2.ExecuteScalar().ToString();
                    conn.Close();
                }
                dat01.Columns.Add("TimeAgo");
                dat01.Columns[7].DataType = typeof(string);
                foreach (DataRow row in dat01.Rows)
                    row["TimeAgo"] = TimePosted((DateTime)row["WhisperDate"]);
                return dat01;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public string GetUserID(string UserName)
        {
            try
            {
                string UserID = "";
                SqlCommand cmd = new SqlCommand($@"Select UserID From Users
Where UserName like @name", conn);
                cmd.Parameters.AddWithValue("@name", UserName);
                conn.Open();
                if(cmd.ExecuteScalar() != null)
                {
                    UserID = cmd.ExecuteScalar().ToString();
                }
                conn.Close();
                return UserID;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public void SendWhisper(string UserID, string ReceivingUser, string Content)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[Whispers]
           ([SendingUser]
           ,[ReceivingUser]
           ,[WhisperContent])
     VALUES
           ({UserID}
           ,{ReceivingUser}
           ,@content)", conn);
                cmd.Parameters.AddWithValue("@content", Content);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string TimePosted(DateTime yourDate) //Online Source: https://stackoverflow.com/questions/11/calculate-relative-time-in-c-sharp
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;
            var ts = new TimeSpan(DateTime.Now.Ticks - yourDate.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago";

            if (delta < 2 * MINUTE)
                return "a minute ago";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " minutes ago";

            if (delta < 90 * MINUTE)
                return "an hour ago";

            if (delta < 24 * HOUR)
                return ts.Hours + " hours ago";

            if (delta < 48 * HOUR)
                return "yesterday";

            if (delta < 30 * DAY)
                return ts.Days + " days ago";

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "one year ago" : years + " years ago";
            }
        }
    }
}
