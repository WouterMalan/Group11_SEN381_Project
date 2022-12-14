using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group11_SEN381_Project.DataAccess;
using MaterialSkin;
using MaterialSkin.Controls;
using FontAwesome.Sharp;
using System.Drawing.Text;
using RJCodeAdvance.RJControls;
using System.Runtime.InteropServices;
using Group11_SEN381_Project.Presentation;
using LiveCharts.Wpf;
using LiveCharts;

namespace Group11_SEN381_Project
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            //to change the skin of the UI Windows form
            //var skinManager = MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            //skinManager.Theme = MaterialSkinManager.Themes.DARK;
            //skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue400, TextShade.WHITE);

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            panelMenu.Controls.Add(leftBorderBtn);

            // Form 
            this.Text = string.Empty;// to remove the title bar
            this.ControlBox = false;// to remove the control box
            this.DoubleBuffered = true;// to remove the flickering of the form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;// to remove the maximized button and to make the form maximized by default


            //pie chart
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                   // show all the policies that are active
                    Title = "Active Policies",
                    // count the number of rows in the Policy table
                    Values = new ChartValues<int> { 20 },
                    DataLabels = true
                },
                new PieSeries
                {
                    //show all the clients
                    Title = "Clients",
                    // count the number of rows in the Client table
                    Values = new ChartValues<int> { 15 },
            DataLabels = true
                },
                new PieSeries
                {
                    //show all the providers in the system
                    Title = "Providers",
                    Values = new ChartValues<int> { 10 },
                    DataLabels = true

                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
        // struct to store the data of the buttons in the menu
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //To drag the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            {
                if (currentBtn != null)
                {
                    currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // to remove the border of the form
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            dh.sqlcon();
            
        }

        

        private void btnClientCentre_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Client Centre";
            Open_DropDownMenu(rjDropdownMenu1, sender);
            OpenChildForm(new CallCentreForm());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Client";
            OpenChildForm(new Client());

        }

        private void btnMedicalCondition_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Medical Condition";
            OpenChildForm(new Medical_Condition_Form());

        }

        private void btnPolicy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Policy";
            OpenChildForm(new PolicyForm());

        }

        private void bntProvider_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Provider";
            OpenChildForm(new ProviderForm());

        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Treatment";
            OpenChildForm(new TreatmentForm());


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ResetHome();
        }

        // to reset the home page
        private void ResetHome()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.RoyalBlue;
            lblTitleChildForm.Text = "Home";
            
        }

        
        private void panelTitleShow_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if(this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                btnHome.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach(Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                btnHome.Visible = true;
                btnMenu.Dock = DockStyle.Right;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void Open_DropDownMenu(RJDropdownMenu dropDownMenu, object sender)
        {
            Control control = (Control)sender;
            dropDownMenu.VisibleChanged +=new EventHandler((sender2, ev)
                => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropDownMenu.Show(control, control.Width, 0);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control control)
        {
            RJDropdownMenu dropDownMenu = (RJDropdownMenu)sender;
            if (!dropDownMenu.Visible)
            {
                control.BackColor = Color.FromArgb(31, 30, 68);
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitleChildForm.Text = "Report";
            OpenChildForm(new Report());
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            iconCurrentChildForm.IconChar = IconChar.User;
            lblTitleChildForm.Text = "Client";
            OpenChildForm(new Client());
        }

        private void btnOpenPolicy_Click(object sender, EventArgs e)
        {
            iconCurrentChildForm.IconChar = IconChar.ClipboardList;
            lblTitleChildForm.Text = "Policy";
            OpenChildForm(new PolicyForm());
        }

        private void btnOpenProviders_Click(object sender, EventArgs e)
        {
            iconCurrentChildForm.IconChar = IconChar.Hospital;
            lblTitleChildForm.Text = "Provider";
            OpenChildForm(new ProviderForm());
        }
    }
    
}
