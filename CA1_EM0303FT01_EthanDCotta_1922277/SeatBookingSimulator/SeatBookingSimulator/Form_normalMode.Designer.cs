
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
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonPersonA = new System.Windows.Forms.Button();
            this.buttonPersonB = new System.Windows.Forms.Button();
            this.buttonPersonC = new System.Windows.Forms.Button();
            this.buttonPersonD = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelScreen = new System.Windows.Forms.Label();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.buttonShowLog = new System.Windows.Forms.Button();
            this.labelBookingSimulation = new System.Windows.Forms.Label();
            this.labelRichTextboxActions = new System.Windows.Forms.Label();
            this.panelSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(7, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(93, 12);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToFile.TabIndex = 2;
            this.buttonSaveToFile.Text = "Save";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonPersonA
            // 
            this.buttonPersonA.Location = new System.Drawing.Point(7, 150);
            this.buttonPersonA.Name = "buttonPersonA";
            this.buttonPersonA.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonA.TabIndex = 9;
            this.buttonPersonA.Text = "Person A Booking";
            this.buttonPersonA.UseVisualStyleBackColor = true;
            this.buttonPersonA.Click += new System.EventHandler(this.buttonPersonA_Click);
            // 
            // buttonPersonB
            // 
            this.buttonPersonB.Location = new System.Drawing.Point(7, 180);
            this.buttonPersonB.Name = "buttonPersonB";
            this.buttonPersonB.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonB.TabIndex = 10;
            this.buttonPersonB.Text = "Person B Booking";
            this.buttonPersonB.UseVisualStyleBackColor = true;
            this.buttonPersonB.Click += new System.EventHandler(this.buttonPersonB_Click);
            // 
            // buttonPersonC
            // 
            this.buttonPersonC.Location = new System.Drawing.Point(7, 210);
            this.buttonPersonC.Name = "buttonPersonC";
            this.buttonPersonC.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonC.TabIndex = 11;
            this.buttonPersonC.Text = "Person C Booking";
            this.buttonPersonC.UseVisualStyleBackColor = true;
            this.buttonPersonC.Click += new System.EventHandler(this.buttonPersonC_Click);
            // 
            // buttonPersonD
            // 
            this.buttonPersonD.Location = new System.Drawing.Point(7, 240);
            this.buttonPersonD.Name = "buttonPersonD";
            this.buttonPersonD.Size = new System.Drawing.Size(161, 23);
            this.buttonPersonD.TabIndex = 12;
            this.buttonPersonD.Text = "Person D Booking";
            this.buttonPersonD.UseVisualStyleBackColor = true;
            this.buttonPersonD.Click += new System.EventHandler(this.buttonPersonD_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(8, 315);
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
            this.panelSeats.Location = new System.Drawing.Point(174, 12);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(1216, 626);
            this.panelSeats.TabIndex = 16;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(7, 398);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(161, 240);
            this.richTextBoxMessage.TabIndex = 17;
            this.richTextBoxMessage.Text = "";
            // 
            // buttonShowLog
            // 
            this.buttonShowLog.Location = new System.Drawing.Point(8, 41);
            this.buttonShowLog.Name = "buttonShowLog";
            this.buttonShowLog.Size = new System.Drawing.Size(160, 23);
            this.buttonShowLog.TabIndex = 18;
            this.buttonShowLog.Text = "Show Booking Logs";
            this.buttonShowLog.UseVisualStyleBackColor = true;
            this.buttonShowLog.Click += new System.EventHandler(this.buttonShowLog_Click);
            // 
            // labelBookingSimulation
            // 
            this.labelBookingSimulation.AutoSize = true;
            this.labelBookingSimulation.Location = new System.Drawing.Point(8, 132);
            this.labelBookingSimulation.Name = "labelBookingSimulation";
            this.labelBookingSimulation.Size = new System.Drawing.Size(111, 15);
            this.labelBookingSimulation.TabIndex = 19;
            this.labelBookingSimulation.Text = "Booking Simulation";
            // 
            // labelRichTextboxActions
            // 
            this.labelRichTextboxActions.AutoSize = true;
            this.labelRichTextboxActions.Location = new System.Drawing.Point(8, 380);
            this.labelRichTextboxActions.Name = "labelRichTextboxActions";
            this.labelRichTextboxActions.Size = new System.Drawing.Size(91, 15);
            this.labelRichTextboxActions.TabIndex = 20;
            this.labelRichTextboxActions.Text = "Console Output";
            // 
            // Form_normalMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1398, 648);
            this.Controls.Add(this.labelRichTextboxActions);
            this.Controls.Add(this.labelBookingSimulation);
            this.Controls.Add(this.buttonShowLog);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPersonD);
            this.Controls.Add(this.buttonPersonC);
            this.Controls.Add(this.buttonPersonB);
            this.Controls.Add(this.buttonPersonA);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonLoad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_normalMode";
            this.Text = "Normal Mode";
            this.Load += new System.EventHandler(this.Form_normalMode_Load);
            this.panelSeats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonPersonA;
        private System.Windows.Forms.Button buttonPersonB;
        private System.Windows.Forms.Button buttonPersonC;
        private System.Windows.Forms.Button buttonPersonD;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Button buttonShowLog;
        private System.Windows.Forms.Label labelBookingSimulation;
        private System.Windows.Forms.Label labelRichTextboxActions;
    }
}