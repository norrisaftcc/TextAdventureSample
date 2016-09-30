using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAdventure
{
    public partial class MainForm : Form
    {
        // The form's only responsibility is to provide text input
        // to GameEngine, and display its output.
        private GameEngine engine;

        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // init game engine
            engine = new GameEngine();

            // pressing enter presses 'Submit'
            this.AcceptButton = btnSubmit;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // whenever output updates, scroll to the new text (last output)
            // set the current caret position to the end
            rtOutput.SelectionStart = rtOutput.Text.Length;
            // scroll it automatically
            rtOutput.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Submitted text" + txtInput.Text);

            // submit command to game engine
            string output = engine.doCommand(txtInput.Text);

            // display output
            rtOutput.Text += output + engine.NEWLINE;
            // clear input for next command
            txtInput.Text = "";

            // set focus to the input control
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            // by using this.AcceptButton, this is not needed.
            // enter will click the submit button
        }
    }
}
