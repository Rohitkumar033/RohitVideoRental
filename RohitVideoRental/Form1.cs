using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RohitVideoRental
{
    public partial class Form1 : Form
    {

        //global declaration of the variable 
        SqlConnection connection;
        String connection_String = "Data Source=DESKTOP-1U747U4\\SQLEXPRESS;Initial Catalog=RohitDatabase;Integrated Security=True";
        SqlCommand command;
        SqlDataReader Datareader;
        int BookingID = 0;

        
        // user define method that is used to get the record from the table
        public DataTable SrchQuery(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }
        //this method is used to reload the whole program
        public void reload() {
            title.Text = "";
            Ratting.Text = "";
            Year.Value = 0;
            Cost.Value = 0;
            Copies.Value = 0;
            Plot.Text = "";
            Genre.Text = "";

            BookingID = 0;
            MemberID.Text = "";
            VideoCdId.Text = "";

            FName.Text = "";
            LName.Text = "";
            MobileNo.Value = 0;
            Address.Text = "";

        }
        public Form1()
        {
            InitializeComponent();
            cbOption.SelectedIndex = 0;
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (FName.Text.ToString().Equals("") && LName.Text.ToString().Equals("") && MobileNo.Value.ToString().Equals("0") && Address.Text.ToString().Equals("")) {
                MessageBox.Show("Fill All Details of the Member to Register ");
            }
            else {

                String qry = "insert into Member(F_Name,L_Name,Mobile,Address)values(@FName,@LName,@Mobile,@Address)";
                connection = new SqlConnection(connection_String);
                connection.Open();
                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@FName", FName.Text.ToString());
                command.Parameters.AddWithValue("@LName", LName.Text.ToString());
                command.Parameters.AddWithValue("@Mobile", MobileNo.Value.ToString());
                command.Parameters.AddWithValue("@Address", Address.Text.ToString());

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Member is Registered ");
                reload();
            }

        }

        private void AddVideo_Click(object sender, EventArgs e)
        {
            if (title.Text.ToString().Equals("") && Ratting.Text.ToString().Equals("") && Year.Value.ToString().Equals("0") && Cost.Value.ToString().Equals("0") && Copies.Value.ToString().Equals("0") && Plot.Text.ToString().Equals("") && Genre.Text.ToString().Equals("")) 
            {
                MessageBox.Show("Fill All Details of the Video to Save ");
            }
            else
            {

                String qry = "insert into VideoCD(VideoTitle,VideoRatting,VideoYear,VideoCost,VideoCopies,VideoPlot,VideoGenre)values(@Title,@Ratting,@Year,@Cost,@Copies,@Plot,@Genre)";
                connection = new SqlConnection(connection_String);
                connection.Open();
                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@Title", title.Text.ToString());
                command.Parameters.AddWithValue("@Ratting",Ratting.Text.ToString());
                command.Parameters.AddWithValue("@Year", Year.Value.ToString());
                command.Parameters.AddWithValue("@Cost",Cost.Value.ToString());
                command.Parameters.AddWithValue("@Copies", Copies.Value.ToString());
                command.Parameters.AddWithValue("@Plot", Plot.Text.ToString());
                command.Parameters.AddWithValue("@Genre", Genre.Text.ToString());

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("VideoCD Record is Saved");
                reload();
            }


        }

       

        private void delMember_Click(object sender, EventArgs e)
        {
            if (MemberID.Text.ToString().Equals(""))
            {
                MessageBox.Show("First of all Select the Member to Delete");
            }
            else
            {
                String query = "select * from BookingVideo where MemberID="+Convert.ToInt32(MemberID.Text.ToString())+" and VideoReturn='Booked'";
                DataTable tblData = new DataTable();
                tblData = SrchQuery(query);
                if (tblData.Rows.Count > 0)
                {
                    MessageBox.Show("Member Already have a VideoCD so canot be delete ");
                }
                else
                {

                    String qry = "delete from Member where ID=@MemberID";
                    connection = new SqlConnection(connection_String);
                    connection.Open();
                    command = new SqlCommand(qry, connection);

                    command.Parameters.AddWithValue("@MemberID", MemberID.Text.ToString());

                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("Member is Deleted ");
                    reload();
                }
            }

        }

        private void delVideoCD_Click(object sender, EventArgs e)
        {
            if (VideoCdId.Text.ToString().Equals(""))
            {
                MessageBox.Show("First of all Select the Video to Delete");
            }
            else
            {
                String query = "select * from BookingVideo where VideoID=" + Convert.ToInt32(VideoCdId.Text.ToString()) + " and VideoReturn='Booked'";
                DataTable tblData = new DataTable();
                tblData = SrchQuery(query);
                if (tblData.Rows.Count > 0)
                {
                    MessageBox.Show("Video is on Rent ");
                }
                else
                {
                    String qry = "delete from VideoCD where id=@VideoCdId";
                    connection = new SqlConnection(connection_String);
                    connection.Open();
                    command = new SqlCommand(qry, connection);

                    command.Parameters.AddWithValue("@VideoCdId", VideoCdId.Text.ToString());

                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();

                    MessageBox.Show("Video CD  is Deleted ");
                    reload();
                }
            }

        }

        private void updateMember_Click(object sender, EventArgs e)
        {
            if (FName.Text.ToString().Equals("") && LName.Text.ToString().Equals("") && MobileNo.Value.ToString().Equals("0") && Address.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill All Details of the Member to Edit");
            }
            else
            {

                String qry = "update Member set F_Name=@FName,L_Name=@LName,Mobile=@Mobile,Address=@Address where ID=@MemberID";
                connection = new SqlConnection(connection_String);
                connection.Open();
                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@MemberID", MemberID.Text.ToString());
                command.Parameters.AddWithValue("@FName", FName.Text.ToString());
                command.Parameters.AddWithValue("@LName", LName.Text.ToString());
                command.Parameters.AddWithValue("@Mobile", MobileNo.Value.ToString());
                command.Parameters.AddWithValue("@Address", Address.Text.ToString());

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Member record is Edited ");
                reload();
            }



        }

        private void updateVideoCD_Click(object sender, EventArgs e)
        {
            if (title.Text.ToString().Equals("") && Ratting.Text.ToString().Equals("") && Year.Value.ToString().Equals("0") && Cost.Value.ToString().Equals("0") && Copies.Value.ToString().Equals("0") && Plot.Text.ToString().Equals("") && Genre.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill All Details of the VideoCD to Edit ");
            }
            else
            {

                String qry = "update VideoCD set VideoTitle=@Title,VideoRatting=@Ratting,VideoYear=@Year,VideoCost=@Cost,VideoCopies=@Copies,VideoPlot=@Plot,VideoGenre=@Genre where ID=@VideoCdId";
                connection = new SqlConnection(connection_String);
                connection.Open();
                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@VideoCdId", VideoCdId.Text.ToString());
                command.Parameters.AddWithValue("@Title", title.Text.ToString());
                command.Parameters.AddWithValue("@Ratting", Ratting.Text.ToString());
                command.Parameters.AddWithValue("@Year", Year.Value.ToString());
                command.Parameters.AddWithValue("@Cost", Cost.Value.ToString());
                command.Parameters.AddWithValue("@Copies", Copies.Value.ToString());
                command.Parameters.AddWithValue("@Plot", Plot.Text.ToString());
                command.Parameters.AddWithValue("@Genre", Genre.Text.ToString());

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("VideoCD Record is Edited ");
                reload();
            }



        }

        private void BookingVideo_Click(object sender, EventArgs e)
        {
            if (MemberID.Text.ToString().Equals("") && VideoCdId.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the Video or Member to Book an Video CD on Rent ");
            }
            else {
                //get the booked video according to the videoID
                String query = "select * from BookingVideo where VideoID=" + Convert.ToInt32(VideoCdId.Text.ToString()) + " and VideoReturn='Booked'";
                DataTable tblData = new DataTable();
                tblData = SrchQuery(query);

                //get the booked video according to the  MemberID
                query = "";
                query = "select * from BookingVideo where MemberID=" + Convert.ToInt32(MemberID.Text.ToString()) + " and VideoReturn='Booked'";
                DataTable tblData1 = new DataTable();
                tblData1 = SrchQuery(query);

                if (tblData.Rows.Count >= Convert.ToInt32(Copies.Value) && tblData1.Rows.Count >= 2)
                {
                    MessageBox.Show("There is am Issue to Get the Video on Rent may all the CD on Rent or Member has 2 Video's on Rent ");
                }
                else
                {

                    String qry = "insert into BookingVideo(MemberID,VideoID,VideoIssued,VideoReturn)values(@MemberID,@VideoID,@Issued,@Return)";
                    connection = new SqlConnection(connection_String);
                    connection.Open();
                    command = new SqlCommand(qry, connection);

                    command.Parameters.AddWithValue("@MemberID", MemberID.Text.ToString());
                    command.Parameters.AddWithValue("@VideoID", VideoCdId.Text.ToString());
                    command.Parameters.AddWithValue("@Issued", Issue.Text.ToString());
                    command.Parameters.AddWithValue("@Return", "Booked");

                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("VideoCd is Booked on Rent ");
                    reload();
                }
            }
        }

        private void rentalDelete_Click(object sender, EventArgs e)
        {
            
            if (BookingID.ToString().Equals("0"))
            {
                MessageBox.Show("Select the Booked Video to Delete");
            }
            else
            {
                String qry = "Delete from  BookingVideo where Id=@BookingID";
                connection = new SqlConnection(connection_String);
                connection.Open();

                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@BookingID", BookingID.ToString());
                

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Booked Video Cd is delete ");
                reload();

            }


        }

        private void rentalReturn_Click(object sender, EventArgs e)
        {
            if (BookingID.ToString().Equals("") )
            {
                MessageBox.Show("Select the Booked Video To return First ");
            }
            else
            {
                //get the booked video according to the videoID
                String query = "select * from VideoCD where id=" + Convert.ToInt32(VideoCdId.Text.ToString()) + "";
                DataTable tblData = new DataTable();
                tblData = SrchQuery(query);

                int cost = Convert.ToInt32(tblData.Rows[0]["VideoCost"].ToString());


                DateTime Current_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime Old_date = Convert.ToDateTime(Issue.Text.ToString());


                //get the difference in the days fromat
                String diff = (Current_date - Old_date).TotalDays.ToString();


                // calculate the round off value 
                Double Days = Math.Round(Convert.ToDouble(diff));

                // return the total cost of the Video
                int price = 0;
                price = cost * Convert.ToInt32(Days);





                String qry = "update BookingVideo set MemberID=@MemberID,VideoID=@VideoID,VideoIssued=@Issued,VideoReturn=@Return where Id=@BookingID";
                connection = new SqlConnection(connection_String);
                connection.Open();
                command = new SqlCommand(qry, connection);

                command.Parameters.AddWithValue("@BookingID", BookingID.ToString());
                command.Parameters.AddWithValue("@MemberID",MemberID.Text.ToString());
                command.Parameters.AddWithValue("@VideoID", VideoCdId.Text.ToString());
                command.Parameters.AddWithValue("@Issued", Issue.Text.ToString());
                command.Parameters.AddWithValue("@Return", Return.Text.ToString());

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("VideoCd is return and Charges is =$"+cost);
                reload();
            }
        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOption.SelectedIndex == 1) {
                String query = "select * from Member";
                RohitDB.DataSource = SrchQuery(query);

            }

            if (cbOption.SelectedIndex == 2) {
                String query = "select * from VideoCD";
                RohitDB.DataSource = SrchQuery(query);

            }
            if (cbOption.SelectedIndex==3) {
                String query = "select * from BookingVideo";
                RohitDB.DataSource = SrchQuery(query);
            }
            //this code is used to find the top most video on Rent 
            if (cbOption.SelectedIndex == 4)
            {
                //this method is used to print  the id of the movie which is send most on rent 
                String query = "";
                int countVideo = 0, countID = 0;
                String Name = "";
                DataTable tbl = new DataTable();
                DataTable tbl1 = new DataTable();

                query = "select * from VideoCD ";
                tbl = SrchQuery(query);
                for (int y = 0; y < tbl.Rows.Count; y++)
                {
                    String query1 = "select * from BookingVideo where VideoID='" + tbl.Rows[y]["id"].ToString() + "'";
                    tbl1 = SrchQuery(query1);
                    if (tbl1.Rows.Count > 0)
                    {
                        if (tbl1.Rows.Count > countVideo)
                        {
                            countVideo = tbl.Rows.Count;
                            countID = Convert.ToInt32(tbl.Rows[y]["id"].ToString());
                            Name = tbl.Rows[y]["VideoTitle"].ToString();
                        }
                    }
                }
                MessageBox.Show("Top most rental video CD is=" + Name);

            }
            //this code is used to find the top most member who get the most videos on rent 
            if (cbOption.SelectedIndex == 5)
            {
             
                //this method id used to print the id of that customer who has most movie on rent 

                String query = "";
                int countVideo = 0, countID = 0;
                DataTable tbl = new DataTable();
                DataTable tbl1 = new DataTable();
                String MemberName = "";
                query = "select * from Member";
                tbl = SrchQuery(query);
                for (int y = 0; y < tbl.Rows.Count; y++)
                {
                    String query1 = "select * from BookingVideo where MemberID='" + tbl.Rows[y]["id"].ToString() + "'";
                    tbl1 = SrchQuery(query1);
                    if (tbl1.Rows.Count > 0)
                    {
                        if (tbl1.Rows.Count > countVideo)
                        {
                            countVideo = tbl.Rows.Count;
                            countID = Convert.ToInt32(tbl.Rows[y]["id"].ToString());
                            MemberName = tbl.Rows[y]["F_Name"].ToString() + " " + tbl.Rows[y]["L_Name"].ToString();
                        }
                    }
                }
                MessageBox.Show("Top Member is =" + MemberName);



            }



        }

        private void RohitDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbOption.SelectedIndex == 1)
            {
                MemberID.Text= RohitDB.CurrentRow.Cells[0].Value.ToString();
                FName.Text= RohitDB.CurrentRow.Cells[1].Value.ToString();
                LName.Text= RohitDB.CurrentRow.Cells[2].Value.ToString();
                MobileNo.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[3].Value.ToString());
                Address.Text = RohitDB.CurrentRow.Cells[4].Value.ToString();

            }

            if (cbOption.SelectedIndex == 2)
            {
                VideoCdId.Text = RohitDB.CurrentRow.Cells[0].Value.ToString();
                title.Text = RohitDB.CurrentRow.Cells[1].Value.ToString();
                Ratting.Text = RohitDB.CurrentRow.Cells[2].Value.ToString();
                Year.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[3].Value.ToString());
                Cost.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[4].Value.ToString());
                Copies.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[5].Value.ToString());

                Plot.Text = RohitDB.CurrentRow.Cells[6].Value.ToString();
                Genre.Text = RohitDB.CurrentRow.Cells[7].Value.ToString();
            }
            if (cbOption.SelectedIndex == 3)
            {
                BookingID = Convert.ToInt32(RohitDB.CurrentRow.Cells[0].Value.ToString());
                MemberID.Text = RohitDB.CurrentRow.Cells[1].Value.ToString();
                VideoCdId.Text = RohitDB.CurrentRow.Cells[2].Value.ToString();
                Issue.Text = RohitDB.CurrentRow.Cells[3].Value.ToString();

            }
           
        }

        private void Year_ValueChanged(object sender, EventArgs e)
        {
            try {

                //dislay the cost of the price of the video after adding the year of the video
                DateTime date = DateTime.Now;

                int year = date.Year;

                int diff = year - Convert.ToInt32(Year.Value.ToString());
                // MessageBox.Show(diff.ToString());
                if (diff >= 5)
                {
                    Cost.Value =2;
                }
                if (diff >= 0 && diff < 5)
                {
                    Cost.Value= 5;
                }
            }
            catch (Exception ex) {
                    
            }
        }

        private void RohitDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbOption.SelectedIndex == 1)
            {
                MemberID.Text = RohitDB.CurrentRow.Cells[0].Value.ToString();
                FName.Text = RohitDB.CurrentRow.Cells[1].Value.ToString();
                LName.Text = RohitDB.CurrentRow.Cells[2].Value.ToString();
                MobileNo.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[3].Value.ToString());
                Address.Text = RohitDB.CurrentRow.Cells[4].Value.ToString();

            }

            if (cbOption.SelectedIndex == 2)
            {
                VideoCdId.Text = RohitDB.CurrentRow.Cells[0].Value.ToString();
                title.Text = RohitDB.CurrentRow.Cells[1].Value.ToString();
                Ratting.Text = RohitDB.CurrentRow.Cells[2].Value.ToString();
                Year.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[3].Value.ToString());
                Cost.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[4].Value.ToString());
                Copies.Value = Convert.ToInt32(RohitDB.CurrentRow.Cells[5].Value.ToString());

                Plot.Text = RohitDB.CurrentRow.Cells[6].Value.ToString();
                Genre.Text = RohitDB.CurrentRow.Cells[7].Value.ToString();
            }
            if (cbOption.SelectedIndex == 3)
            {
                BookingID = Convert.ToInt32(RohitDB.CurrentRow.Cells[0].Value.ToString());
                MemberID.Text = RohitDB.CurrentRow.Cells[1].Value.ToString();
                VideoCdId.Text = RohitDB.CurrentRow.Cells[2].Value.ToString();
                Issue.Text = RohitDB.CurrentRow.Cells[3].Value.ToString();

            }



        }
    }
}
