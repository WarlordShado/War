namespace WarCardGame
{
    partial class WarForm
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.lbxTable = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblComputerCardAmt = new System.Windows.Forms.Label();
            this.lblPlayerCardAmt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Chartreuse;
            this.btnDraw.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDraw.Location = new System.Drawing.Point(12, 19);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(159, 321);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw!";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lbxTable
            // 
            this.lbxTable.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbxTable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTable.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbxTable.FormattingEnabled = true;
            this.lbxTable.ItemHeight = 18;
            this.lbxTable.Location = new System.Drawing.Point(177, 19);
            this.lbxTable.Name = "lbxTable";
            this.lbxTable.Size = new System.Drawing.Size(596, 256);
            this.lbxTable.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComputerCardAmt);
            this.groupBox1.Controls.Add(this.lblPlayerCardAmt);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Location = new System.Drawing.Point(178, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cards";
            // 
            // lblComputerCardAmt
            // 
            this.lblComputerCardAmt.AutoSize = true;
            this.lblComputerCardAmt.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblComputerCardAmt.Location = new System.Drawing.Point(314, 26);
            this.lblComputerCardAmt.Name = "lblComputerCardAmt";
            this.lblComputerCardAmt.Size = new System.Drawing.Size(56, 23);
            this.lblComputerCardAmt.TabIndex = 3;
            this.lblComputerCardAmt.Text = "label2";
            this.lblComputerCardAmt.Visible = false;
            // 
            // lblPlayerCardAmt
            // 
            this.lblPlayerCardAmt.AutoSize = true;
            this.lblPlayerCardAmt.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblPlayerCardAmt.Location = new System.Drawing.Point(20, 26);
            this.lblPlayerCardAmt.Name = "lblPlayerCardAmt";
            this.lblPlayerCardAmt.Size = new System.Drawing.Size(53, 23);
            this.lblPlayerCardAmt.TabIndex = 0;
            this.lblPlayerCardAmt.Text = "label1";
            this.lblPlayerCardAmt.Visible = false;
            // 
            // WarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxTable);
            this.Controls.Add(this.btnDraw);
            this.Name = "WarForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.formLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ListBox lbxTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComputerCardAmt;
        private System.Windows.Forms.Label lblPlayerCardAmt;
    }
}