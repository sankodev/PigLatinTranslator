using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITS228_Project1_PigLatinTranslator_KCSS
{
    public partial class PigLatinTranslator : Form
    {
        const string SUFFIX = "ay";

        public PigLatinTranslator()
        {
            InitializeComponent();
        }

        private void PigLatinTranslator_Load(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string translation = "";
            string origin = textBoxOrigin.Text;

            string[] tempOrigin = origin.Split(' ');

            for (int i = 0; i < tempOrigin.Length; i++)
            {
                translation += getPigLatin(tempOrigin[i]);
            }

            textBoxOutcome.Text = translation;
        }
        private string getPigLatin(string origin)
        {
            string word;
            string firstLetter = origin.Substring(0, 1);

            word = origin.Substring(1) + firstLetter + SUFFIX + " ";

            return word;
        }
    }
}
