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
using System.Windows.Input;

// All main features realised. Realised one secondary feanture (about C# files opening and saving). Added settings saving.
// Many little features added. Form1.Designer.cs is kinda dirty cause it lives its own life.

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            TabPageInitialisation();
            TimerInitialisation();
        }

        /// <summary>
        /// Function which create new tab in current window and maybe open text file there.
        /// </summary>
        /// <param name="name"> Tab name. </param>
        /// <param name="text"> Text which will be shown in tab. </param>
        private void TabPageInitialisation(string name = "Untitled", string text = "")
        {
            TabPage page = new TabPage();
            tabControl.TabPages.Add(page);
            page.Text = name;
            RichTextBox textbox = new RichTextBox();
            page.Controls.Add(textbox);
            textbox.Location = new Point(0, 0);
            textbox.Size = page.Size;
            textbox.Visible = true;
            // For autosizing window.
            textbox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            textbox.MouseDown += new MouseEventHandler(richTextBox1_MouseDown);
            textbox.Text = text;
            tabControl.SelectedTab = page;
        }
        /// <summary>
        /// Function which initialise timer and set default value from settings.txt.
        /// </summary>
        private void TimerInitialisation()
        {
            timer.Tick += new EventHandler(Timer_Tick);
            int tmp = 0;
            int.TryParse(System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\settings.txt"), out tmp);
            timer.Interval = tmp;
            // Set checks in menu.
            switch (timer.Interval)
            {
                case int.MaxValue:
                    AutosavingNever_Click(this, null);
                    break;
                case 30000:
                    Autosaving30sec_Click(this, null);
                    break;
                case 60000:
                    Autosaving1min_Click(this, null);
                    break;
                case 300000:
                    Autosaving5min_Click(this, null);
                    break;
                case 900000:
                    Autosaving15min_Click(this, null);
                    break;
            }
            timer.Start();
        }
        /// <summary>
        /// Autosaving current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Autosaving works only for already saved files.
            if (tabControl.SelectedTab.Text != "Untitled")
            {
                System.IO.File.WriteAllText(tabControl.SelectedTab.Text, tabControl.SelectedTab.Controls[0].Text);
            }
        }

        /// <summary>
        /// Function for open file. Support txt, rtf and cs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            // Checking if file chosen.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TabPageInitialisation(openFileDialog.FileName, System.IO.File.ReadAllText(openFileDialog.FileName));
            }
        }
        /// <summary>
        /// Function for creating new blank tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Click(object sender, EventArgs e)
        {
            TabPageInitialisation();
        }
        /// <summary>
        /// Function for saving curretn file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            // Checking if file already saved as.
            if (tabControl.SelectedTab.Text != "Untitled")
            {
                System.IO.File.WriteAllText(tabControl.SelectedTab.Text, tabControl.SelectedTab.Controls[0].Text);
            }
            // If not saving as.
            else
            {
                SaveAs_Click(sender, e);
            }
        }
        /// <summary>
        /// Function for saving file as cooler file. Support txt, rtf and cs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAs_Click(object sender, EventArgs e)
        { 
            // Checking if filename chosen correctly.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tabControl.SelectedTab.Text = saveFileDialog.FileName;
                System.IO.File.WriteAllText(saveFileDialog.FileName, tabControl.SelectedTab.Controls[0].Text);
            }
        }

        // Next five functions apply not only to selected area but will apply to every new symbol after this area.
        /// <summary>
        /// Make selected area bold.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bold_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionFont = new Font(Form1.DefaultFont, FontStyle.Bold);
        }
        /// <summary>
        /// Make selected area italic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Italic_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionFont = new Font(Form1.DefaultFont, FontStyle.Italic);
        }
        /// <summary>
        /// Underline selected area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Underline_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionFont = new Font(Form1.DefaultFont, FontStyle.Underline);
        }
        /// <summary>
        /// Strikeout selected area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Strikeout_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionFont = new Font(Form1.DefaultFont, FontStyle.Strikeout);
        }
        /// <summary>
        /// Make selected area regular.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Regular_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionFont = new Font(Form1.DefaultFont, FontStyle.Regular);
        }

        /// <summary>
        /// Set timer interval on very big number and set checks in menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutosavingNever_Click(object sender, EventArgs e)
        {
            timer.Interval = int.MaxValue;
            AutosavingNever.Checked = true;
            Autosaving30sec.Checked = false;
            Autosaving1min.Checked = false;
            Autosaving5min.Checked = false;
            Autosaving15min.Checked = false;
        }
        /// <summary>
        /// Set timer interval on 30 sec and set checks in menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Autosaving30sec_Click(object sender, EventArgs e)
        {
            timer.Interval = 30000;
            AutosavingNever.Checked = false;
            Autosaving30sec.Checked = true;
            Autosaving1min.Checked = false;
            Autosaving5min.Checked = false;
            Autosaving15min.Checked = false;
        }
        /// <summary>
        /// Set timer interval on 1 min and set checks in menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Autosaving1min_Click(object sender, EventArgs e)
        {
            timer.Interval = 60000;
            AutosavingNever.Checked = false;
            Autosaving30sec.Checked = false;
            Autosaving1min.Checked = true;
            Autosaving5min.Checked = false;
            Autosaving15min.Checked = false;
        }
        /// <summary>
        /// Set timer interval on 5 min and set checks in menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Autosaving5min_Click(object sender, EventArgs e)
        {
            timer.Interval = 300000;
            AutosavingNever.Checked = false;
            Autosaving30sec.Checked = false;
            Autosaving1min.Checked = false;
            Autosaving5min.Checked = true;
            Autosaving15min.Checked = false;
        }
        /// <summary>
        /// Set timer interval on 15 min and set checks in menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Autosaving15min_Click(object sender, EventArgs e)
        {
            timer.Interval = 900000;
            AutosavingNever.Checked = false;
            Autosaving30sec.Checked = false;
            Autosaving1min.Checked = false;
            Autosaving5min.Checked = false;
            Autosaving15min.Checked = true;
        }

        /// <summary>
        /// Check if right click menu called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                EditMenu.Show(Cursor.Position);
            }
        }
        /// <summary>
        /// Select all text in current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectAll();
        }
        /// <summary>
        /// Cut selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cut_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).Cut();
        }
        /// <summary>
        /// Copy selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Copy_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).Copy();
        }
        /// <summary>
        /// Paste copied text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paste_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).Paste();
        }

        /// <summary>
        /// Checking if ctrl+keys pressed and do some things. In fact I have no idea how this works.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                Save_Click(this, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                New_Click(this, null);
                return true;
            }
            // At least this I found in google.
            else if (keyData == (Keys.Control | Keys.K | Keys.S))
            {
                SaveAll();
                return true;
            }
            // At least this I found in google.
            else if (keyData == (Keys.Control | Keys.Enter))
            {
                NewWindow();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /// <summary>
        /// Saving all files in current window. This is like Save_click but with no SelectedTab stuff.
        /// </summary>
        private void SaveAll()
        {
            foreach (TabPage page in tabControl.TabPages)
            {
                if (tabControl.SelectedTab.Text != "Untitled")
                {
                    System.IO.File.WriteAllText(page.Text, page.Controls[0].Text);
                }
                else if (saveFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    System.IO.File.WriteAllText(saveFileDialog.FileName, page.Controls[0].Text);
                }
            }
        }
        /// <summary>
        /// Crating new window.
        /// </summary>
        private void NewWindow()
        {
            new Form1().Show();
        }

        /// <summary>
        /// Checking if everything saved and save it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Saving settings.
            System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\\settings.txt", $"{timer.Interval}");
            foreach (TabPage page in tabControl.TabPages)
            {
                // If file name is Untitled or file have been changed it should be saved.
                if (page.Text == "Untitled" || page.Controls[0].Text != System.IO.File.ReadAllText(page.Text))
                {
                    // If file name is Untitled and it is empty it shouldn't.
                    if (page.Text == "Untitled" && page.Controls[0].Text == "")
                    {
                        continue;
                    }
                    // Asking user if they want to save file. 
                    string message = $"You haven't saved {page.Text}. You want to save it?";
                    string caption = "Unsaved file";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                    // If they want save it.
                    if (result == DialogResult.Yes)
                    {
                        Save_Click(sender, e);
                    }
                    // If they want to cancel closing - cansel it.
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
