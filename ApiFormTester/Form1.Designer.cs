
namespace ApiFormTester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jokeBtn = new System.Windows.Forms.Button();
            this.jokeCategoriesCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // jokeBtn
            // 
            this.jokeBtn.Location = new System.Drawing.Point(86, 87);
            this.jokeBtn.Name = "jokeBtn";
            this.jokeBtn.Size = new System.Drawing.Size(99, 31);
            this.jokeBtn.TabIndex = 0;
            this.jokeBtn.Text = "Generate Joke";
            this.jokeBtn.UseVisualStyleBackColor = true;
            this.jokeBtn.Click += new System.EventHandler(this.jokeBtn_Click);
            // 
            // jokeCategoriesCbx
            // 
            this.jokeCategoriesCbx.FormattingEnabled = true;
            this.jokeCategoriesCbx.Location = new System.Drawing.Point(76, 143);
            this.jokeCategoriesCbx.Name = "jokeCategoriesCbx";
            this.jokeCategoriesCbx.Size = new System.Drawing.Size(121, 23);
            this.jokeCategoriesCbx.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 408);
            this.Controls.Add(this.jokeCategoriesCbx);
            this.Controls.Add(this.jokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jokeBtn;
        private System.Windows.Forms.ComboBox jokeCategoriesCbx;
    }
}

