namespace BasicCalculator1
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(364, 35);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultLabel
            // 
            this.CalculationResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationResultLabel.Location = new System.Drawing.Point(12, 49);
            this.CalculationResultLabel.MaximumSize = new System.Drawing.Size(450, 39);
            this.CalculationResultLabel.Name = "CalculationResultLabel";
            this.CalculationResultLabel.Size = new System.Drawing.Size(364, 39);
            this.CalculationResultLabel.TabIndex = 1;
            this.CalculationResultLabel.Text = "Please enter an equation and press enter or =";
            this.CalculationResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonPanel.Controls.Add(this.PercentageButton, 3, 0);
            this.ButtonPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonPanel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonPanel.Controls.Add(this.AddButton, 3, 3);
            this.ButtonPanel.Controls.Add(this.DivideButton, 0, 4);
            this.ButtonPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonPanel.Controls.Add(this.PointButton, 2, 4);
            this.ButtonPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonPanel.Location = new System.Drawing.Point(18, 110);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 5;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.Size = new System.Drawing.Size(358, 356);
            this.ButtonPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(83, 65);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.Location = new System.Drawing.Point(92, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(83, 65);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.Location = new System.Drawing.Point(181, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(83, 65);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // PercentageButton
            // 
            this.PercentageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageButton.Location = new System.Drawing.Point(270, 3);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(85, 65);
            this.PercentageButton.TabIndex = 3;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = true;
            this.PercentageButton.Click += new System.EventHandler(this.PercentageButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(3, 74);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(83, 65);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(92, 74);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(83, 65);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(181, 74);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(83, 65);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(270, 74);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(85, 65);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(3, 145);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(83, 65);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(92, 145);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(83, 65);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(181, 145);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(83, 65);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(270, 145);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(85, 65);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(3, 216);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(83, 65);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(92, 216);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(83, 65);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(181, 216);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(83, 65);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(270, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 65);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(3, 287);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(83, 66);
            this.DivideButton.TabIndex = 16;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(92, 287);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(83, 66);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointButton.Location = new System.Drawing.Point(181, 287);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(83, 66);
            this.PointButton.TabIndex = 18;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(270, 287);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(85, 66);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(396, 481);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.CalculationResultLabel);
            this.Controls.Add(this.UserInputText);
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button EqualsButton;
    }
}

