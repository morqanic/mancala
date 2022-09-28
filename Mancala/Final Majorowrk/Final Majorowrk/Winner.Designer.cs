namespace Final_Majorowrk
{
    partial class Winner
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.btn_rules = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(218, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 55);
            this.label1.TabIndex = 51;
            this.label1.Text = "Congratulations!!!!";
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_win.Location = new System.Drawing.Point(235, 164);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(313, 55);
            this.lbl_win.TabIndex = 52;
            this.lbl_win.Text = "Player 1 Won!!!";
            // 
            // btn_rules
            // 
            this.btn_rules.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_rules.Location = new System.Drawing.Point(337, 370);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(134, 51);
            this.btn_rules.TabIndex = 55;
            this.btn_rules.Text = "Mode";
            this.btn_rules.UseVisualStyleBackColor = true;
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_exit.Location = new System.Drawing.Point(524, 370);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 51);
            this.btn_exit.TabIndex = 54;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Comic Sans MS", 19.5F, System.Drawing.FontStyle.Bold);
            this.btn_home.Location = new System.Drawing.Point(142, 370);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(134, 51);
            this.btn_home.TabIndex = 53;
            this.btn_home.Text = "Rematch";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rules);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.label1);
            this.Name = "Winner";
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.Winner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Button btn_rules;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_home;
    }
}