namespace RohitVideoRental
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label17 = new System.Windows.Forms.Label();
            this.delVideoCD = new System.Windows.Forms.Button();
            this.updateVideoCD = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Plot = new System.Windows.Forms.TextBox();
            this.Ratting = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.VideoCdId = new System.Windows.Forms.TextBox();
            this.MemberID = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.DateTimePicker();
            this.Issue = new System.Windows.Forms.DateTimePicker();
            this.rentalDelete = new System.Windows.Forms.Button();
            this.rentalReturn = new System.Windows.Forms.Button();
            this.BookingVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delMember = new System.Windows.Forms.Button();
            this.updateMember = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MobileNo = new System.Windows.Forms.NumericUpDown();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.Copies = new System.Windows.Forms.NumericUpDown();
            this.RohitDB = new System.Windows.Forms.DataGridView();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MobileNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RohitDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(787, -36);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 32);
            this.label17.TabIndex = 105;
            this.label17.Text = "Rental Area";
            // 
            // delVideoCD
            // 
            this.delVideoCD.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideoCD.Location = new System.Drawing.Point(255, 356);
            this.delVideoCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delVideoCD.Name = "delVideoCD";
            this.delVideoCD.Size = new System.Drawing.Size(113, 39);
            this.delVideoCD.TabIndex = 104;
            this.delVideoCD.Text = "Delete";
            this.delVideoCD.UseVisualStyleBackColor = true;
            this.delVideoCD.Click += new System.EventHandler(this.delVideoCD_Click);
            // 
            // updateVideoCD
            // 
            this.updateVideoCD.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideoCD.Location = new System.Drawing.Point(133, 356);
            this.updateVideoCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateVideoCD.Name = "updateVideoCD";
            this.updateVideoCD.Size = new System.Drawing.Size(113, 39);
            this.updateVideoCD.TabIndex = 103;
            this.updateVideoCD.Text = "Update";
            this.updateVideoCD.UseVisualStyleBackColor = true;
            this.updateVideoCD.Click += new System.EventHandler(this.updateVideoCD_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(12, 356);
            this.AddVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(113, 39);
            this.AddVideo.TabIndex = 102;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(169, 287);
            this.Genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(204, 38);
            this.Genre.TabIndex = 101;
            // 
            // Plot
            // 
            this.Plot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plot.Location = new System.Drawing.Point(169, 240);
            this.Plot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(204, 38);
            this.Plot.TabIndex = 100;
            // 
            // Ratting
            // 
            this.Ratting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratting.Location = new System.Drawing.Point(169, 58);
            this.Ratting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ratting.Name = "Ratting";
            this.Ratting.Size = new System.Drawing.Size(204, 38);
            this.Ratting.TabIndex = 96;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(169, 11);
            this.title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(204, 38);
            this.title.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 94;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 93;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 92;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 91;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 90;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 89;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 32);
            this.label16.TabIndex = 88;
            this.label16.Text = "Title";
            // 
            // VideoCdId
            // 
            this.VideoCdId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoCdId.Location = new System.Drawing.Point(987, 65);
            this.VideoCdId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VideoCdId.Name = "VideoCdId";
            this.VideoCdId.Size = new System.Drawing.Size(204, 38);
            this.VideoCdId.TabIndex = 87;
            // 
            // MemberID
            // 
            this.MemberID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberID.Location = new System.Drawing.Point(987, 11);
            this.MemberID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MemberID.Name = "MemberID";
            this.MemberID.Size = new System.Drawing.Size(204, 38);
            this.MemberID.TabIndex = 86;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Return.Location = new System.Drawing.Point(987, 161);
            this.Return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(204, 38);
            this.Return.TabIndex = 85;
            // 
            // Issue
            // 
            this.Issue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Issue.Location = new System.Drawing.Point(987, 116);
            this.Issue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(204, 38);
            this.Issue.TabIndex = 84;
            // 
            // rentalDelete
            // 
            this.rentalDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDelete.Location = new System.Drawing.Point(795, 260);
            this.rentalDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentalDelete.Name = "rentalDelete";
            this.rentalDelete.Size = new System.Drawing.Size(365, 46);
            this.rentalDelete.TabIndex = 83;
            this.rentalDelete.Text = "Delete";
            this.rentalDelete.UseVisualStyleBackColor = true;
            this.rentalDelete.Click += new System.EventHandler(this.rentalDelete_Click);
            // 
            // rentalReturn
            // 
            this.rentalReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturn.Location = new System.Drawing.Point(955, 213);
            this.rentalReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentalReturn.Name = "rentalReturn";
            this.rentalReturn.Size = new System.Drawing.Size(205, 39);
            this.rentalReturn.TabIndex = 82;
            this.rentalReturn.Text = "Return";
            this.rentalReturn.UseVisualStyleBackColor = true;
            this.rentalReturn.Click += new System.EventHandler(this.rentalReturn_Click);
            // 
            // BookingVideo
            // 
            this.BookingVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingVideo.Location = new System.Drawing.Point(792, 213);
            this.BookingVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookingVideo.Name = "BookingVideo";
            this.BookingVideo.Size = new System.Drawing.Size(135, 39);
            this.BookingVideo.TabIndex = 81;
            this.BookingVideo.Text = "Issue";
            this.BookingVideo.UseVisualStyleBackColor = true;
            this.BookingVideo.Click += new System.EventHandler(this.BookingVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(775, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 32);
            this.label12.TabIndex = 80;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(775, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 32);
            this.label13.TabIndex = 79;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(787, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 32);
            this.label14.TabIndex = 78;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(787, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 32);
            this.label15.TabIndex = 77;
            this.label15.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, -26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 76;
            this.label1.Text = "Customer Area";
            // 
            // delMember
            // 
            this.delMember.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delMember.Location = new System.Drawing.Point(396, 256);
            this.delMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delMember.Name = "delMember";
            this.delMember.Size = new System.Drawing.Size(365, 46);
            this.delMember.TabIndex = 75;
            this.delMember.Text = "Delete";
            this.delMember.UseVisualStyleBackColor = true;
            this.delMember.Click += new System.EventHandler(this.delMember_Click);
            // 
            // updateMember
            // 
            this.updateMember.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMember.Location = new System.Drawing.Point(556, 209);
            this.updateMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateMember.Name = "updateMember";
            this.updateMember.Size = new System.Drawing.Size(205, 39);
            this.updateMember.TabIndex = 74;
            this.updateMember.Text = "Update";
            this.updateMember.UseVisualStyleBackColor = true;
            this.updateMember.Click += new System.EventHandler(this.updateMember_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(393, 209);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(135, 39);
            this.addCustomer.TabIndex = 71;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(556, 155);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(204, 38);
            this.Address.TabIndex = 73;
            // 
            // LName
            // 
            this.LName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(556, 62);
            this.LName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(204, 38);
            this.LName.TabIndex = 70;
            // 
            // FName
            // 
            this.FName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(556, 15);
            this.FName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(204, 38);
            this.FName.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 68;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(388, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 32);
            this.label9.TabIndex = 67;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(388, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 32);
            this.label10.TabIndex = 66;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 32);
            this.label11.TabIndex = 65;
            this.label11.Text = "First Name";
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(556, 111);
            this.MobileNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MobileNo.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(205, 35);
            this.MobileNo.TabIndex = 106;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(169, 110);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Year.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(205, 35);
            this.Year.TabIndex = 107;
            this.Year.ValueChanged += new System.EventHandler(this.Year_ValueChanged);
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(168, 153);
            this.Cost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cost.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(205, 35);
            this.Cost.TabIndex = 108;
            // 
            // Copies
            // 
            this.Copies.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copies.Location = new System.Drawing.Point(169, 196);
            this.Copies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Copies.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(205, 35);
            this.Copies.TabIndex = 109;
            // 
            // RohitDB
            // 
            this.RohitDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RohitDB.Location = new System.Drawing.Point(393, 335);
            this.RohitDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RohitDB.Name = "RohitDB";
            this.RohitDB.RowHeadersWidth = 51;
            this.RohitDB.Size = new System.Drawing.Size(996, 386);
            this.RohitDB.TabIndex = 110;
            this.RohitDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RohitDB_CellClick);
            this.RohitDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RohitDB_CellContentClick);
            // 
            // cbOption
            // 
            this.cbOption.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Items.AddRange(new object[] {
            "Choose Option",
            "Member",
            "VideoCD",
            "Booked",
            "TopVideo",
            "TopMember"});
            this.cbOption.Location = new System.Drawing.Point(40, 479);
            this.cbOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(256, 37);
            this.cbOption.TabIndex = 112;
            this.cbOption.SelectedIndexChanged += new System.EventHandler(this.cbOption_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(36, 427);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 32);
            this.label18.TabIndex = 113;
            this.label18.Text = "Record Option";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1435, 757);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbOption);
            this.Controls.Add(this.RohitDB);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.delVideoCD);
            this.Controls.Add(this.updateVideoCD);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.Ratting);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.VideoCdId);
            this.Controls.Add(this.MemberID);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.rentalDelete);
            this.Controls.Add(this.rentalReturn);
            this.Controls.Add(this.BookingVideo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delMember);
            this.Controls.Add(this.updateMember);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MobileNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RohitDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button delVideoCD;
        private System.Windows.Forms.Button updateVideoCD;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Plot;
        private System.Windows.Forms.TextBox Ratting;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox VideoCdId;
        private System.Windows.Forms.TextBox MemberID;
        private System.Windows.Forms.DateTimePicker Return;
        private System.Windows.Forms.DateTimePicker Issue;
        private System.Windows.Forms.Button rentalDelete;
        private System.Windows.Forms.Button rentalReturn;
        private System.Windows.Forms.Button BookingVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delMember;
        private System.Windows.Forms.Button updateMember;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown MobileNo;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.NumericUpDown Cost;
        private System.Windows.Forms.NumericUpDown Copies;
        private System.Windows.Forms.DataGridView RohitDB;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.Label label18;
    }
}

