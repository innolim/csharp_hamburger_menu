
namespace ch4_hambugerOrderPad
{
    partial class Form1
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
            this.cheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.friedeggCheckBox = new System.Windows.Forms.CheckBox();
            this.baconCheckBox = new System.Windows.Forms.CheckBox();
            this.avocadoCheckBox = new System.Windows.Forms.CheckBox();
            this.rareRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.welldoneRadioButton = new System.Windows.Forms.RadioButton();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.friesGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.creditRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.menuGroupBox.SuspendLayout();
            this.friesGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheeseCheckBox
            // 
            this.cheeseCheckBox.AutoSize = true;
            this.cheeseCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cheeseCheckBox.Location = new System.Drawing.Point(22, 39);
            this.cheeseCheckBox.Name = "cheeseCheckBox";
            this.cheeseCheckBox.Size = new System.Drawing.Size(68, 21);
            this.cheeseCheckBox.TabIndex = 0;
            this.cheeseCheckBox.Text = "cheese";
            this.cheeseCheckBox.UseVisualStyleBackColor = true;
            this.cheeseCheckBox.CheckedChanged += new System.EventHandler(this.cheeseCheckBox_CheckedChanged);
            // 
            // friedeggCheckBox
            // 
            this.friedeggCheckBox.AutoSize = true;
            this.friedeggCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.friedeggCheckBox.Location = new System.Drawing.Point(22, 64);
            this.friedeggCheckBox.Name = "friedeggCheckBox";
            this.friedeggCheckBox.Size = new System.Drawing.Size(83, 21);
            this.friedeggCheckBox.TabIndex = 1;
            this.friedeggCheckBox.Text = "fried egg";
            this.friedeggCheckBox.UseVisualStyleBackColor = true;
            this.friedeggCheckBox.CheckedChanged += new System.EventHandler(this.friedeggCheckBox_CheckedChanged);
            // 
            // baconCheckBox
            // 
            this.baconCheckBox.AutoSize = true;
            this.baconCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.baconCheckBox.Location = new System.Drawing.Point(22, 89);
            this.baconCheckBox.Name = "baconCheckBox";
            this.baconCheckBox.Size = new System.Drawing.Size(64, 21);
            this.baconCheckBox.TabIndex = 2;
            this.baconCheckBox.Text = "bacon";
            this.baconCheckBox.UseVisualStyleBackColor = true;
            this.baconCheckBox.CheckedChanged += new System.EventHandler(this.baconCheckBox_CheckedChanged);
            // 
            // avocadoCheckBox
            // 
            this.avocadoCheckBox.AutoSize = true;
            this.avocadoCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.avocadoCheckBox.Location = new System.Drawing.Point(22, 114);
            this.avocadoCheckBox.Name = "avocadoCheckBox";
            this.avocadoCheckBox.Size = new System.Drawing.Size(78, 21);
            this.avocadoCheckBox.TabIndex = 3;
            this.avocadoCheckBox.Text = "avocado";
            this.avocadoCheckBox.UseVisualStyleBackColor = true;
            this.avocadoCheckBox.CheckedChanged += new System.EventHandler(this.avocadoCheckBox_CheckedChanged);
            // 
            // rareRadioButton
            // 
            this.rareRadioButton.AutoSize = true;
            this.rareRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rareRadioButton.Location = new System.Drawing.Point(22, 151);
            this.rareRadioButton.Name = "rareRadioButton";
            this.rareRadioButton.Size = new System.Drawing.Size(50, 21);
            this.rareRadioButton.TabIndex = 4;
            this.rareRadioButton.Text = "rare";
            this.rareRadioButton.UseVisualStyleBackColor = true;
            this.rareRadioButton.CheckedChanged += new System.EventHandler(this.rareRadioButton_CheckedChanged);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mediumRadioButton.Location = new System.Drawing.Point(105, 151);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(77, 21);
            this.mediumRadioButton.TabIndex = 5;
            this.mediumRadioButton.Text = "medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // welldoneRadioButton
            // 
            this.welldoneRadioButton.AutoSize = true;
            this.welldoneRadioButton.Checked = true;
            this.welldoneRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welldoneRadioButton.Location = new System.Drawing.Point(211, 151);
            this.welldoneRadioButton.Name = "welldoneRadioButton";
            this.welldoneRadioButton.Size = new System.Drawing.Size(86, 21);
            this.welldoneRadioButton.TabIndex = 6;
            this.welldoneRadioButton.TabStop = true;
            this.welldoneRadioButton.Text = "well done";
            this.welldoneRadioButton.UseVisualStyleBackColor = true;
            this.welldoneRadioButton.CheckedChanged += new System.EventHandler(this.welldoneRadioButton_CheckedChanged);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuGroupBox.Controls.Add(this.addLabel);
            this.menuGroupBox.Controls.Add(this.cheeseCheckBox);
            this.menuGroupBox.Controls.Add(this.welldoneRadioButton);
            this.menuGroupBox.Controls.Add(this.friedeggCheckBox);
            this.menuGroupBox.Controls.Add(this.mediumRadioButton);
            this.menuGroupBox.Controls.Add(this.baconCheckBox);
            this.menuGroupBox.Controls.Add(this.rareRadioButton);
            this.menuGroupBox.Controls.Add(this.avocadoCheckBox);
            this.menuGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.menuGroupBox.Location = new System.Drawing.Point(234, 12);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(332, 186);
            this.menuGroupBox.TabIndex = 7;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Burger House";
            // 
            // addLabel
            // 
            this.addLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addLabel.Location = new System.Drawing.Point(187, 64);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(100, 32);
            this.addLabel.TabIndex = 7;
            // 
            // friesGroupBox
            // 
            this.friesGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.friesGroupBox.Controls.Add(this.noRadioButton);
            this.friesGroupBox.Controls.Add(this.yesRadioButton);
            this.friesGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.friesGroupBox.Location = new System.Drawing.Point(234, 218);
            this.friesGroupBox.Name = "friesGroupBox";
            this.friesGroupBox.Size = new System.Drawing.Size(332, 53);
            this.friesGroupBox.TabIndex = 7;
            this.friesGroupBox.TabStop = false;
            this.friesGroupBox.Text = "fries?";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noRadioButton.Location = new System.Drawing.Point(211, 22);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(42, 21);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.Text = "no";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Checked = true;
            this.yesRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yesRadioButton.Location = new System.Drawing.Point(105, 22);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(46, 21);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.yesRadioButton_CheckedChanged);
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalButton.Location = new System.Drawing.Point(234, 358);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 59);
            this.totalButton.TabIndex = 2;
            this.totalButton.Text = "total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(491, 358);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 59);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentGroupBox.Controls.Add(this.creditRadioButton);
            this.paymentGroupBox.Controls.Add(this.cashRadioButton);
            this.paymentGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.paymentGroupBox.Location = new System.Drawing.Point(234, 297);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(332, 36);
            this.paymentGroupBox.TabIndex = 10;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "payment?";
            // 
            // creditRadioButton
            // 
            this.creditRadioButton.AutoSize = true;
            this.creditRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creditRadioButton.Location = new System.Drawing.Point(211, 11);
            this.creditRadioButton.Name = "creditRadioButton";
            this.creditRadioButton.Size = new System.Drawing.Size(61, 21);
            this.creditRadioButton.TabIndex = 1;
            this.creditRadioButton.Text = "credit";
            this.creditRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cashRadioButton.Location = new System.Drawing.Point(105, 11);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(53, 21);
            this.cashRadioButton.TabIndex = 0;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(373, 358);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(73, 59);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ch4_hambugerOrderPad.Properties.Resources.istockphoto_1216455409_612x612;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.friesGroupBox);
            this.Controls.Add(this.menuGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuGroupBox.ResumeLayout(false);
            this.menuGroupBox.PerformLayout();
            this.friesGroupBox.ResumeLayout(false);
            this.friesGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cheeseCheckBox;
        private System.Windows.Forms.CheckBox friedeggCheckBox;
        private System.Windows.Forms.CheckBox baconCheckBox;
        private System.Windows.Forms.CheckBox avocadoCheckBox;
        private System.Windows.Forms.RadioButton rareRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton welldoneRadioButton;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.GroupBox friesGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.RadioButton creditRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label addLabel;
    }
}

