
namespace cvProject.Forms
{
    partial class FormWorkExperience
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Education_dv = new System.Windows.Forms.DataGridView();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.description_lb = new System.Windows.Forms.Label();
            this.startDate_lb = new System.Windows.Forms.Label();
            this.position_tb = new System.Windows.Forms.TextBox();
            this.position_lb = new System.Windows.Forms.Label();
            this.company_tb = new System.Windows.Forms.TextBox();
            this.company_lb = new System.Windows.Forms.Label();
            this.endDate_lb = new System.Windows.Forms.Label();
            this.endDate_time = new System.Windows.Forms.DateTimePicker();
            this.startDate_time = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Education_dv)).BeginInit();
            this.SuspendLayout();
            // 
            // Education_dv
            // 
            this.Education_dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Education_dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Education_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Education_dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Education_dv.Location = new System.Drawing.Point(58, 308);
            this.Education_dv.Name = "Education_dv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Education_dv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Education_dv.RowHeadersWidth = 62;
            this.Education_dv.RowTemplate.Height = 28;
            this.Education_dv.Size = new System.Drawing.Size(832, 129);
            this.Education_dv.TabIndex = 21;
            // 
            // description_tb
            // 
            this.description_tb.BackColor = System.Drawing.Color.LightGray;
            this.description_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_tb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(363, 163);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(527, 107);
            this.description_tb.TabIndex = 20;
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.ForeColor = System.Drawing.Color.Gray;
            this.description_lb.Location = new System.Drawing.Point(359, 138);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(119, 23);
            this.description_lb.TabIndex = 19;
            this.description_lb.Text = "Description";
            // 
            // startDate_lb
            // 
            this.startDate_lb.AutoSize = true;
            this.startDate_lb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate_lb.ForeColor = System.Drawing.Color.Gray;
            this.startDate_lb.Location = new System.Drawing.Point(670, 35);
            this.startDate_lb.Name = "startDate_lb";
            this.startDate_lb.Size = new System.Drawing.Size(103, 23);
            this.startDate_lb.TabIndex = 17;
            this.startDate_lb.Text = "Start Date";
            // 
            // position_tb
            // 
            this.position_tb.BackColor = System.Drawing.Color.LightGray;
            this.position_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.position_tb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_tb.Location = new System.Drawing.Point(363, 60);
            this.position_tb.Multiline = true;
            this.position_tb.Name = "position_tb";
            this.position_tb.Size = new System.Drawing.Size(216, 39);
            this.position_tb.TabIndex = 16;
            // 
            // position_lb
            // 
            this.position_lb.AutoSize = true;
            this.position_lb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_lb.ForeColor = System.Drawing.Color.Gray;
            this.position_lb.Location = new System.Drawing.Point(359, 35);
            this.position_lb.Name = "position_lb";
            this.position_lb.Size = new System.Drawing.Size(84, 23);
            this.position_lb.TabIndex = 15;
            this.position_lb.Text = "Position";
            // 
            // company_tb
            // 
            this.company_tb.BackColor = System.Drawing.Color.LightGray;
            this.company_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.company_tb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_tb.Location = new System.Drawing.Point(58, 60);
            this.company_tb.Multiline = true;
            this.company_tb.Name = "company_tb";
            this.company_tb.Size = new System.Drawing.Size(216, 39);
            this.company_tb.TabIndex = 14;
            // 
            // company_lb
            // 
            this.company_lb.AutoSize = true;
            this.company_lb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_lb.ForeColor = System.Drawing.Color.Gray;
            this.company_lb.Location = new System.Drawing.Point(54, 35);
            this.company_lb.Name = "company_lb";
            this.company_lb.Size = new System.Drawing.Size(108, 23);
            this.company_lb.TabIndex = 13;
            this.company_lb.Text = "Company";
            // 
            // endDate_lb
            // 
            this.endDate_lb.AutoSize = true;
            this.endDate_lb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate_lb.ForeColor = System.Drawing.Color.Gray;
            this.endDate_lb.Location = new System.Drawing.Point(54, 138);
            this.endDate_lb.Name = "endDate_lb";
            this.endDate_lb.Size = new System.Drawing.Size(97, 23);
            this.endDate_lb.TabIndex = 22;
            this.endDate_lb.Text = "End Date";
            // 
            // endDate_time
            // 
            this.endDate_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate_time.Location = new System.Drawing.Point(58, 173);
            this.endDate_time.Name = "endDate_time";
            this.endDate_time.Size = new System.Drawing.Size(200, 26);
            this.endDate_time.TabIndex = 23;
            // 
            // startDate_time
            // 
            this.startDate_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate_time.Location = new System.Drawing.Point(674, 73);
            this.startDate_time.Name = "startDate_time";
            this.startDate_time.Size = new System.Drawing.Size(200, 26);
            this.startDate_time.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Company";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Position";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start Date";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "End Date";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete_btn.Location = new System.Drawing.Point(683, 485);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(147, 45);
            this.delete_btn.TabIndex = 27;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_btn.Location = new System.Drawing.Point(401, 485);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(147, 45);
            this.update_btn.TabIndex = 26;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(185)))), ((int)(((byte)(223)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_btn.Location = new System.Drawing.Point(119, 485);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(147, 45);
            this.add_btn.TabIndex = 25;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // FormWorkExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 567);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.startDate_time);
            this.Controls.Add(this.endDate_time);
            this.Controls.Add(this.endDate_lb);
            this.Controls.Add(this.Education_dv);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.startDate_lb);
            this.Controls.Add(this.position_tb);
            this.Controls.Add(this.position_lb);
            this.Controls.Add(this.company_tb);
            this.Controls.Add(this.company_lb);
            this.Name = "FormWorkExperience";
            this.Text = "FormWorkExperience";
            ((System.ComponentModel.ISupportInitialize)(this.Education_dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Education_dv;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label startDate_lb;
        private System.Windows.Forms.TextBox position_tb;
        private System.Windows.Forms.Label position_lb;
        private System.Windows.Forms.TextBox company_tb;
        private System.Windows.Forms.Label company_lb;
        private System.Windows.Forms.Label endDate_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker endDate_time;
        private System.Windows.Forms.DateTimePicker startDate_time;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
    }
}