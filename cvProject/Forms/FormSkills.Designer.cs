
namespace cvProject.Forms
{
    partial class FormSkills
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
            this.language_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // language_lb
            // 
            this.language_lb.AutoSize = true;
            this.language_lb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_lb.ForeColor = System.Drawing.Color.Gray;
            this.language_lb.Location = new System.Drawing.Point(44, 48);
            this.language_lb.Name = "language_lb";
            this.language_lb.Size = new System.Drawing.Size(108, 23);
            this.language_lb.TabIndex = 3;
            this.language_lb.Text = "Language";
            // 
            // FormSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 567);
            this.Controls.Add(this.language_lb);
            this.Name = "FormSkills";
            this.Text = "FormSkills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label language_lb;
    }
}