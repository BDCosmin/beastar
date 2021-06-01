namespace BeAStar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.helppage1 = new BeAStar.helppage();
            this.home1 = new BeAStar.home();
            this.play1 = new BeAStar.play();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BeAStar.Properties.Resources.home_button_icon;
            this.button1.Location = new System.Drawing.Point(12, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 147);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BeAStar.Properties.Resources.play_button_icon;
            this.button2.Location = new System.Drawing.Point(12, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 145);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BeAStar.Properties.Resources.help_button_icon;
            this.button3.Location = new System.Drawing.Point(10, 633);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 149);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // helppage1
            // 
            this.helppage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helppage1.BackgroundImage")));
            this.helppage1.Location = new System.Drawing.Point(205, 117);
            this.helppage1.Name = "helppage1";
            this.helppage1.Size = new System.Drawing.Size(1335, 728);
            this.helppage1.TabIndex = 4;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.Location = new System.Drawing.Point(205, 117);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1335, 810);
            this.home1.TabIndex = 5;
            // 
            // play1
            // 
            this.play1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play1.BackgroundImage")));
            this.play1.Location = new System.Drawing.Point(205, 117);
            this.play1.Name = "play1";
            this.play1.Size = new System.Drawing.Size(1345, 810);
            this.play1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BeAStar.Properties.Resources.beas_main1;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.helppage1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.play1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Be A Star";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private helppage helppage1;
        private home home1;
        private play play1;
    }
}

