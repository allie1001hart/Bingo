namespace Bingo
{
    partial class FrmMainForm
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
            this.pnlBingoCard = new System.Windows.Forms.Panel();
            this.lblYourBingoCard = new System.Windows.Forms.Label();
            this.lblRuleOne = new System.Windows.Forms.Label();
            this.lblRuleTwo = new System.Windows.Forms.Label();
            this.txtYourNumber = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.lblAreYouReady = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRuleThree = new System.Windows.Forms.Label();
            this.lblRuleTitle = new System.Windows.Forms.Label();
            this.lblYourNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBingoCard
            // 
            this.pnlBingoCard.Location = new System.Drawing.Point(15, 451);
            this.pnlBingoCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBingoCard.Name = "pnlBingoCard";
            this.pnlBingoCard.Size = new System.Drawing.Size(850, 850);
            this.pnlBingoCard.TabIndex = 0;
            // 
            // lblYourBingoCard
            // 
            this.lblYourBingoCard.AutoSize = true;
            this.lblYourBingoCard.Location = new System.Drawing.Point(362, 409);
            this.lblYourBingoCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourBingoCard.Name = "lblYourBingoCard";
            this.lblYourBingoCard.Size = new System.Drawing.Size(126, 20);
            this.lblYourBingoCard.TabIndex = 1;
            this.lblYourBingoCard.Text = "Your Bingo Card";
            // 
            // lblRuleOne
            // 
            this.lblRuleOne.AutoSize = true;
            this.lblRuleOne.Location = new System.Drawing.Point(111, 243);
            this.lblRuleOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuleOne.Name = "lblRuleOne";
            this.lblRuleOne.Size = new System.Drawing.Size(634, 20);
            this.lblRuleOne.TabIndex = 2;
            this.lblRuleOne.Text = "We call one number at a time. Check your card for that number and if found click " +
    "that cell.";
            // 
            // lblRuleTwo
            // 
            this.lblRuleTwo.AutoSize = true;
            this.lblRuleTwo.Location = new System.Drawing.Point(111, 263);
            this.lblRuleTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuleTwo.Name = "lblRuleTwo";
            this.lblRuleTwo.Size = new System.Drawing.Size(634, 20);
            this.lblRuleTwo.TabIndex = 3;
            this.lblRuleTwo.Text = "We will do the rest, checking for a Bingo or not. The number called will appear t" +
    "o the right.";
            // 
            // txtYourNumber
            // 
            this.txtYourNumber.Location = new System.Drawing.Point(286, 343);
            this.txtYourNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYourNumber.Name = "txtYourNumber";
            this.txtYourNumber.ReadOnly = true;
            this.txtYourNumber.Size = new System.Drawing.Size(148, 26);
            this.txtYourNumber.TabIndex = 4;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Location = new System.Drawing.Point(525, 343);
            this.btnDontHave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(112, 35);
            this.btnDontHave.TabIndex = 5;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // lblAreYouReady
            // 
            this.lblAreYouReady.AutoSize = true;
            this.lblAreYouReady.Location = new System.Drawing.Point(150, 149);
            this.lblAreYouReady.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreYouReady.Name = "lblAreYouReady";
            this.lblAreYouReady.Size = new System.Drawing.Size(177, 20);
            this.lblAreYouReady.TabIndex = 6;
            this.lblAreYouReady.Text = "Are You Ready to Play?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(375, 142);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(142, 35);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "Yes! Let\'s Go!";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(564, 142);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(112, 35);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "No! Exit!";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(282, 80);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(136, 20);
            this.lblEnterName.TabIndex = 9;
            this.lblEnterName.Text = "Enter Your Name:";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(436, 75);
            this.txtEnterName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(148, 26);
            this.txtEnterName.TabIndex = 10;
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWelcome.Location = new System.Drawing.Point(322, 14);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(224, 29);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome to BINGO";
            // 
            // lblRuleThree
            // 
            this.lblRuleThree.AutoSize = true;
            this.lblRuleThree.Location = new System.Drawing.Point(111, 283);
            this.lblRuleThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuleThree.Name = "lblRuleThree";
            this.lblRuleThree.Size = new System.Drawing.Size(640, 20);
            this.lblRuleThree.TabIndex = 12;
            this.lblRuleThree.Text = "If you do not have the number called in your card click the \"Don\'t Have\" button t" +
    "o the right.";
            // 
            // lblRuleTitle
            // 
            this.lblRuleTitle.AutoSize = true;
            this.lblRuleTitle.Location = new System.Drawing.Point(402, 208);
            this.lblRuleTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuleTitle.Name = "lblRuleTitle";
            this.lblRuleTitle.Size = new System.Drawing.Size(54, 20);
            this.lblRuleTitle.TabIndex = 13;
            this.lblRuleTitle.Text = "Rules:";
            // 
            // lblYourNumber
            // 
            this.lblYourNumber.AutoSize = true;
            this.lblYourNumber.Location = new System.Drawing.Point(170, 348);
            this.lblYourNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourNumber.Name = "lblYourNumber";
            this.lblYourNumber.Size = new System.Drawing.Size(107, 20);
            this.lblYourNumber.TabIndex = 14;
            this.lblYourNumber.Text = "Your Number:";
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 1323);
            this.Controls.Add(this.lblYourNumber);
            this.Controls.Add(this.lblRuleTitle);
            this.Controls.Add(this.lblRuleThree);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblAreYouReady);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtYourNumber);
            this.Controls.Add(this.lblRuleTwo);
            this.Controls.Add(this.lblRuleOne);
            this.Controls.Add(this.lblYourBingoCard);
            this.Controls.Add(this.pnlBingoCard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBingoCard;
        private System.Windows.Forms.Label lblYourBingoCard;
        private System.Windows.Forms.Label lblRuleOne;
        private System.Windows.Forms.Label lblRuleTwo;
        private System.Windows.Forms.TextBox txtYourNumber;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Label lblAreYouReady;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRuleThree;
        private System.Windows.Forms.Label lblRuleTitle;
        private System.Windows.Forms.Label lblYourNumber;
    }
}

