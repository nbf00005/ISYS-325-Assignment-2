namespace Assignment2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblModel = new Label();
            lstModel = new ListBox();
            lblYear = new Label();
            txtYear = new TextBox();
            grpColor = new GroupBox();
            radWhite = new RadioButton();
            radBlack = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radRed = new RadioButton();
            grpFeatures = new GroupBox();
            chkLane = new CheckBox();
            chkSyrius = new CheckBox();
            chkAC = new CheckBox();
            chkWindows = new CheckBox();
            btnPurchase = new Button();
            lblSummary = new Label();
            grpColor.SuspendLayout();
            grpFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(15, 23);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(121, 20);
            lblModel.TabIndex = 0;
            lblModel.Text = "&Make and Model";
            // 
            // lstModel
            // 
            lstModel.FormattingEnabled = true;
            lstModel.Items.AddRange(new object[] { "Honda Accord", "Toyota Sienna", "Subaru Forester", "Chevrolet Trailblazer" });
            lstModel.Location = new Point(12, 46);
            lstModel.Name = "lstModel";
            lstModel.Size = new Size(145, 144);
            lstModel.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(193, 23);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(193, 46);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 3;
            // 
            // grpColor
            // 
            grpColor.Controls.Add(radWhite);
            grpColor.Controls.Add(radBlack);
            grpColor.Controls.Add(radGreen);
            grpColor.Controls.Add(radBlue);
            grpColor.Controls.Add(radRed);
            grpColor.Location = new Point(357, 23);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(153, 186);
            grpColor.TabIndex = 4;
            grpColor.TabStop = false;
            grpColor.Text = "&Color";
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Location = new Point(6, 143);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(69, 24);
            radWhite.TabIndex = 4;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            radWhite.CheckedChanged += radWhite_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(6, 113);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(65, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Location = new Point(6, 85);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(69, 24);
            radGreen.TabIndex = 2;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Location = new Point(6, 55);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(59, 24);
            radBlue.TabIndex = 1;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Location = new Point(6, 26);
            radRed.Name = "radRed";
            radRed.Size = new Size(56, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // grpFeatures
            // 
            grpFeatures.Controls.Add(chkLane);
            grpFeatures.Controls.Add(chkSyrius);
            grpFeatures.Controls.Add(chkAC);
            grpFeatures.Controls.Add(chkWindows);
            grpFeatures.Location = new Point(554, 24);
            grpFeatures.Name = "grpFeatures";
            grpFeatures.Size = new Size(159, 185);
            grpFeatures.TabIndex = 5;
            grpFeatures.TabStop = false;
            grpFeatures.Text = "&Features";
            // 
            // chkLane
            // 
            chkLane.AutoSize = true;
            chkLane.Location = new Point(5, 115);
            chkLane.Name = "chkLane";
            chkLane.Size = new Size(134, 24);
            chkLane.TabIndex = 3;
            chkLane.Text = "Lane Assistance";
            chkLane.UseVisualStyleBackColor = true;
            // 
            // chkSyrius
            // 
            chkSyrius.AutoSize = true;
            chkSyrius.Location = new Point(5, 85);
            chkSyrius.Name = "chkSyrius";
            chkSyrius.Size = new Size(112, 24);
            chkSyrius.TabIndex = 2;
            chkSyrius.Text = "Syrius Radio";
            chkSyrius.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(5, 55);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(50, 24);
            chkAC.TabIndex = 1;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // chkWindows
            // 
            chkWindows.AutoSize = true;
            chkWindows.Location = new Point(5, 27);
            chkWindows.Name = "chkWindows";
            chkWindows.Size = new Size(136, 24);
            chkWindows.TabIndex = 0;
            chkWindows.Text = "Power Windows";
            chkWindows.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(12, 340);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(94, 29);
            btnPurchase.TabIndex = 6;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // lblSummary
            // 
            lblSummary.BorderStyle = BorderStyle.FixedSingle;
            lblSummary.Location = new Point(193, 340);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(567, 82);
            lblSummary.TabIndex = 7;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSummary);
            Controls.Add(btnPurchase);
            Controls.Add(grpFeatures);
            Controls.Add(grpColor);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lstModel);
            Controls.Add(lblModel);
            Name = "MainForm";
            Text = "Assignment 2";
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            grpFeatures.ResumeLayout(false);
            grpFeatures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModel;
        private ListBox lstModel;
        private Label lblYear;
        private TextBox txtYear;
        private GroupBox grpColor;
        private RadioButton radRed;
        private RadioButton radWhite;
        private RadioButton radBlack;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private GroupBox grpFeatures;
        private CheckBox chkWindows;
        private CheckBox chkSyrius;
        private CheckBox chkAC;
        private CheckBox chkLane;
        private Button btnPurchase;
        private Label lblSummary;
    }
}
