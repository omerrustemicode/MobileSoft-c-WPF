namespace MobileSHop_Soft
{
    partial class start
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bprogress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.tprogress = new Guna.UI2.WinForms.Guna2ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = global::MobileSHop_Soft.Properties.Resources.ermobilelogo11;
            this.pictureBox1.Image = global::MobileSHop_Soft.Properties.Resources.ermobilelogo11;
            this.pictureBox1.InitialImage = global::MobileSHop_Soft.Properties.Resources.ermobilelogo11;
            this.pictureBox1.Location = new System.Drawing.Point(161, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 361);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bprogress
            // 
            this.bprogress.FillColor = System.Drawing.Color.White;
            this.bprogress.Location = new System.Drawing.Point(82, 409);
            this.bprogress.Name = "bprogress";
            this.bprogress.ProgressColor = System.Drawing.Color.Yellow;
            this.bprogress.ProgressColor2 = System.Drawing.Color.Yellow;
            this.bprogress.ShadowDecoration.Parent = this.bprogress;
            this.bprogress.Size = new System.Drawing.Size(561, 10);
            this.bprogress.TabIndex = 6;
            this.bprogress.Text = "guna2ProgressBar2";
            this.bprogress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // tprogress
            // 
            this.tprogress.FillColor = System.Drawing.Color.White;
            this.tprogress.Location = new System.Drawing.Point(82, 12);
            this.tprogress.Name = "tprogress";
            this.tprogress.ProgressColor = System.Drawing.Color.Yellow;
            this.tprogress.ProgressColor2 = System.Drawing.Color.Yellow;
            this.tprogress.ShadowDecoration.Parent = this.tprogress;
            this.tprogress.Size = new System.Drawing.Size(561, 10);
            this.tprogress.TabIndex = 7;
            this.tprogress.Text = "guna2ProgressBar2";
            this.tprogress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.tprogress);
            this.Controls.Add(this.bprogress);
            this.Controls.Add(this.pictureBox1);
            this.Name = "start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar bprogress;
        private Guna.UI2.WinForms.Guna2ProgressBar tprogress;
    }
}

