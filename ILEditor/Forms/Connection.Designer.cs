﻿namespace ILEditor.Forms
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highlight_line = new System.Windows.Forms.ComboBox();
            this.show_spaces = new System.Windows.Forms.ComboBox();
            this.indent_size = new System.Windows.Forms.NumericUpDown();
            this.cur_size = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.findACS = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.validACS = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.selectedFont = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indent_size)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(209, 375);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(131, 77);
            this.pass.MaxLength = 100;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(135, 20);
            this.pass.TabIndex = 10;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(131, 51);
            this.user.MaxLength = 10;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(135, 20);
            this.user.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Host name";
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(131, 25);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(135, 20);
            this.host.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.host);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 114);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectedFont);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.highlight_line);
            this.groupBox2.Controls.Add(this.show_spaces);
            this.groupBox2.Controls.Add(this.indent_size);
            this.groupBox2.Controls.Add(this.cur_size);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 159);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Highlight editing line";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Show spaces (by DOT)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Indent Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Zoom";
            // 
            // highlight_line
            // 
            this.highlight_line.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.highlight_line.FormattingEnabled = true;
            this.highlight_line.Items.AddRange(new object[] {
            "true",
            "false"});
            this.highlight_line.Location = new System.Drawing.Point(131, 125);
            this.highlight_line.Name = "highlight_line";
            this.highlight_line.Size = new System.Drawing.Size(135, 21);
            this.highlight_line.TabIndex = 3;
            // 
            // show_spaces
            // 
            this.show_spaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.show_spaces.FormattingEnabled = true;
            this.show_spaces.Items.AddRange(new object[] {
            "true",
            "false"});
            this.show_spaces.Location = new System.Drawing.Point(131, 98);
            this.show_spaces.Name = "show_spaces";
            this.show_spaces.Size = new System.Drawing.Size(135, 21);
            this.show_spaces.TabIndex = 2;
            // 
            // indent_size
            // 
            this.indent_size.Location = new System.Drawing.Point(131, 72);
            this.indent_size.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.indent_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.indent_size.Name = "indent_size";
            this.indent_size.Size = new System.Drawing.Size(135, 20);
            this.indent_size.TabIndex = 1;
            this.indent_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cur_size
            // 
            this.cur_size.Location = new System.Drawing.Point(131, 47);
            this.cur_size.MaxLength = 10;
            this.cur_size.Name = "cur_size";
            this.cur_size.ReadOnly = true;
            this.cur_size.Size = new System.Drawing.Size(135, 20);
            this.cur_size.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.findACS);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.validACS);
            this.groupBox3.Location = new System.Drawing.Point(12, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 49);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACS Configuration";
            // 
            // findACS
            // 
            this.findACS.Location = new System.Drawing.Point(193, 18);
            this.findACS.Name = "findACS";
            this.findACS.Size = new System.Drawing.Size(75, 23);
            this.findACS.TabIndex = 2;
            this.findACS.Text = "Find ACS";
            this.findACS.UseVisualStyleBackColor = true;
            this.findACS.Click += new System.EventHandler(this.findACS_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Executable";
            // 
            // validACS
            // 
            this.validACS.AutoSize = true;
            this.validACS.Enabled = false;
            this.validACS.Location = new System.Drawing.Point(138, 22);
            this.validACS.Name = "validACS";
            this.validACS.Size = new System.Drawing.Size(49, 17);
            this.validACS.TabIndex = 0;
            this.validACS.Text = "Valid";
            this.validACS.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Font";
            // 
            // selectedFont
            // 
            this.selectedFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedFont.FormattingEnabled = true;
            this.selectedFont.Items.AddRange(new object[] {
            "Consolas",
            "Courier New",
            "Lucida Console"});
            this.selectedFont.Location = new System.Drawing.Point(131, 21);
            this.selectedFont.Name = "selectedFont";
            this.selectedFont.Size = new System.Drawing.Size(135, 21);
            this.selectedFont.TabIndex = 9;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 410);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indent_size)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox show_spaces;
        private System.Windows.Forms.NumericUpDown indent_size;
        private System.Windows.Forms.TextBox cur_size;
        private System.Windows.Forms.ComboBox highlight_line;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox validACS;
        private System.Windows.Forms.Button findACS;
        private System.Windows.Forms.ComboBox selectedFont;
        private System.Windows.Forms.Label label9;
    }
}