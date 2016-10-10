namespace WFA_DB
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.Label();
            this.Family = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.Label();
            this.POB = new System.Windows.Forms.ComboBox();
            this.POBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(225, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Tag = "";
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(345, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0000000000";
            this.textBox4.WordWrap = false;
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName.Location = new System.Drawing.Point(13, 40);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(28, 15);
            this.FName.TabIndex = 4;
            this.FName.Text = "Име";
            this.FName.Click += new System.EventHandler(this.label1_Click);
            // 
            // SName
            // 
            this.SName.AutoSize = true;
            this.SName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SName.Location = new System.Drawing.Point(119, 40);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(56, 15);
            this.SName.TabIndex = 5;
            this.SName.Text = "Презиме";
            // 
            // Family
            // 
            this.Family.AutoSize = true;
            this.Family.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Family.Location = new System.Drawing.Point(225, 39);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(56, 15);
            this.Family.TabIndex = 6;
            this.Family.Text = "Фамилия";
            // 
            // SSN
            // 
            this.SSN.AutoSize = true;
            this.SSN.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SSN.Location = new System.Drawing.Point(345, 40);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(28, 15);
            this.SSN.TabIndex = 7;
            this.SSN.Text = "ЕГН";
            // 
            // POB
            // 
            this.POB.FormattingEnabled = true;
            this.POB.Items.AddRange(new object[] {
            "Изберете...",
            "Бургас",
            "Варна",
            "София"});
            this.POB.Location = new System.Drawing.Point(427, 14);
            this.POB.Name = "POB";
            this.POB.Size = new System.Drawing.Size(121, 21);
            this.POB.TabIndex = 4;
            this.POB.Text = "Изберете...";
            // 
            // POBL
            // 
            this.POBL.AutoSize = true;
            this.POBL.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POBL.Location = new System.Drawing.Point(427, 40);
            this.POBL.Name = "POBL";
            this.POBL.Size = new System.Drawing.Size(98, 15);
            this.POBL.TabIndex = 9;
            this.POBL.Text = "Месторождение";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 338);
            this.Controls.Add(this.POBL);
            this.Controls.Add(this.POB);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Нов военнослужещ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label SName;
        private System.Windows.Forms.Label Family;
        private System.Windows.Forms.Label SSN;
        private System.Windows.Forms.ComboBox POB;
        private System.Windows.Forms.Label POBL;
    }
}