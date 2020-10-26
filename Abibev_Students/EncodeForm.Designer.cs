namespace Abibev_Students
{
    partial class EncodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.qrPic = new System.Windows.Forms.PictureBox();
            this.encBtn = new System.Windows.Forms.Button();
            this.saveQrBtn = new System.Windows.Forms.Button();
            this.savePdfBtn = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(178, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(401, 39);
            this.nameBox.TabIndex = 3;
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(178, 165);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(401, 39);
            this.courseBox.TabIndex = 3;
            this.courseBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(178, 86);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(401, 39);
            this.surnameBox.TabIndex = 3;
            // 
            // qrPic
            // 
            this.qrPic.Location = new System.Drawing.Point(39, 271);
            this.qrPic.Name = "qrPic";
            this.qrPic.Size = new System.Drawing.Size(279, 253);
            this.qrPic.TabIndex = 4;
            this.qrPic.TabStop = false;
            this.qrPic.Click += new System.EventHandler(this.qrDisplay_Click);
            // 
            // encBtn
            // 
            this.encBtn.Location = new System.Drawing.Point(373, 271);
            this.encBtn.Name = "encBtn";
            this.encBtn.Size = new System.Drawing.Size(150, 46);
            this.encBtn.TabIndex = 5;
            this.encBtn.Text = "Encode";
            this.encBtn.UseVisualStyleBackColor = true;
            this.encBtn.Click += new System.EventHandler(this.encBtn_Click);
            // 
            // saveQrBtn
            // 
            this.saveQrBtn.Enabled = false;
            this.saveQrBtn.Location = new System.Drawing.Point(373, 348);
            this.saveQrBtn.Name = "saveQrBtn";
            this.saveQrBtn.Size = new System.Drawing.Size(150, 46);
            this.saveQrBtn.TabIndex = 6;
            this.saveQrBtn.Text = "Save Qr";
            this.saveQrBtn.UseVisualStyleBackColor = true;
            this.saveQrBtn.Click += new System.EventHandler(this.saveQrBtn_Click);
            // 
            // savePdfBtn
            // 
            this.savePdfBtn.Enabled = false;
            this.savePdfBtn.Location = new System.Drawing.Point(373, 438);
            this.savePdfBtn.Name = "savePdfBtn";
            this.savePdfBtn.Size = new System.Drawing.Size(150, 46);
            this.savePdfBtn.TabIndex = 7;
            this.savePdfBtn.Text = "Save PDF";
            this.savePdfBtn.UseVisualStyleBackColor = true;
            this.savePdfBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.AcceptsTab = true;
            this.detailsBox.BulletIndent = 1;
            this.detailsBox.Enabled = false;
            this.detailsBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailsBox.Location = new System.Drawing.Point(631, 13);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.detailsBox.Size = new System.Drawing.Size(667, 710);
            this.detailsBox.TabIndex = 6;
            this.detailsBox.Text = "Profile :\n                                                              ";
            this.detailsBox.WordWrap = false;
            this.detailsBox.TextChanged += new System.EventHandler(this.detailsBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 821);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.savePdfBtn);
            this.Controls.Add(this.saveQrBtn);
            this.Controls.Add(this.encBtn);
            this.Controls.Add(this.qrPic);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.PictureBox qrPic;
        private System.Windows.Forms.Button encBtn;
        private System.Windows.Forms.Button svQR;
        private System.Windows.Forms.Button savePdfBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveQrBtn;
        private System.Windows.Forms.RichTextBox detailsBox;
    }
}

