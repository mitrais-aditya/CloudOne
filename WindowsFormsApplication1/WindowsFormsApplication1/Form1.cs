using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Form for testing.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.textBoxName.Text = "Good";
        }

        /// <summary>
        /// Handles the Click event of the buttonOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
