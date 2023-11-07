using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YolaChat
{
    public partial class Form1 : Form
    {
        int tiks;
        private string TypeOfLogin;
        private string Login;
        private string Password;
        private bool Connected = false;
        System.Windows.Forms.WebBrowser webBrowser1;
        public Form1()
        {
            InitializeComponent();
            //newBrowser();
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sw = new SettingsForm();
            sw.ShowDialog();
        }

        private void соединитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connected = false;
            newBrowser();
            //webBrowser1.Visible = false;

            string deshifr = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate("https://youla.ru/logout");
                //webBrowser1.Document.ExecCommand("ClearAuthenticationCache", false, null);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
                byte[] Shifr;
                using (BinaryReader reader = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open)))
                    Shifr = reader.ReadBytes((int)reader.BaseStream.Length);
                if (Shifr != null) deshifr = Crypto.FromAes256(Shifr); else return;
                var strpar = deshifr.Split(':');
                TypeOfLogin = strpar[0];
                Login = strpar[1];
                Password = strpar[2];
                tiks = 0;
                switch (TypeOfLogin)
                {
                    case "VK":
                        {
                            webBrowser1.Navigate(new Uri("https://oauth.vk.com/authorize?response_type=code&client_id=5028682&scope=offline&redirect_uri=https%3A%2F%2Fyoula.ru%2Flogin%2Fvk"));
                            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
                            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("email")[0].InnerText = Login;
                            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("email")[0].SetAttribute("type","password");
                            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("pass")[0].InnerText = Password;
                            for (int i = 0; i < webBrowser1.Document.GetElementsByTagName("a").Count; i++)
                                webBrowser1.Document.GetElementsByTagName("a")[i].OuterHtml = "";
                            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
                            
                            timer1.Start();
                            break;
                        }
                    case "OK":
                        {
                            webBrowser1.Navigate(new Uri("https://connect.ok.ru/oauth/authorize?response_type=code&client_id=1150887424&redirect_uri=https%3A%2F%2Fyoula.ru%2Flogin%2Fok"));
                            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
                            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("fr.email")[0].InnerText = Login;
                            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("fr.email")[0].SetAttribute("type", "password");
                            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("fr.password")[0].InnerText = Password;
                            for (int i = 0; i < webBrowser1.Document.GetElementsByTagName("a").Count; i++)
                                webBrowser1.Document.GetElementsByTagName("a")[i].OuterHtml = "";
                            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
                            timer1.Start();
                            break;
                        }
                    case "TL":
                        {
                            webBrowser1.Visible = true;
                            this.webBrowser1.DocumentCompleted -= new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
                            webBrowser1.Navigate(new Uri("https://youla.ru/login"));
                            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
                            for (int i = 0; i < webBrowser1.Document.GetElementsByTagName("button").Count; i++)
                            {
                                if (webBrowser1.Document.GetElementsByTagName("button")[i].GetAttribute("className").Contains("auth_group_button"))
                                {
                                    webBrowser1.Document.GetElementsByTagName("button")[i].InvokeMember("click"); ;
                                }
                            }
                            for (int i = 0; i < webBrowser1.Document.GetElementsByTagName("input").Count; i++)
                            {
                                if (webBrowser1.Document.GetElementsByTagName("input")[i].GetAttribute("className") == "form_control--simple form_control")
                                {
                                    webBrowser1.Document.GetElementsByTagName("input")[i].InnerText = Login;
                                }
                            }
                            timer1.Start();
                            webBrowser1.Visible = true;

                            break;
                        }
                }
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (Connected == true) e.Cancel = true;
            //if (TypeOfLogin=="TL") ChatActive();
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void ChatActive()
        {
            timer1.Stop();
            webBrowser1.Navigate("https://youla.ru/im");
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
            var fields = webBrowser1.Document.GetElementsByTagName("div");
            for (int i = 0; i < fields.Count; i++)
            {
                if (fields[i].GetAttribute("className") == "_container header_prototype header_prototype--board tiny")
                    webBrowser1.Document.GetElementsByTagName("div")[i].OuterHtml = "";
            }
            Connected = true;
            webBrowser1.Visible = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connected = false;
            webBrowser1.Navigate("https://youla.ru/logout");
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
            Application.Exit();
        }

        private void newBrowser()
        {
            string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            foreach (string currentFile in theCookies)
            {
                try
                {
                    System.IO.File.Delete(currentFile);
                }
                catch (Exception ex)
                {
                }
            }
            System.Diagnostics.Process.Start("cmd.exe", "/C RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (TypeOfLogin == "TL")
            {
                var divs = webBrowser1.Document.GetElementById("app");
                if (divs == null) System.Threading.Thread.Sleep(1000); else ChatActive();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var divs = webBrowser1.Document.GetElementById("app");
            if (divs != null) {
                for (int i = 0; i < webBrowser1.Document.GetElementsByTagName("div").Count; i++) {
                    if (webBrowser1.Document.GetElementsByTagName("div")[i].GetAttribute("className") == "auth_group__title") return;
                     if(webBrowser1.Document.GetElementsByTagName("div")[i].InnerHtml!=null && webBrowser1.Document.GetElementsByTagName("div")[i].InnerHtml.Contains("Пожалуйста, введите") == true) return;
                }
                if (webBrowser1.Document.GetElementById("downshift-0-input") != null) ChatActive();
            }
        }
    }
}
