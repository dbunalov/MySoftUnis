namespace _16.CatchMe
{
    partial class CatchTheButton
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
            this.buttonCatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCatchMe
            // 
            this.buttonCatchMe.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatchMe.Location = new System.Drawing.Point(64, 50);
            this.buttonCatchMe.Name = "buttonCatchMe";
            this.buttonCatchMe.Size = new System.Drawing.Size(75, 50);
            this.buttonCatchMe.TabIndex = 0;
            this.buttonCatchMe.Text = "Catch Me!";
            this.buttonCatchMe.UseVisualStyleBackColor = true;
            this.buttonCatchMe.Click += new System.EventHandler(this.buttonCatchMe_Click);
            this.buttonCatchMe.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // CatchTheButton
            // 
            this.ClientSize = new System.Drawing.Size(563, 304);
            this.Controls.Add(this.buttonCatchMe);
            this.Name = "CatchTheButton";
            this.Text = "CatchThe Button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCatchMe;
    }
}

