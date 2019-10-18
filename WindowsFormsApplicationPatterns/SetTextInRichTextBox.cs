using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    class SetTextInRichTextBox
    {
        static string famileName = "Microsoft Sans Serif";

        static float sizeShrift = 9.75F;

        Font normalFont = new Font(famileName, sizeShrift, FontStyle.Regular);

        Font boldFont = new Font(famileName, sizeShrift, FontStyle.Bold);

        Font italicFont = new Font(famileName, sizeShrift, FontStyle.Italic);

        Font boltItalicFont = new Font(famileName, sizeShrift, FontStyle.Italic | FontStyle.Bold);

        public void InsertText(RichTextBox rich, bool bolt, bool italic, string text)
        {
            if(bolt && !italic)
            {
                rich.SelectionFont = boldFont;
            }
            else if(!bolt && italic)
            {
                rich.SelectionFont = italicFont;
            }
            else if (bolt && italic)
            {
                rich.SelectionFont = boltItalicFont;
            }
            else
            {
                rich.SelectionFont = normalFont;
            }
            rich.AppendText(text);
        }
    }
}
