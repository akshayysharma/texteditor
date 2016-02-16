using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt) |*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(open.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt) |*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "Text Files (*.txt) |*.txt";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(open1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            SaveFileDialog save1 = new SaveFileDialog();
            save1.Filter = "Text Files(*.txt) |*.txt";
            if (save1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(save1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new
            Font(richTextBox1.SelectionFont, FontStyle.Bold);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new
            Font(richTextBox1.SelectionFont, FontStyle.Italic);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new
            Font(richTextBox1.SelectionFont, FontStyle.Underline);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new
            Font(richTextBox1.SelectionFont, FontStyle.Strikeout);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill;
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStrip1.ImageScalingSize = new Size(40, 40);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            float zoom = richTextBox1.ZoomFactor;
            if (zoom * 2 < 64)
                richTextBox1.ZoomFactor = zoom * 2;

        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            float zoom1 = richTextBox1.ZoomFactor;
            if (zoom1 / 2 > 0.32)
                richTextBox1.ZoomFactor = zoom1 / 2;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            //show the dialog
            DialogResult result = fontDialog1.ShowDialog();
            //see if ok was pressed
            if (result == DialogResult.OK)
            { 
                //get font
                Font f = fontDialog1.Font;
                //set textbox properties
                this.richTextBox1.Text = string.Format("Font:{0}", f.Name);
                this.richTextBox1.Font = f;
            }
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            ColorDialog paint1=new ColorDialog();
            
            //keeps the user from selecting a custom color
            paint1.AllowFullOpen=false;
            
            //allow user to get help
            paint1.ShowHelp=true;

            //set the initial color
            paint1.Color=richTextBox1.ForeColor;

            //update the textbox color
            if(paint1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor=paint1.Color;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void myNotepadHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the dialog
            DialogResult result1 = fontDialog1.ShowDialog();
            //see if ok was pressed
            if (result1 == DialogResult.OK)
            {
                //get font
                Font f1 = fontDialog1.Font;
                //set textbox properties
                this.richTextBox1.Text = string.Format("Font:{0}", f1.Name);
                this.richTextBox1.Font = f1;
            }
        }

       

        

        

     


      

     
          

        
        
        

        

       

       

        

        
    }

       
}
