namespace Rock_Paper_Scissors.Forms
{
    partial class FrmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picScissor = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.move = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.betSucceed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBetDraw = new System.Windows.Forms.RadioButton();
            this.lblSumBet = new System.Windows.Forms.Label();
            this.lblLostBet = new System.Windows.Forms.Label();
            this.lblWinBet = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rdoBetB = new System.Windows.Forms.RadioButton();
            this.rdoBetA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.finalrps_classypage;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.picScissor);
            this.splitContainer1.Panel1.Controls.Add(this.picPaper);
            this.splitContainer1.Panel1.Controls.Add(this.picRock);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.finalrps_classypage;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(913, 633);
            this.splitContainer1.SplitterDistance = 609;
            this.splitContainer1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Confirm16;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(116, 587);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 35);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // picScissor
            // 
            this.picScissor.BackColor = System.Drawing.Color.Transparent;
            this.picScissor.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Confirm16;
            this.picScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picScissor.Location = new System.Drawing.Point(439, 14);
            this.picScissor.Name = "picScissor";
            this.picScissor.Size = new System.Drawing.Size(64, 35);
            this.picScissor.TabIndex = 12;
            this.picScissor.TabStop = false;
            // 
            // picPaper
            // 
            this.picPaper.BackColor = System.Drawing.Color.Transparent;
            this.picPaper.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Confirm16;
            this.picPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPaper.Location = new System.Drawing.Point(279, 14);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(64, 35);
            this.picPaper.TabIndex = 11;
            this.picPaper.TabStop = false;
            // 
            // picRock
            // 
            this.picRock.BackColor = System.Drawing.Color.Transparent;
            this.picRock.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Confirm16;
            this.picRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRock.Location = new System.Drawing.Point(110, 14);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(64, 35);
            this.picRock.TabIndex = 10;
            this.picRock.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(12, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rock (A)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.ForestGreen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player (B)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstHistory);
            this.groupBox2.Location = new System.Drawing.Point(0, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 477);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // lstHistory
            // 
            this.lstHistory.AllowColumnReorder = true;
            this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.move,
            this.result,
            this.bet,
            this.betSucceed});
            this.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHistory.GridLines = true;
            this.lstHistory.HideSelection = false;
            this.lstHistory.LabelEdit = true;
            this.lstHistory.Location = new System.Drawing.Point(3, 16);
            this.lstHistory.MultiSelect = false;
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(294, 458);
            this.lstHistory.TabIndex = 10;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "No.";
            this.index.Width = 41;
            // 
            // move
            // 
            this.move.Text = "Move";
            // 
            // result
            // 
            this.result.Text = "Result";
            this.result.Width = 45;
            // 
            // bet
            // 
            this.bet.Text = "Bet";
            this.bet.Width = 45;
            // 
            // betSucceed
            // 
            this.betSucceed.Text = "Is bet succeed";
            this.betSucceed.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBetDraw);
            this.groupBox1.Controls.Add(this.lblSumBet);
            this.groupBox1.Controls.Add(this.lblLostBet);
            this.groupBox1.Controls.Add(this.lblWinBet);
            this.groupBox1.Controls.Add(this.btnFinish);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.rdoBetB);
            this.groupBox1.Controls.Add(this.rdoBetA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bet";
            // 
            // rdoBetDraw
            // 
            this.rdoBetDraw.AutoSize = true;
            this.rdoBetDraw.Location = new System.Drawing.Point(78, 23);
            this.rdoBetDraw.Name = "rdoBetDraw";
            this.rdoBetDraw.Size = new System.Drawing.Size(50, 17);
            this.rdoBetDraw.TabIndex = 20;
            this.rdoBetDraw.Text = "Draw";
            this.rdoBetDraw.UseVisualStyleBackColor = true;
            // 
            // lblSumBet
            // 
            this.lblSumBet.AutoSize = true;
            this.lblSumBet.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSumBet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSumBet.Location = new System.Drawing.Point(44, 125);
            this.lblSumBet.Name = "lblSumBet";
            this.lblSumBet.Size = new System.Drawing.Size(13, 13);
            this.lblSumBet.TabIndex = 19;
            this.lblSumBet.Text = "0";
            // 
            // lblLostBet
            // 
            this.lblLostBet.AutoSize = true;
            this.lblLostBet.ForeColor = System.Drawing.Color.Red;
            this.lblLostBet.Location = new System.Drawing.Point(43, 103);
            this.lblLostBet.Name = "lblLostBet";
            this.lblLostBet.Size = new System.Drawing.Size(13, 13);
            this.lblLostBet.TabIndex = 18;
            this.lblLostBet.Text = "0";
            // 
            // lblWinBet
            // 
            this.lblWinBet.AutoSize = true;
            this.lblWinBet.BackColor = System.Drawing.Color.White;
            this.lblWinBet.ForeColor = System.Drawing.Color.Green;
            this.lblWinBet.Location = new System.Drawing.Point(43, 81);
            this.lblWinBet.Name = "lblWinBet";
            this.lblWinBet.Size = new System.Drawing.Size(13, 13);
            this.lblWinBet.TabIndex = 17;
            this.lblWinBet.Text = "0";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(9, 48);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(119, 24);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "Finish Game";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "sum :";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(182, 22);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(56, 20);
            this.txtBet.TabIndex = 13;
            this.txtBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBet_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "your bet :";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(135, 48);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(102, 24);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rdoBetB
            // 
            this.rdoBetB.AutoSize = true;
            this.rdoBetB.Location = new System.Drawing.Point(40, 23);
            this.rdoBetB.Name = "rdoBetB";
            this.rdoBetB.Size = new System.Drawing.Size(32, 17);
            this.rdoBetB.TabIndex = 4;
            this.rdoBetB.Text = "B";
            this.rdoBetB.UseVisualStyleBackColor = true;
            // 
            // rdoBetA
            // 
            this.rdoBetA.AutoSize = true;
            this.rdoBetA.Checked = true;
            this.rdoBetA.Location = new System.Drawing.Point(6, 23);
            this.rdoBetA.Name = "rdoBetA";
            this.rdoBetA.Size = new System.Drawing.Size(32, 17);
            this.rdoBetA.TabIndex = 3;
            this.rdoBetA.TabStop = true;
            this.rdoBetA.Text = "A";
            this.rdoBetA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "lose :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "win :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 633);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picScissor;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rdoBetB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView lstHistory;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader move;
        private System.Windows.Forms.ColumnHeader result;
        private System.Windows.Forms.ColumnHeader bet;
        private System.Windows.Forms.Label lblLostBet;
        private System.Windows.Forms.Label lblWinBet;
        private System.Windows.Forms.Label lblSumBet;
        private System.Windows.Forms.RadioButton rdoBetDraw;
        private System.Windows.Forms.RadioButton rdoBetA;
        private System.Windows.Forms.ColumnHeader betSucceed;
    }
}

