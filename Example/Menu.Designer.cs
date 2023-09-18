namespace Example
{
    partial class Menu
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
            this.Ex1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ex1
            // 
            this.Ex1.Location = new System.Drawing.Point(46, 34);
            this.Ex1.Name = "Ex1";
            this.Ex1.Size = new System.Drawing.Size(75, 23);
            this.Ex1.TabIndex = 0;
            this.Ex1.Text = "1";
            this.Ex1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(643, 261);
            this.Controls.Add(this.Ex1);
            this.Name = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Ex1;
    }
}

