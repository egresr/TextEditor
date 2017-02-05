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
    public partial class MainForm : Form
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
            event EventHandler ContentChanged; // soderzhimoe faila bylo izmeneno
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
