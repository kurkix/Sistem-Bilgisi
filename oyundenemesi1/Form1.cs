using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Management;
using Microsoft.Win32;
using System.Media;
using WMPLib;


namespace oyundenemesi1
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer muzikcalar = new WindowsMediaPlayer();
        Boolean muzikcalarindurumu=false;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();    
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.Fuchsia;
            this.TransparencyKey = Color.Fuchsia;

            kapat.Visible = false;
            kucult.Visible = false;
            LinkLabel.Link link = new LinkLabel.Link();


            link.LinkData = "http://kurkix.com";
            kurkixlabel.Links.Add(link);
            pictureBox1.Image = oyundenemesi1.Properties.Resources.loadf;

            backgroundWorker1.RunWorkerAsync();
            
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            for (double i = 1.1; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(100);
            }
            this.Close();
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void bilgilerioku()
        {
            ManagementObjectSearcher arama = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
            ManagementObjectCollection koleksiyon = arama.Get();

            foreach(ManagementObject ekrankarti in koleksiyon)
            {
                ekranbilgisi.Text = ekrankarti["Description"].ToString();
            }
            arama.Query.QueryString = "Select * FROM WIN32_ComputerSystem";
            koleksiyon = arama.Get();
            string ram="";
            foreach (ManagementObject veri2 in koleksiyon)
            {
                bilgisayarmodelbilgisi.Text = veri2["Model"].ToString();
                bilgisayaradibilgisi.Text= veri2["Name"].ToString();
                ram = Math.Round((Convert.ToDouble(veri2["TotalPhysicalMemory"]) / 1073741824)).ToString() + " GB";
            }
            arama.Query.QueryString = "Select * FROM WIN32_Processor";
            koleksiyon = arama.Get();
            string islemci;
            foreach (ManagementObject veri3 in koleksiyon)
            {
                islemci = veri3["Name"].ToString();
                islemci = islemci + " " + veri3["Description"].ToString();
                islemcibilgisi.Text = islemci;
            }
         
            arama.Query.QueryString = "Select * FROM WIN32_BIOS";
            koleksiyon = arama.Get();

            string bios;
            foreach (ManagementObject veri4 in koleksiyon)
            {
                bios = veri4["Manufacturer"].ToString();
                bios = bios+" "+veri4["SMBIOSBIOSVersion"].ToString();
                biosbilgisi.Text = bios;
            }

            arama.Query.QueryString = "Select * FROM WIN32_OperatingSystem";
            koleksiyon = arama.Get();
            string isletimsistemi;
            foreach (ManagementObject veri5 in koleksiyon)
            {
                isletimsistemi = veri5["Name"].ToString();
                isletimsistemibilgisi.Text = isletimsistemi.Split('|')[0];
            }
            arama.Query.QueryString = "Select * FROM WIN32_BaseBoard";
            koleksiyon = arama.Get();
            string anakart;
            foreach (ManagementObject veri6 in koleksiyon)
            {
                anakart = veri6["Manufacturer"].ToString();
                anakart = anakart + " " + veri6["Product"].ToString();
                anakartbilgisi.Text = anakart;
            }
            arama.Query.QueryString = "Select * FROM WIN32_PhysicalMemory";
            koleksiyon = arama.Get();
            int ramtip=0;
            foreach (ManagementObject veri7 in koleksiyon)
            {
                ramtip = Convert.ToInt32(veri7["MemoryType"]);
            }
            switch (ramtip)
            {
                case 20:
                    ram = ram + " DDR";
                    break;
                case 21:
                    ram = ram + " DDR2";
                    break;
                case 17:
                    ram = ram + " SDRAM";
                    break;
                default:
                    if (ramtip == 0 || ramtip > 22)
                        ram = ram + " DDR3";
                    break;
            }
            rambilgisi.Text = ram;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bilgilerioku();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox2.BackgroundImage = oyundenemesi1.Properties.Resources.sessiz;
            pictureBox1.Visible = false;
            muzikcalar.URL = Application.StartupPath + @"\Ses\muzik.mp3";
            muzikcalar.settings.setMode("Loop", true);
            muzikcalar.controls.play();
            muzikcalarindurumu = true;
            this.BackColor = Color.DarkBlue;
            kapat.Visible = true;
            kucult.Visible = true;
            for (double i = 0.0; i <= 1.1; i += 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(100);
            }
            sistembilgisilabel.Visible = true;
            ekrankartilabel.Visible = true;
            ekranbilgisi.Visible = true;
            ramlabel.Visible = true;
            rambilgisi.Visible = true;
            islemcilabel.Visible = true;
            islemcibilgisi.Visible = true;
            anakartlabel.Visible = true;
            anakartbilgisi.Visible = true;
            bioslabel.Visible = true;
            biosbilgisi.Visible = true;
            isletimsistemilabel.Visible = true;
            isletimsistemibilgisi.Visible = true;
            bilgisayareadilabel.Visible = true;
            bilgisayaradibilgisi.Visible = true;
            bilgisayarmodellabel.Visible = true;
            bilgisayarmodelbilgisi.Visible = true;
            pictureBox2.Visible = true;
            kurkixlabel.Visible = true;
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (muzikcalarindurumu == true)
            {
                pictureBox2.BackgroundImage = oyundenemesi1.Properties.Resources.ses;
                muzikcalar.controls.stop();
                muzikcalarindurumu = false;
            }
            else if (muzikcalarindurumu == false)
            {
                pictureBox2.BackgroundImage = oyundenemesi1.Properties.Resources.sessiz;
                muzikcalar.URL = Application.StartupPath + @"\Ses\muzik.mp3";
                muzikcalar.settings.setMode("Loop", true);
                muzikcalar.controls.play();
                muzikcalarindurumu = true;
            }
        }

        private void kurkixlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}