
namespace SeatBookingSimulator
{
    partial class Form_normalMode
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPersonA = new System.Windows.Forms.Button();
            this.buttonPersonB = new System.Windows.Forms.Button();
            this.buttonPersonC = new System.Windows.Forms.Button();
            this.buttonPersonD = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelScreen = new System.Windows.Forms.Label();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.panelSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(98, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPersonA
            // 
            this.buttonPersonA.Location = new System.Drawing.Point(11, 223);
            this.buttonPersonA.Name = "buttonPersonA";
            this.buttonPersonA.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonA.TabIndex = 9;
            this.buttonPersonA.Text = "Person A Booking";
            this.buttonPersonA.UseVisualStyleBackColor = true;
            this.buttonPersonA.Click += new System.EventHandler(this.buttonPersonA_Click);
            // 
            // buttonPersonB
            // 
            this.buttonPersonB.Location = new System.Drawing.Point(11, 253);
            this.buttonPersonB.Name = "buttonPersonB";
            this.buttonPersonB.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonB.TabIndex = 10;
            this.buttonPersonB.Text = "Person B Booking";
            this.buttonPersonB.UseVisualStyleBackColor = true;
            this.buttonPersonB.Click += new System.EventHandler(this.buttonPersonB_Click);
            // 
            // buttonPersonC
            // 
            this.buttonPersonC.Location = new System.Drawing.Point(11, 283);
            this.buttonPersonC.Name = "buttonPersonC";
            this.buttonPersonC.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonC.TabIndex = 11;
            this.buttonPersonC.Text = "Person C Booking";
            this.buttonPersonC.UseVisualStyleBackColor = true;
            this.buttonPersonC.Click += new System.EventHandler(this.buttonPersonC_Click);
            // 
            // buttonPersonD
            // 
            this.buttonPersonD.Location = new System.Drawing.Point(11, 313);
            this.buttonPersonD.Name = "buttonPersonD";
            this.buttonPersonD.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonD.TabIndex = 12;
            this.buttonPersonD.Text = "Person D Booking";
            this.buttonPersonD.UseVisualStyleBackColor = true;
            this.buttonPersonD.Click += new System.EventHandler(this.buttonPersonD_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(11, 369);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(161, 23);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset Simulation";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelScreen
            // 
            this.labelScreen.BackColor = System.Drawing.Color.SandyBrown;
            this.labelScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScreen.Location = new System.Drawing.Point(419, 0);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(400, 35);
            this.labelScreen.TabIndex = 0;
            this.labelScreen.Text = "Screen";
            this.labelScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSeats
            // 
            this.panelSeats.BackColor = System.Drawing.SystemColors.Control;
            this.panelSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeats.Controls.Add(this.labelScreen);
            this.panelSeats.Location = new System.Drawing.Point(179, 12);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(1211, 626);
            this.panelSeats.TabIndex = 16;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(2, 398);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(171, 240);
            this.richTextBoxMessage.TabIndex = 17;
            this.richTextBoxMessage.Text = "";
            // 
            // Form_normalMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1402, 650);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPersonD);
            this.Controls.Add(this.buttonPersonC);
            this.Controls.Add(this.buttonPersonB);
            this.Controls.Add(this.buttonPersonA);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_normalMode";
            this.Text = "Normal Mode";
            this.Load += new System.EventHandler(this.Form_normalMode_Load);
            this.panelSeats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPersonA;
        private System.Windows.Forms.Button buttonPersonB;
        private System.Windows.Forms.Button buttonPersonC;
        private System.Windows.Forms.Button buttonPersonD;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
    }
}