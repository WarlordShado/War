namespace WarCardGame
{
    partial class BlackJackForm
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
            this.lbxTable = new System.Windows.Forms.ListBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnLockIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxTable
            // 
            this.lbxTable.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbxTable.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTable.ForeColor = System.Drawing.Color.Aqua;
            this.lbxTable.FormattingEnabled = true;
            this.lbxTable.ItemHeight = 23;
            this.lbxTable.Location = new System.Drawing.Point(218, 12);
            this.lbxTable.Name = "lbxTable";
            this.lbxTable.Size = new System.Drawing.Size(442, 372);
            this.lbxTable.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Aqua;
            this.btnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDraw.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDraw.Location = new System.Drawing.Point(13, 13);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(199, 189);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw!";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnLockIn
            // 
            this.btnLockIn.BackColor = System.Drawing.Color.Aqua;
            this.btnLockIn.Enabled = false;
            this.btnLockIn.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLockIn.Location = new System.Drawing.Point(12, 212);
            this.btnLockIn.Name = "btnLockIn";
            this.btnLockIn.Size = new System.Drawing.Size(199, 172);
            this.btnLockIn.TabIndex = 2;
            this.btnLockIn.Text = "Lock In!";
            this.btnLockIn.UseVisualStyleBackColor = false;
            this.btnLockIn.Click += new System.EventHandler(this.btnLockIn_Click);
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(672, 395);
            this.Controls.Add(this.btnLockIn);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lbxTable);
            this.Name = "BlackJackForm";
            this.Text = "Black Jack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTable;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnLockIn;
    }
}