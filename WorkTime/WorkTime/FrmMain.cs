using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkTime
{
    public partial class FrmMain : Form
    {
        public bool show_panel_personnal = false;
        public bool show_panel_Notes = false;
        public bool show_panel_work = false;
        public bool show_panel_BtnMenu = true;

        public String title1 = "";

        public FormWindowState stateWindows = FormWindowState.Normal;
        public Button btnSelected = new Button();

        public List<Button> leftMenu = new List<Button>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            panel_btnMenu.Location = new Point(0, 22);
            btn_showBtnMenu.Location = new Point(102, 0);

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();

            leftMenu.Add(btnPersonnal);
            leftMenu.Add(btnNotes);
            leftMenu.Add(btnAppointments);
            leftMenu.Add(btnCards);
            leftMenu.Add(btnKeys);
            leftMenu.Add(btnMoney);
            leftMenu.Add(btnWorks);
            leftMenu.Add(btnHappy);


        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            hidePanel_personnal();
            hidePanel_notes();
            hidePanel_work();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabMoney;
        }

        private void btnPesonnal_Click(object sender, EventArgs e)
        {
            hidePanel_work();
            hidePanel_notes();
            showPanel_personnal();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabPersonnal;
        }

        private void showPanel_personnal()
        {
            if (show_panel_personnal == false)
            {
                show_panel_personnal = true;

                panel1.Show();
                panel1.Location = new Point(btnPersonnal.Location.X, btnPersonnal.Location.Y + btnPersonnal.Height);

                btnMoney.Location = new Point(btnMoney.Location.X, btnMoney.Location.Y + panel1.Height);
                btnCards.Location = new Point(btnCards.Location.X, btnCards.Location.Y + panel1.Height);
                btnKeys.Location = new Point(btnKeys.Location.X, btnKeys.Location.Y + panel1.Height);
                btnWorks.Location = new Point(btnWorks.Location.X, btnWorks.Location.Y + panel1.Height);
                btnAppointments.Location = new Point(btnAppointments.Location.X, btnAppointments.Location.Y + panel1.Height);
                btnNotes.Location = new Point(btnNotes.Location.X, btnNotes.Location.Y + panel1.Height);
                btnHappy.Location = new Point(btnHappy.Location.X, btnHappy.Location.Y + panel1.Height);
            }
        }

        private void hidePanel_personnal()
        {
            if (show_panel_personnal == true)
            {
                panel1.Hide();
                show_panel_personnal = false;

                btnMoney.Location = new Point(btnMoney.Location.X, btnMoney.Location.Y - panel1.Height);
                btnCards.Location = new Point(btnCards.Location.X, btnCards.Location.Y - panel1.Height);
                btnKeys.Location = new Point(btnKeys.Location.X, btnKeys.Location.Y - panel1.Height);
                btnWorks.Location = new Point(btnWorks.Location.X, btnWorks.Location.Y - panel1.Height);
                btnAppointments.Location = new Point(btnAppointments.Location.X, btnAppointments.Location.Y - panel1.Height);
                btnNotes.Location = new Point(btnNotes.Location.X, btnNotes.Location.Y - panel1.Height);
                btnHappy.Location = new Point(btnHappy.Location.X, btnHappy.Location.Y - panel1.Height);
            }
        }

        private void showPanel_work()
        {
            if (show_panel_work == false)
            {
                show_panel_work = true;

                panel3.Show();
                panel3.Location = new Point(btnWorks.Location.X, btnWorks.Location.Y + btnWorks.Height);

                btnAppointments.Location = new Point(btnAppointments.Location.X, btnAppointments.Location.Y + panel3.Height);
                btnNotes.Location = new Point(btnNotes.Location.X, btnNotes.Location.Y + panel3.Height);
                btnHappy.Location = new Point(btnHappy.Location.X, btnHappy.Location.Y + panel1.Height);
            }
        }

        private void hidePanel_work()
        {
            if (show_panel_work == true)
            {
                panel3.Hide();
                show_panel_work = false;

                btnAppointments.Location = new Point(btnAppointments.Location.X, btnAppointments.Location.Y - panel3.Height);
                btnNotes.Location = new Point(btnNotes.Location.X, btnNotes.Location.Y - panel3.Height);
                btnHappy.Location = new Point(btnHappy.Location.X, btnHappy.Location.Y - panel1.Height);
            }
        }

        private void showPanel_notes()
        {
            if (show_panel_Notes == false)
            {
                show_panel_Notes = true;

                panel2.Show();
                panel2.Location = new Point(btnAppointments.Location.X, btnAppointments.Location.Y + btnAppointments.Height);

                btnNotes.Location = new Point(btnNotes.Location.X, btnNotes.Location.Y + panel2.Height);
                btnHappy.Location = new Point(btnHappy.Location.X, btnHappy.Location.Y + panel1.Height);
            }
        }

        private void hidePanel_notes()
        {
            if (show_panel_Notes == true)
            {
                panel2.Hide();
                show_panel_Notes = false;

                btnNotes.Location = new Point(btnNotes.Location.X, btnNotes.Location.Y - panel2.Height);
                btnHappy.Location = new Point(btnHappy.Location.X, btnHappy.Location.Y - panel1.Height);
            }
        }

        private void btnPersonnal_now_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabPersonnal_now;


            //SQL_CONNECT.SQL_CONN sqlQ = new SQL_CONNECT.SQL_CONN();
            //sqlQ.executeSelectQuery("SELECT * FROM KEY");
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            hidePanel_personnal();
            hidePanel_notes();
            hidePanel_work();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabCards;
        }

        private void btnKeys_Click(object sender, EventArgs e)
        {
            hidePanel_personnal();
            hidePanel_notes();
            hidePanel_work();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabKeys;
        }

        private void btnWorks_Click(object sender, EventArgs e)
        {
            hidePanel_personnal();
            hidePanel_notes();
            showPanel_work();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabWorks;
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            hidePanel_work();
            hidePanel_personnal();
            hidePanel_notes();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabNotes;
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            hidePanel_work();
            hidePanel_personnal();
            showPanel_notes();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabAppointments;
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            hidePanel_work();
            hidePanel_personnal();
            hidePanel_notes();

            btnLeftMenu_click(sender);

            tabC.SelectedTab = tabHappy;
        }

        private void btn_showBtnMenu_Click(object sender, EventArgs e)
        {
            if (show_panel_BtnMenu == true)
            {
                panel_btnMenu.Hide();
                btn_showBtnMenu.Text = ">>";
                show_panel_BtnMenu = false;

                btn_showBtnMenu.Location = new Point(btn_showBtnMenu.Location.X + btn_showBtnMenu.Width - panel_btnMenu.Width, btn_showBtnMenu.Location.Y);
                tabC.Location = new Point(tabC.Location.X - panel_btnMenu.Width, tabC.Location.Y);
                tabC.Width = tabC.Width + panel_btnMenu.Width;
                txtTitle.Width = txtTitle.Width + panel_btnMenu.Width - btn_showBtnMenu.Width;
                txtTitle.Location = new Point(txtTitle.Location.X - panel_btnMenu.Width + btn_showBtnMenu.Width, txtTitle.Location.Y);
            }
            else
            {
                panel_btnMenu.Show();
                btn_showBtnMenu.Text = "<<";
                show_panel_BtnMenu = true;

                btn_showBtnMenu.Location = new Point(btn_showBtnMenu.Location.X - btn_showBtnMenu.Width + panel_btnMenu.Width, btn_showBtnMenu.Location.Y);
                tabC.Location = new Point(tabC.Location.X + panel_btnMenu.Width, tabC.Location.Y);
                tabC.Width = tabC.Width - panel_btnMenu.Width;
                txtTitle.Width = txtTitle.Width - panel_btnMenu.Width + btn_showBtnMenu.Width;
                txtTitle.Location = new Point(txtTitle.Location.X + panel_btnMenu.Width - btn_showBtnMenu.Width, txtTitle.Location.Y);
            }
        }

        public void btnLeftMenu_click(object sender)
        {

            foreach (Button i in leftMenu)
            {

                // i.FlatStyle = FlatStyle.Standard;
                i.BackgroundImage = null;
            }

            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            // btn.FlatStyle = FlatStyle.Flat;
            btn.BackgroundImage = WorkTime.Properties.Resources.bg_white;

            title1 = btn.Text;
            txtTitle.Text = title1;
        }

        private void munuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPesonnal_Click(btnPersonnal, new EventArgs());
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }


        private void notify_Main_menu_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void btnLeftMenu_child2_click(object sender)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != btnSelected)
            {

                txtTitle.Text = title1 + " : " + btn.Text;

                btnSelected = btn;

            }
        }

        private void btnPersonnal_old_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabHappy;
        }

        private void btnPersonnal_relation_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabPersonnal_relation;
        }

        private void btnWorks_ly_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabWorks_ly;
        }

        private void btnWorks_day_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabWorks_day;
        }

        private void btnWorks_date_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabWorks_date;
        }

        private void btnAppointments_ly_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabAppointments_ly;
        }

        private void btnAppointments_date_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabAppointments_date;
        }

        private void btnAppointments_day_Click(object sender, EventArgs e)
        {
            btnLeftMenu_child2_click(sender);

            tabC.SelectedTab = tabAppointments_day;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void notify_Main_menu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notify_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = stateWindows;
            this.ShowInTaskbar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPersonnel_detail_Click(object sender, EventArgs e)
        {




        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPersonnel_detail_edit_Click(object sender, EventArgs e)
        {
            txtPersonnel_detail__MSNV.ReadOnly = false;
            txtPersonnel_detail_accdomain.ReadOnly = false;
            txtPersonnel_detail_address.ReadOnly = false;
            txtPersonnel_detail_cmnd.ReadOnly = false;
            txtPersonnel_detail_name.ReadOnly = false;
            txtPersonnel_detail_phone.ReadOnly = false;
            txtPersonnel_detail_zingid.ReadOnly = false;

            dtpPersonnel_detail_birthday.Enabled = true;
            dtpPersonnel_detail_in.Enabled = true;
            dtpPersonnel_detail_out.Enabled = true;

            cbxPersonnel_detail_project.Enabled = true;
            cbxPersonnel_detail_sex.Enabled = true;
            cbxPersonnel_detail_team.Enabled = true;
            cbxPersonnel_detail_level.Enabled = true;

            btnPersonnel_detail_update.Enabled = true;
            btnPersonnel_detail_edit.Enabled = false;

            btnPersonnel_detail_out.Enabled = true;

            btnPersonnel_detail_brows.Visible = true;

        }

        private void btnPersonnel_detail_update_Click(object sender, EventArgs e)
        {
            txtPersonnel_detail__MSNV.ReadOnly = true;
            txtPersonnel_detail_accdomain.ReadOnly = true;
            txtPersonnel_detail_address.ReadOnly = true;
            txtPersonnel_detail_cmnd.ReadOnly = true;
            txtPersonnel_detail_name.ReadOnly = true;
            txtPersonnel_detail_phone.ReadOnly = true;
            txtPersonnel_detail_zingid.ReadOnly = true;

            dtpPersonnel_detail_birthday.Enabled = false;
            dtpPersonnel_detail_in.Enabled = false;
            dtpPersonnel_detail_out.Enabled = false;

            cbxPersonnel_detail_project.Enabled = false;
            cbxPersonnel_detail_sex.Enabled = false;
            cbxPersonnel_detail_team.Enabled = false;
            cbxPersonnel_detail_level.Enabled = false;

            btnPersonnel_detail_update.Enabled = false;
            btnPersonnel_detail_edit.Enabled = true;

            btnPersonnel_detail_out.Enabled = false;

            btnPersonnel_detail_brows.Visible = false;
        }

        private void btnPersonnel_detail_brows_Click(object sender, EventArgs e)
        {
            openFileDialog_IMG.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
                stateWindows = this.WindowState;
            if (this.WindowState == FormWindowState.Minimized)
                this.ShowInTaskbar = false;
        }

        private void btnPersonnel_detail_out_Click(object sender, EventArgs e)
        {
            lblPersonnel_detail_out.Visible = true;
            dtpPersonnel_detail_out.Visible = true;
            btnPersonnel_detail_outCancel.Visible = true;


            btnPersonnel_detail_out.Visible = false;
        }

      
        private void btnPersonnel_detail_outCancel_Click(object sender, EventArgs e)
        {
            btnPersonnel_detail_out.Visible = true;

            lblPersonnel_detail_out.Visible = false;
            dtpPersonnel_detail_out.Visible = false;
            btnPersonnel_detail_outCancel.Visible = false;
        }

      

        private void cbPersonnel_all_level_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPersonnel_all_Add_Click(object sender, EventArgs e)
        {
            Frm_Personnel frmPersonnel = new Frm_Personnel();
                frmPersonnel.ShowDialog();
        }

        private void btnPersonnel_all_Edit_Click(object sender, EventArgs e)
        {
            Frm_Personnel frmPersonnel = new Frm_Personnel();
            frmPersonnel.ShowDialog();
        }

        private void tabPersonnel_search_Click(object sender, EventArgs e)
        {

        }

        private void cbPersonnel_search_MSNV_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                txtPersonnel_search_MSNV.Enabled = true;
            else
                txtPersonnel_search_MSNV.Enabled = false;
        }

        private void cbPersonnel_search_name_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                txtPersonnel_search_name.Enabled = true;
            else
                txtPersonnel_search_name.Enabled = false;
        }

        private void cbPersonnel_search_team_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                cbxPersonnel_search_team.Enabled = true;
            else
                cbxPersonnel_search_team.Enabled = false;
        }

        private void cbPersonnel_search_project_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                cbxPersonnel_search_project.Enabled = true;
            else
                cbxPersonnel_search_project.Enabled = false;
        }

        private void cbPersonnel_search_level_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                cbxPersonnel_search_level.Enabled = true;
            else
                cbxPersonnel_search_level.Enabled = false;
        }

        private void cbPersonnel_search_accdomain_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                txtPersonnel_search_accDomain.Enabled = true;
            else
                txtPersonnel_search_accDomain.Enabled = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                txtPersonnel_search_zingid.Enabled = true;
            else
                txtPersonnel_search_zingid.Enabled = false;
        }

        private void cbPersonnel_search_cmnd_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                txtPersonnel_search_cmnd.Enabled = true;
            else
                txtPersonnel_search_cmnd.Enabled = false;
        }

        private void cbPersonnel_search_sex_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
               cbxPersonnel_search_sex.Enabled = true;
            else
                cbxPersonnel_search_sex.Enabled = false;
        }

        private void cbPersonnel_search_in_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                grbPersonnel_search_in.Enabled = true;
            else
                grbPersonnel_search_in.Enabled = false;
        }

        private void cbPersonnel_search_out_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                grbPersonnel_search_out.Enabled = true;
            else
                grbPersonnel_search_out.Enabled = false;
        }

        private void cbPersonnel_search_birthday_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
                dtpPersonnel_search_birthday.Enabled = true;
            else
                dtpPersonnel_search_birthday.Enabled = false;
        }

        private void dgvPersonnel_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPersonnel_search_in.Checked == true)
            {
                dtpPersonnel_search_in.Enabled = true;

                dtpPersonnel_search_in_start.Enabled = false;
                dtpPersonnel_search_in_end.Enabled = false;
            }
            else
            {
                dtpPersonnel_search_in.Enabled = false;

                dtpPersonnel_search_in_start.Enabled = true;
                dtpPersonnel_search_in_end.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPersonnel_search_out.Checked == true)
            {
                dtpPersonnel_search_out.Enabled = true;

                dtpPersonnel_search_out_start.Enabled = false;
                dtpPersonnel_search_out_end.Enabled = false;
            }
            else
            {
                dtpPersonnel_search_out.Enabled = false;

                dtpPersonnel_search_out_start.Enabled = true;
                dtpPersonnel_search_out_end.Enabled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_PerRelationcs frmRelation = new Frm_PerRelationcs();
            frmRelation.ShowDialog();
        }

       

    }
}