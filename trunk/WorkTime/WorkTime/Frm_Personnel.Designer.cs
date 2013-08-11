namespace WorkTime
{
    partial class Frm_Personnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Personnel));
            this.btnOutCancel = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.lblOut = new System.Windows.Forms.Label();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBrows = new System.Windows.Forms.Button();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxProject = new System.Windows.Forms.ComboBox();
            this.cbxTeam = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtZingid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccdomain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAddALot = new System.Windows.Forms.CheckBox();
            this.openFileDialog_IMG = new System.Windows.Forms.OpenFileDialog();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picAvata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOutCancel
            // 
            this.btnOutCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOutCancel.Location = new System.Drawing.Point(610, 417);
            this.btnOutCancel.Name = "btnOutCancel";
            this.btnOutCancel.Size = new System.Drawing.Size(45, 27);
            this.btnOutCancel.TabIndex = 78;
            this.btnOutCancel.Text = "Hủy";
            this.btnOutCancel.UseVisualStyleBackColor = true;
            this.btnOutCancel.Visible = false;
            this.btnOutCancel.Click += new System.EventHandler(this.btnPersonnel_detail_outCancel_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOut.Location = new System.Drawing.Point(446, 420);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(120, 27);
            this.btnOut.TabIndex = 77;
            this.btnOut.Text = "Ngày rời khỏi";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Visible = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // dtpOut
            // 
            this.dtpOut.CustomFormat = "dd/MM/yyyy";
            this.dtpOut.Enabled = false;
            this.dtpOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOut.Location = new System.Drawing.Point(427, 418);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(177, 26);
            this.dtpOut.TabIndex = 75;
            // 
            // lblOut
            // 
            this.lblOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOut.Location = new System.Drawing.Point(346, 424);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(75, 18);
            this.lblOut.TabIndex = 76;
            this.lblOut.Text = "Ngày nghỉ :";
            // 
            // cbxLevel
            // 
            this.cbxLevel.Enabled = false;
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Location = new System.Drawing.Point(89, 343);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(229, 21);
            this.cbxLevel.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(30, 347);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 18);
            this.label19.TabIndex = 74;
            this.label19.Text = "Level :";
            // 
            // btnBrows
            // 
            this.btnBrows.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrows.Location = new System.Drawing.Point(490, 163);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(107, 29);
            this.btnBrows.TabIndex = 72;
            this.btnBrows.Text = "Chọn hình ...";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Visible = false;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // dtpIn
            // 
            this.dtpIn.CustomFormat = "dd/MM/yyyy";
            this.dtpIn.Enabled = false;
            this.dtpIn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIn.Location = new System.Drawing.Point(105, 418);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(213, 26);
            this.dtpIn.TabIndex = 60;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(98, 188);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(257, 26);
            this.dtpBirthday.TabIndex = 52;
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.Enabled = false;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(98, 119);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(257, 21);
            this.cbxSex.TabIndex = 50;
            // 
            // cbxProject
            // 
            this.cbxProject.Enabled = false;
            this.cbxProject.FormattingEnabled = true;
            this.cbxProject.Location = new System.Drawing.Point(411, 306);
            this.cbxProject.Name = "cbxProject";
            this.cbxProject.Size = new System.Drawing.Size(223, 21);
            this.cbxProject.TabIndex = 56;
            // 
            // cbxTeam
            // 
            this.cbxTeam.Enabled = false;
            this.cbxTeam.FormattingEnabled = true;
            this.cbxTeam.Location = new System.Drawing.Point(89, 305);
            this.cbxTeam.Name = "cbxTeam";
            this.cbxTeam.Size = new System.Drawing.Size(229, 21);
            this.cbxTeam.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(501, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 18);
            this.label17.TabIndex = 69;
            this.label17.Text = "Ảnh đại diện";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(73, 226);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(561, 55);
            this.txtAddress.TabIndex = 48;
            this.txtAddress.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(15, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 68;
            this.label16.Text = "Địa chỉ :";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPhone.Location = new System.Drawing.Point(98, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(257, 26);
            this.txtPhone.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(13, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 18);
            this.label15.TabIndex = 67;
            this.label15.Text = "Điện thoại :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(30, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 66;
            this.label14.Text = "Ngày vào :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtCmnd
            // 
            this.txtCmnd.BackColor = System.Drawing.Color.White;
            this.txtCmnd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCmnd.Location = new System.Drawing.Point(72, 83);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.ReadOnly = true;
            this.txtCmnd.Size = new System.Drawing.Size(283, 26);
            this.txtCmnd.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(15, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 65;
            this.label13.Text = "CMND :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(13, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 64;
            this.label12.Text = "Ngày sinh :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Giới tính :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(346, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 62;
            this.label10.Text = "Project :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(30, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "Team :";
            // 
            // txtZingid
            // 
            this.txtZingid.BackColor = System.Drawing.Color.White;
            this.txtZingid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZingid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtZingid.Location = new System.Drawing.Point(411, 382);
            this.txtZingid.Name = "txtZingid";
            this.txtZingid.ReadOnly = true;
            this.txtZingid.Size = new System.Drawing.Size(223, 26);
            this.txtZingid.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(346, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "Zing ID :";
            // 
            // txtAccdomain
            // 
            this.txtAccdomain.BackColor = System.Drawing.Color.White;
            this.txtAccdomain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccdomain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAccdomain.Location = new System.Drawing.Point(122, 379);
            this.txtAccdomain.Name = "txtAccdomain";
            this.txtAccdomain.ReadOnly = true;
            this.txtAccdomain.Size = new System.Drawing.Size(196, 26);
            this.txtAccdomain.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(30, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Acc domain :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(72, 47);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(283, 26);
            this.txtName.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Họ tên :";
            // 
            // txtMSNV
            // 
            this.txtMSNV.BackColor = System.Drawing.Color.White;
            this.txtMSNV.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMSNV.Location = new System.Drawing.Point(72, 12);
            this.txtMSNV.MaxLength = 10;
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.ReadOnly = true;
            this.txtMSNV.Size = new System.Drawing.Size(100, 26);
            this.txtMSNV.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "MSNV :";
            // 
            // cbxAddALot
            // 
            this.cbxAddALot.AutoSize = true;
            this.cbxAddALot.Location = new System.Drawing.Point(411, 480);
            this.cbxAddALot.Name = "cbxAddALot";
            this.cbxAddALot.Size = new System.Drawing.Size(111, 17);
            this.cbxAddALot.TabIndex = 80;
            this.cbxAddALot.Text = "Thêm nhiều người";
            this.cbxAddALot.UseVisualStyleBackColor = true;
            // 
            // openFileDialog_IMG
            // 
            this.openFileDialog_IMG.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Fi" +
                "les (*.gif)|*.gif|All files (*.*)|*.*";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Image = global::WorkTime.Properties.Resources.Everaldo_Crystal_Clear_Action_edit_add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(292, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 44);
            this.btnAdd.TabIndex = 79;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Image = global::WorkTime.Properties.Resources.Everaldo_Crystal_Clear_Action_ok;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(292, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 44);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // picAvata
            // 
            this.picAvata.BackColor = System.Drawing.Color.LightGray;
            this.picAvata.Location = new System.Drawing.Point(486, 27);
            this.picAvata.Name = "picAvata";
            this.picAvata.Size = new System.Drawing.Size(118, 113);
            this.picAvata.TabIndex = 46;
            this.picAvata.TabStop = false;
            // 
            // Frm_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 517);
            this.Controls.Add(this.cbxAddALot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOutCancel);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.dtpOut);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.cbxLevel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.dtpIn);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.cbxProject);
            this.Controls.Add(this.cbxTeam);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtZingid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAccdomain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.picAvata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Personnel";
            this.Text = "Thông tin thành viên";
            this.Load += new System.EventHandler(this.Frm_Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutCancel;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxProject;
        private System.Windows.Forms.ComboBox cbxTeam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtZingid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccdomain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox picAvata;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbxAddALot;
        private System.Windows.Forms.OpenFileDialog openFileDialog_IMG;
    }
}