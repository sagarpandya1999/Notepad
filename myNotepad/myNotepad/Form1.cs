using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialoge = new OpenFileDialog();
            if (dialoge.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(dialoge.FileName, RichTextBoxStreamType.PlainText);
            this.Text = dialoge.FileName;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sfd.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fd.Font;
        }

        private void backgrondcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = cd.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("version: 2.O\ncreated by: Sagar Pandya");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timedateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("HH:mm:ss"));
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Today.ToString("dd-MM-yyyy"));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pageSetupDialog1.Document = pd;
            pageSetupDialog1.ShowDialog();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void overwriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

    }
}
