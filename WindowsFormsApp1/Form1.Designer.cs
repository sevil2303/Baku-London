namespace WindowsFormsApp1
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
            this.bakubtn = new System.Windows.Forms.Button();
            this.londonbtn = new System.Windows.Forms.Button();
            this.bakuDateLbl = new System.Windows.Forms.Label();
            this.bakuTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bakubtn
            // 
            this.bakubtn.BackColor = System.Drawing.Color.Transparent;
            this.bakubtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bakubtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakubtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bakubtn.Location = new System.Drawing.Point(662, 545);
            this.bakubtn.Name = "bakubtn";
            this.bakubtn.Size = new System.Drawing.Size(115, 50);
            this.bakubtn.TabIndex = 0;
            this.bakubtn.Text = "Baku";
            this.bakubtn.UseVisualStyleBackColor = false;
            this.bakubtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakubtn_MouseClick_1);
            // 
            // londonbtn
            // 
            this.londonbtn.BackColor = System.Drawing.Color.Transparent;
            this.londonbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.londonbtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.londonbtn.Location = new System.Drawing.Point(806, 545);
            this.londonbtn.Name = "londonbtn";
            this.londonbtn.Size = new System.Drawing.Size(115, 50);
            this.londonbtn.TabIndex = 1;
            this.londonbtn.Text = "London";
            this.londonbtn.UseVisualStyleBackColor = false;
            this.londonbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonbtn_MouseClick);
            // 
            // bakuDateLbl
            // 
            this.bakuDateLbl.AutoSize = true;
            this.bakuDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.bakuDateLbl.Font = new System.Drawing.Font("Bodoni MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuDateLbl.ForeColor = System.Drawing.Color.LightBlue;
            this.bakuDateLbl.Location = new System.Drawing.Point(500, 10);
            this.bakuDateLbl.Name = "bakuDateLbl";
            this.bakuDateLbl.Size = new System.Drawing.Size(98, 48);
            this.bakuDateLbl.TabIndex = 4;
            this.bakuDateLbl.Text = "Date";
            // 
            // bakuTime
            // 
            this.bakuTime.AutoSize = true;
            this.bakuTime.BackColor = System.Drawing.Color.Transparent;
            this.bakuTime.Font = new System.Drawing.Font("Bodoni MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuTime.ForeColor = System.Drawing.Color.LightBlue;
            this.bakuTime.Location = new System.Drawing.Point(15, 10);
            this.bakuTime.Name = "bakuTime";
            this.bakuTime.Size = new System.Drawing.Size(110, 48);
            this.bakuTime.TabIndex = 3;
            this.bakuTime.Text = "Baku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.azerbaijan_tourism;
            this.ClientSize = new System.Drawing.Size(984, 626);
            this.Controls.Add(this.bakuDateLbl);
            this.Controls.Add(this.bakuTime);
            this.Controls.Add(this.londonbtn);
            this.Controls.Add(this.bakubtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bakubtn;
        private System.Windows.Forms.Button londonbtn;
        private System.Windows.Forms.Label bakuDateLbl;
        private System.Windows.Forms.Label bakuTime;
    }
}

