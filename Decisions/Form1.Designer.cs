
namespace Decisions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.driveButton = new System.Windows.Forms.Button();
            this.driveOutput = new System.Windows.Forms.Label();
            this.voteButton = new System.Windows.Forms.Button();
            this.voteOutput = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.workButton = new System.Windows.Forms.Button();
            this.workOutput = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.num1Label = new System.Windows.Forms.Label();
            this.num1Input = new System.Windows.Forms.TextBox();
            this.num2Input = new System.Windows.Forms.TextBox();
            this.num2Label = new System.Windows.Forms.Label();
            this.maxButton = new System.Windows.Forms.Button();
            this.maxOutput = new System.Windows.Forms.Label();
            this.yearButton = new System.Windows.Forms.Button();
            this.yearOutput = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // driveButton
            // 
            this.driveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveButton.Location = new System.Drawing.Point(314, 28);
            this.driveButton.Name = "driveButton";
            this.driveButton.Size = new System.Drawing.Size(88, 30);
            this.driveButton.TabIndex = 0;
            this.driveButton.Text = "DRIVE";
            this.driveButton.UseVisualStyleBackColor = true;
            this.driveButton.Click += new System.EventHandler(this.driveButton_Click);
            // 
            // driveOutput
            // 
            this.driveOutput.BackColor = System.Drawing.Color.White;
            this.driveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveOutput.Location = new System.Drawing.Point(417, 28);
            this.driveOutput.Name = "driveOutput";
            this.driveOutput.Size = new System.Drawing.Size(388, 30);
            this.driveOutput.TabIndex = 1;
            this.driveOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voteButton
            // 
            this.voteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteButton.Location = new System.Drawing.Point(314, 89);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(88, 29);
            this.voteButton.TabIndex = 2;
            this.voteButton.Text = "VOTE";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.ageButton_Click);
            // 
            // voteOutput
            // 
            this.voteOutput.BackColor = System.Drawing.Color.White;
            this.voteOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteOutput.Location = new System.Drawing.Point(417, 89);
            this.voteOutput.Name = "voteOutput";
            this.voteOutput.Size = new System.Drawing.Size(388, 29);
            this.voteOutput.TabIndex = 3;
            this.voteOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(84, 92);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(145, 24);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Enter Your Age:";
            // 
            // ageInput
            // 
            this.ageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageInput.Location = new System.Drawing.Point(235, 89);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(60, 29);
            this.ageInput.TabIndex = 5;
            // 
            // workButton
            // 
            this.workButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workButton.Location = new System.Drawing.Point(314, 153);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(88, 29);
            this.workButton.TabIndex = 6;
            this.workButton.Text = "WORK";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // workOutput
            // 
            this.workOutput.BackColor = System.Drawing.Color.White;
            this.workOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workOutput.Location = new System.Drawing.Point(417, 153);
            this.workOutput.Name = "workOutput";
            this.workOutput.Size = new System.Drawing.Size(388, 29);
            this.workOutput.TabIndex = 7;
            this.workOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(42, 153);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(187, 24);
            this.hoursLabel.TabIndex = 8;
            this.hoursLabel.Text = "Enter Hours Worked:";
            // 
            // hoursInput
            // 
            this.hoursInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursInput.Location = new System.Drawing.Point(235, 152);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(60, 29);
            this.hoursInput.TabIndex = 9;
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Label.Location = new System.Drawing.Point(15, 218);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(71, 24);
            this.num1Label.TabIndex = 10;
            this.num1Label.Text = "Num 1:";
            // 
            // num1Input
            // 
            this.num1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Input.Location = new System.Drawing.Point(92, 213);
            this.num1Input.Name = "num1Input";
            this.num1Input.Size = new System.Drawing.Size(60, 29);
            this.num1Input.TabIndex = 11;
            // 
            // num2Input
            // 
            this.num2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Input.Location = new System.Drawing.Point(235, 211);
            this.num2Input.Name = "num2Input";
            this.num2Input.Size = new System.Drawing.Size(60, 29);
            this.num2Input.TabIndex = 13;
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Label.Location = new System.Drawing.Point(158, 216);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(71, 24);
            this.num2Label.TabIndex = 12;
            this.num2Label.Text = "Num 1:";
            // 
            // maxButton
            // 
            this.maxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxButton.Location = new System.Drawing.Point(314, 212);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(88, 29);
            this.maxButton.TabIndex = 14;
            this.maxButton.Text = "MAX";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.Location = new System.Drawing.Point(417, 211);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(388, 29);
            this.maxOutput.TabIndex = 15;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearButton
            // 
            this.yearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearButton.Location = new System.Drawing.Point(314, 275);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(88, 29);
            this.yearButton.TabIndex = 16;
            this.yearButton.Text = "YEAR";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // yearOutput
            // 
            this.yearOutput.BackColor = System.Drawing.Color.White;
            this.yearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOutput.Location = new System.Drawing.Point(417, 275);
            this.yearOutput.Name = "yearOutput";
            this.yearOutput.Size = new System.Drawing.Size(388, 29);
            this.yearOutput.TabIndex = 17;
            this.yearOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearInput
            // 
            this.yearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearInput.Location = new System.Drawing.Point(235, 275);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(60, 29);
            this.yearInput.TabIndex = 18;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(110, 278);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(119, 24);
            this.yearLabel.TabIndex = 19;
            this.yearLabel.Text = "Enter a Year:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 336);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.yearOutput);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.num2Input);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Input);
            this.Controls.Add(this.num1Label);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.workOutput);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.voteOutput);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.driveOutput);
            this.Controls.Add(this.driveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decisions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button driveButton;
        private System.Windows.Forms.Label driveOutput;
        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.Label voteOutput;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Label workOutput;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.TextBox num1Input;
        private System.Windows.Forms.TextBox num2Input;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Label yearOutput;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.Label yearLabel;
    }
}

