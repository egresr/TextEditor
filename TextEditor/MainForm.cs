using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        // K etim chlenam tipa budet imet dostup PRESENTER
        string FilePath { get; } // Vosvraschaet put k failu kotoryj vybral user.

        // PRESENTER vystavljaet eto svojstvo, a FORMA otobrazhat ego soderzhimoe
        // Posel vnesenija izmenenija polzovatelem PRESENTER budet poluchat ego.
        string Content { get; set; }
        // Ustanavlivaet kol-vo simvolov kotoroe soderzhit fail.
        // Ego zadaet PRESENTER, t.k on peredaet v Model soderzhimoe faila, chtoby
        // MODEL ego obschitala. Poluchiv ot MODEL kolichestvo simvolov PRESENTER
        // daet FORME komandu otobrazit eto znachenie.
        void SetSymbolCount(int count);

        // Cheres eti SOBYTIJA FORMA budet uvedomljat PRESENTER, chto chto-to
        // proisoschlo
        event EventHandler FileOpenClick; // nazhata knopka otkryt fail
        event EventHandler FileSaveClick; // nazhata knopka sochranit fail
        event EventHandler TextBoxContent; // soderzhimoe faila bylo izmeneno
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            buttonOpenFile.Click += ButtonOpenFile_Click;
            buttonSaveFile.Click += ButtonSaveFile_Click;
            textBoxContent.TextChanged += TextBoxContent_TextChanged;
            buttonSelectFile.Click += ButtonSelectFile_Click;
        }

        #region //Probros sobytij
        private void TextBoxContent_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxContent != null) TextBoxContent(this, EventArgs.Empty);
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }
        #endregion //Probros sobytij

        #region //Realizacija interface iMainForm
        public string FilePath
        {
            get { return textBoxFilePath.Text; }

        }
        public string Content
        {
            get { return textBoxContent.Text; }
            set { textBoxContent.Text = value; }
        }
        public void SetSymbolCount(int count)
        {
            toolStripStatusLabelSymbolCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler TextBoxContent;

        #endregion //Realizacija interface iMainForm

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Textdateien|*.txt|Alle Dateien|*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
               textBoxFilePath .Text = dlg.FileName;

                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }

    }
}
