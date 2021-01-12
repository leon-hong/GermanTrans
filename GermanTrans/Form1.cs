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
using Google.Cloud.Translation.V2;

namespace GermanTrans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_trans_Click(object sender, EventArgs e)
        {
            TranslationClient client = TranslationClient.Create();
            string strSrc = edt_src.Text;

            var response = client.TranslateText(
                    text: strSrc,
                    targetLanguage: "ko",
                    sourceLanguage: "de"  // "de":독일, "en":영어
                    );

            edt_res_google.Text = response.TranslatedText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("start app");
        }
    }
}
