namespace Assignment1
{
    partial class Assignment1
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
            lblFirstname = new Label();
            lblHoursworked = new Label();
            lblLastname = new Label();
            tbxFirstname = new TextBox();
            tbxLastname = new TextBox();
            tbxHoursworked = new TextBox();
            Bnsummarize = new Button();
            Bnclear = new Button();
            lblSummary = new Label();
            SuspendLayout();
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstname.Location = new Point(152, 39);
            lblFirstname.Margin = new Padding(5, 0, 5, 0);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(124, 25);
            lblFirstname.TabIndex = 0;
            lblFirstname.Text = "&First Name";//& gives Alt f 
            lblFirstname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoursworked
            // 
            lblHoursworked.AutoSize = true;
            lblHoursworked.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoursworked.Location = new Point(533, 39);
            lblHoursworked.Margin = new Padding(5, 0, 5, 0);
            lblHoursworked.Name = "lblHoursworked";
            lblHoursworked.Size = new Size(159, 25);
            lblHoursworked.TabIndex = 1;
            lblHoursworked.Text = "&Hours Worked";// gives alt H
            lblHoursworked.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(323, 39);
            lblLastname.Margin = new Padding(5, 0, 5, 0);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(121, 25);
            lblLastname.TabIndex = 2;
            lblLastname.Text = "&Last Name";// gives alt L 
            lblLastname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxFirstname
            // 
            tbxFirstname.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxFirstname.Location = new Point(151, 67);
            tbxFirstname.Name = "tbxFirstname";
            tbxFirstname.Size = new Size(151, 39);
            tbxFirstname.TabIndex = 1;
            tbxFirstname.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxLastname
            // 
            tbxLastname.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxLastname.Location = new Point(323, 67);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.Size = new Size(173, 39);
            tbxLastname.TabIndex = 2;
            tbxLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxHoursworked
            // 
            tbxHoursworked.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxHoursworked.Location = new Point(533, 67);
            tbxHoursworked.Name = "tbxHoursworked";
            tbxHoursworked.Size = new Size(159, 39);
            tbxHoursworked.TabIndex = 3;
            tbxHoursworked.TextAlign = HorizontalAlignment.Center;
            // 
            // Bnsummarize
            // 
            Bnsummarize.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bnsummarize.Location = new Point(153, 144);
            Bnsummarize.Name = "Bnsummarize";
            Bnsummarize.Size = new Size(250, 79);
            Bnsummarize.TabIndex = 4;
            Bnsummarize.Text = "&Summarize";//gives alt S access
            Bnsummarize.UseVisualStyleBackColor = true;
            Bnsummarize.Click += Bnsummarize_Click;
            // 
            // Bnclear
            // 
            Bnclear.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bnclear.Location = new Point(409, 144);
            Bnclear.Name = "Bnclear";
            Bnclear.Size = new Size(250, 79);
            Bnclear.TabIndex = 5;
            Bnclear.Text = "&Clear";//gives alt c access
            Bnclear.UseVisualStyleBackColor = true;
            Bnclear.Click += Bnclear_Click;
            // 
            // lblSummary
            // 
            lblSummary.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(153, 358);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(524, 84);
            lblSummary.TabIndex = 0;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Assignment1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(lblSummary);
            Controls.Add(Bnclear);
            Controls.Add(Bnsummarize);
            Controls.Add(tbxHoursworked);
            Controls.Add(tbxLastname);
            Controls.Add(tbxFirstname);
            Controls.Add(lblLastname);
            Controls.Add(lblHoursworked);
            Controls.Add(lblFirstname);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Assignment1";
            Text = "Assignment 1";
            Load += Assignment1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstname;
        private Label lblHoursworked;
        private Label lblLastname;
        private TextBox tbxFirstname;
        private TextBox tbxLastname;
        private TextBox tbxHoursworked;
        private Button Bnsummarize;
        private Button Bnclear;
        private Label lblSummary;
    }
}
