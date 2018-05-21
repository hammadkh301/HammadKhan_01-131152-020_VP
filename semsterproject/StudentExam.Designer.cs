namespace semsterproject
{
    partial class StudentExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentExam));
            this.StartExam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartExam
            // 
            this.StartExam.Location = new System.Drawing.Point(157, 93);
            this.StartExam.Name = "StartExam";
            this.StartExam.Size = new System.Drawing.Size(134, 23);
            this.StartExam.TabIndex = 0;
            this.StartExam.Text = "Start Exam";
            this.StartExam.UseVisualStyleBackColor = true;
            this.StartExam.Click += new System.EventHandler(this.StartExam_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(536, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartExam);
            this.Name = "StudentExam";
            this.Text = "StudentExam";
            this.Load += new System.EventHandler(this.StudentExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartExam;
        private System.Windows.Forms.Button button1;
    }
}