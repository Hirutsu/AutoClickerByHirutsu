namespace WindowsFormsApp2
{
    partial class AutoClicker
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TextLocationY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.FindPosCursor = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.TextBoxSecs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxMins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextLocationX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonRoleUp = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.TextLocationY);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.FindPosCursor);
            this.MainPanel.Controls.Add(this.ButtonStop);
            this.MainPanel.Controls.Add(this.StartButton);
            this.MainPanel.Controls.Add(this.TextBoxSecs);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.TextBoxMins);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.TextLocationX);
            this.MainPanel.Controls.Add(this.groupBox2);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(300, 271);
            this.MainPanel.TabIndex = 6;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(105, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Y";
            // 
            // TextLocationY
            // 
            this.TextLocationY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextLocationY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextLocationY.CausesValidation = false;
            this.TextLocationY.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextLocationY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLocationY.ForeColor = System.Drawing.Color.White;
            this.TextLocationY.Location = new System.Drawing.Point(87, 179);
            this.TextLocationY.Multiline = true;
            this.TextLocationY.Name = "TextLocationY";
            this.TextLocationY.ReadOnly = true;
            this.TextLocationY.Size = new System.Drawing.Size(60, 20);
            this.TextLocationY.TabIndex = 29;
            this.TextLocationY.TabStop = false;
            this.TextLocationY.Text = "0";
            this.TextLocationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(126, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 38);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Checked = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(8, 10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 23);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Double Click";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(94, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 17);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.Text = "One Click";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // FindPosCursor
            // 
            this.FindPosCursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.FindPosCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FindPosCursor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindPosCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindPosCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindPosCursor.ForeColor = System.Drawing.Color.White;
            this.FindPosCursor.Location = new System.Drawing.Point(162, 154);
            this.FindPosCursor.Name = "FindPosCursor";
            this.FindPosCursor.Size = new System.Drawing.Size(135, 45);
            this.FindPosCursor.TabIndex = 900;
            this.FindPosCursor.TabStop = false;
            this.FindPosCursor.Text = "PICK LOCATION (F3)";
            this.FindPosCursor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FindPosCursor.UseVisualStyleBackColor = false;
            this.FindPosCursor.Click += new System.EventHandler(this.FindPosCursor_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ButtonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStop.ForeColor = System.Drawing.Color.White;
            this.ButtonStop.Location = new System.Drawing.Point(162, 213);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(135, 48);
            this.ButtonStop.TabIndex = 905;
            this.ButtonStop.TabStop = false;
            this.ButtonStop.Text = "Stop (F12)";
            this.ButtonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(12, 213);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 48);
            this.StartButton.TabIndex = 18;
            this.StartButton.TabStop = false;
            this.StartButton.Text = "Start (F2)";
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TextBoxSecs
            // 
            this.TextBoxSecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxSecs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSecs.CausesValidation = false;
            this.TextBoxSecs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecs.ForeColor = System.Drawing.Color.White;
            this.TextBoxSecs.Location = new System.Drawing.Point(156, 38);
            this.TextBoxSecs.MaxLength = 2;
            this.TextBoxSecs.Name = "TextBoxSecs";
            this.TextBoxSecs.Size = new System.Drawing.Size(104, 37);
            this.TextBoxSecs.TabIndex = 12;
            this.TextBoxSecs.TabStop = false;
            this.TextBoxSecs.Text = "0";
            this.TextBoxSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSecs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSecs_KeyDown);
            this.TextBoxSecs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSecs_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(262, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "secs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "mins";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxMins
            // 
            this.TextBoxMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxMins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMins.CausesValidation = false;
            this.TextBoxMins.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMins.ForeColor = System.Drawing.Color.White;
            this.TextBoxMins.Location = new System.Drawing.Point(12, 38);
            this.TextBoxMins.MaxLength = 2;
            this.TextBoxMins.Name = "TextBoxMins";
            this.TextBoxMins.Size = new System.Drawing.Size(104, 37);
            this.TextBoxMins.TabIndex = 7;
            this.TextBoxMins.TabStop = false;
            this.TextBoxMins.Text = "0";
            this.TextBoxMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxMins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMins_KeyDown);
            this.TextBoxMins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMins_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click Interval";
            // 
            // TextLocationX
            // 
            this.TextLocationX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextLocationX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextLocationX.CausesValidation = false;
            this.TextLocationX.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextLocationX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLocationX.ForeColor = System.Drawing.Color.White;
            this.TextLocationX.Location = new System.Drawing.Point(12, 179);
            this.TextLocationX.Multiline = true;
            this.TextLocationX.Name = "TextLocationX";
            this.TextLocationX.ReadOnly = true;
            this.TextLocationX.Size = new System.Drawing.Size(60, 20);
            this.TextLocationX.TabIndex = 2;
            this.TextLocationX.TabStop = false;
            this.TextLocationX.Text = "0";
            this.TextLocationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 38);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(55, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 21);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Right";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(0, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 23);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Left";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Click Options";
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(126)))));
            this.BluePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BluePanel.Location = new System.Drawing.Point(0, 25);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(300, 4);
            this.BluePanel.TabIndex = 7;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopPanel.Controls.Add(this.ButtonRoleUp);
            this.TopPanel.Controls.Add(this.ButtonClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(300, 25);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // ButtonRoleUp
            // 
            this.ButtonRoleUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ButtonRoleUp.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Circle_yellow;
            this.ButtonRoleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRoleUp.FlatAppearance.BorderSize = 0;
            this.ButtonRoleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRoleUp.Location = new System.Drawing.Point(235, 0);
            this.ButtonRoleUp.Name = "ButtonRoleUp";
            this.ButtonRoleUp.Size = new System.Drawing.Size(25, 25);
            this.ButtonRoleUp.TabIndex = 28;
            this.ButtonRoleUp.TabStop = false;
            this.ButtonRoleUp.UseVisualStyleBackColor = false;
            this.ButtonRoleUp.Click += new System.EventHandler(this.ButtonRoleUp_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ButtonClose.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Circle;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(266, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.TabIndex = 27;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BluePanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoClicker";
            this.Text = "AutoClicker by Hirutsu";
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.TextBox TextLocationX;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox TextBoxSecs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxMins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button FindPosCursor;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonRoleUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextLocationY;
        private System.Windows.Forms.Label label6;
    }
}

