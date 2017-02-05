using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string exclamation);
        void ShowError(string error);
    }

    //objvljajutsja metody za kotorymy skryvajutsja realnye vyvody soobschenij,
    //no ljuboj klass kotoryj budet manipulirovat naschime interface ne budet
    //znat kak imenno realizovan vyvod soobschenij.
    //V dannom sluchae etot vyvod realisovan cheres MessageBox. No mogli by byt bsp
    //sapis v log fail usw.

    //Sdes vazhno, chto est interface, est klass realisujuschij etot interface i est
    //Klass kotoryj obraschajetsja k etomu interface.

    //V etom sluchae PRESENTER kotoryj ne imeet dostupa k view vospolzuetsja
    //INTERFACE dlja vyvoda preduprezhdenij ob oschibkach.
    class MessageService: IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Nachricht", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
