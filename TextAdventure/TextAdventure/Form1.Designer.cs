namespace TextAdventure
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtOutput
            // 
            this.rtOutput.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtOutput.ForeColor = System.Drawing.SystemColors.Info;
            this.rtOutput.Location = new System.Drawing.Point(25, 23);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.ReadOnly = true;
            this.rtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtOutput.Size = new System.Drawing.Size(655, 472);
            this.rtOutput.TabIndex = 0;
            this.rtOutput.Text = "Press Enter to begin.";
            this.rtOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.Info;
            this.txtInput.Location = new System.Drawing.Point(25, 531);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(565, 29);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(605, 529);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(703, 617);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rtOutput);
            this.Name = "MainForm";
            this.Text = "Text Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
    }
}

