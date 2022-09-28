namespace Final_Majorowrk
{
    partial class GameMode
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
            this.Capture = new System.Windows.Forms.RadioButton();
            this.Avalanche = new System.Windows.Forms.RadioButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Random = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Capture
            // 
            this.Capture.AutoSize = true;
            this.Capture.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.Capture.Location = new System.Drawing.Point(19, 26);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(114, 35);
            this.Capture.TabIndex = 0;
            this.Capture.TabStop = true;
            this.Capture.Text = "Capture";
            this.Capture.UseVisualStyleBackColor = true;
            this.Capture.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Avalanche
            // 
            this.Avalanche.AutoSize = true;
            this.Avalanche.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.Avalanche.Location = new System.Drawing.Point(19, 87);
            this.Avalanche.Name = "Avalanche";
            this.Avalanche.Size = new System.Drawing.Size(137, 35);
            this.Avalanche.TabIndex = 1;
            this.Avalanche.TabStop = true;
            this.Avalanche.Text = "Avalanche";
            this.Avalanche.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(337, 370);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(134, 51);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_continue.Location = new System.Drawing.Point(142, 370);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(134, 51);
            this.btn_continue.TabIndex = 2;
            this.btn_continue.Text = "Start";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Avalanche);
            this.groupBox1.Controls.Add(this.Capture);
            this.groupBox1.Location = new System.Drawing.Point(98, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Random);
            this.groupBox2.Controls.Add(this.Normal);
            this.groupBox2.Location = new System.Drawing.Point(478, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.Random.Location = new System.Drawing.Point(21, 87);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(112, 35);
            this.Random.TabIndex = 1;
            this.Random.TabStop = true;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.Normal.Location = new System.Drawing.Point(21, 26);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(108, 35);
            this.Normal.TabIndex = 0;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(110, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 38);
            this.label14.TabIndex = 49;
            this.label14.Text = "Game Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 50;
            this.label1.Text = "Difficulty";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(524, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 59;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_continue);
            this.Name = "GameMode";
            this.Text = "GameMode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Capturre;
        private System.Windows.Forms.RadioButton Avalanche;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Random;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}