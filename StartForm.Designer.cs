namespace WarCardGame
{
    partial class StartForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbxCards = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnStart.Location = new System.Drawing.Point(7, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(218, 186);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start War";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbxCards
            // 
            this.lbxCards.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbxCards.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCards.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbxCards.FormattingEnabled = true;
            this.lbxCards.ItemHeight = 29;
            this.lbxCards.Location = new System.Drawing.Point(231, 12);
            this.lbxCards.Name = "lbxCards";
            this.lbxCards.Size = new System.Drawing.Size(304, 294);
            this.lbxCards.TabIndex = 1;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnShuffle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnShuffle.Location = new System.Drawing.Point(231, 312);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(304, 58);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(7, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 166);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Black Jack";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StartBlackJack);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(546, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lbxCards);
            this.Controls.Add(this.btnStart);
            this.Name = "StartForm";
            this.Text = "Card Games";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbxCards;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button button1;
    }
}

