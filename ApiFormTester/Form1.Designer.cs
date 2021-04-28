
namespace ApiFormTester
{
    partial class jokeForm
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
            this.jokeTxt = new System.Windows.Forms.TextBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jokeBtn
            // 
            this.jokeBtn.Location = new System.Drawing.Point(90, 165);
            this.jokeBtn.Name = "jokeBtn";
            this.jokeBtn.Size = new System.Drawing.Size(112, 35);
            this.jokeBtn.TabIndex = 0;
            this.jokeBtn.Text = "Generate Joke";
            this.jokeBtn.UseVisualStyleBackColor = true;
            this.jokeBtn.Click += new System.EventHandler(this.jokeBtn_Click);
            // 
            // jokeCategoriesCbx
            // 
            this.jokeCategoriesCbx.FormattingEnabled = true;
            this.jokeCategoriesCbx.Location = new System.Drawing.Point(112, 217);
            this.jokeCategoriesCbx.Name = "jokeCategoriesCbx";
            this.jokeCategoriesCbx.Size = new System.Drawing.Size(119, 23);
            this.jokeCategoriesCbx.TabIndex = 1;
            // 
            // jokeTxt
            // 
            this.jokeTxt.Enabled = false;
            this.jokeTxt.Location = new System.Drawing.Point(46, 18);
            this.jokeTxt.Multiline = true;
            this.jokeTxt.Name = "jokeTxt";
            this.jokeTxt.Size = new System.Drawing.Size(197, 136);
            this.jokeTxt.TabIndex = 2;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(40, 220);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(66, 15);
            this.categoryLbl.TabIndex = 3;
            this.categoryLbl.Text = "Categories:";
            // 
            // jokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 280);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.jokeTxt);
            this.Controls.Add(this.jokeCategoriesCbx);
            this.Controls.Add(this.jokeBtn);
            this.Name = "jokeForm";
            this.Text = "Chuck Norris Joke Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jokeBtn;
        private System.Windows.Forms.ComboBox jokeCategoriesCbx;
        private System.Windows.Forms.TextBox jokeTxt;
        private System.Windows.Forms.Label categoryLbl;
    }
}

