namespace TH_Winform_W3
{
    partial class FormMainWindow
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
            this.buttonNextForm = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFavArtist = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFavArtist = new System.Windows.Forms.TextBox();
            this.checkBoxTrue = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNextForm
            // 
            this.buttonNextForm.Location = new System.Drawing.Point(95, 78);
            this.buttonNextForm.Name = "buttonNextForm";
            this.buttonNextForm.Size = new System.Drawing.Size(195, 49);
            this.buttonNextForm.TabIndex = 0;
            this.buttonNextForm.Text = "Open Next Form";
            this.buttonNextForm.UseVisualStyleBackColor = true;
            this.buttonNextForm.Click += new System.EventHandler(this.buttonNextForm_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(84, 187);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name: ";
            // 
            // labelFavArtist
            // 
            this.labelFavArtist.AutoSize = true;
            this.labelFavArtist.Location = new System.Drawing.Point(84, 255);
            this.labelFavArtist.Name = "labelFavArtist";
            this.labelFavArtist.Size = new System.Drawing.Size(186, 25);
            this.labelFavArtist.TabIndex = 2;
            this.labelFavArtist.Text = "My Favorite Artist:\r\n";
            this.labelFavArtist.Click += new System.EventHandler(this.labelFavArtist_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 181);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 31);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxFavArtist
            // 
            this.textBoxFavArtist.Location = new System.Drawing.Point(326, 249);
            this.textBoxFavArtist.Name = "textBoxFavArtist";
            this.textBoxFavArtist.Size = new System.Drawing.Size(140, 31);
            this.textBoxFavArtist.TabIndex = 4;
            // 
            // checkBoxTrue
            // 
            this.checkBoxTrue.AutoSize = true;
            this.checkBoxTrue.Location = new System.Drawing.Point(89, 339);
            this.checkBoxTrue.Name = "checkBoxTrue";
            this.checkBoxTrue.Size = new System.Drawing.Size(388, 29);
            this.checkBoxTrue.TabIndex = 5;
            this.checkBoxTrue.Text = "All of the content I put above is true!";
            this.checkBoxTrue.UseVisualStyleBackColor = true;
            this.checkBoxTrue.CheckedChanged += new System.EventHandler(this.checkBoxTrue_CheckedChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(326, 418);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(142, 33);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 647);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkBoxTrue);
            this.Controls.Add(this.textBoxFavArtist);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelFavArtist);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonNextForm);
            this.Name = "FormMainWindow";
            this.Text = "Main Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextForm;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFavArtist;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFavArtist;
        private System.Windows.Forms.CheckBox checkBoxTrue;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

