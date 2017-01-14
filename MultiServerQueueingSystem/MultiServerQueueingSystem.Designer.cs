namespace MultiServerQueueingSystem
{
    partial class MultiServerQueueingSystem
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
            this.label_adiq = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_MST2 = new System.Windows.Forms.TextBox();
            this.label_MST2 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.textBox_NOC = new System.Windows.Forms.TextBox();
            this.label_NOC = new System.Windows.Forms.Label();
            this.textBox_MST1 = new System.Windows.Forms.TextBox();
            this.label_MST1 = new System.Windows.Forms.Label();
            this.textBox_MIT = new System.Windows.Forms.TextBox();
            this.label_MIT = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_SimulationSecondServer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_SimulationFirstServer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_adiq
            // 
            this.label_adiq.Location = new System.Drawing.Point(9, 220);
            this.label_adiq.Name = "label_adiq";
            this.label_adiq.Size = new System.Drawing.Size(429, 25);
            this.label_adiq.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_MST2);
            this.groupBox1.Controls.Add(this.label_MST2);
            this.groupBox1.Controls.Add(this.button_Clear);
            this.groupBox1.Controls.Add(this.button_Evaluate);
            this.groupBox1.Controls.Add(this.textBox_NOC);
            this.groupBox1.Controls.Add(this.label_NOC);
            this.groupBox1.Controls.Add(this.textBox_MST1);
            this.groupBox1.Controls.Add(this.label_MST1);
            this.groupBox1.Controls.Add(this.textBox_MIT);
            this.groupBox1.Controls.Add(this.label_MIT);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 270);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // textBox_MST2
            // 
            this.textBox_MST2.Location = new System.Drawing.Point(289, 134);
            this.textBox_MST2.Name = "textBox_MST2";
            this.textBox_MST2.Size = new System.Drawing.Size(259, 22);
            this.textBox_MST2.TabIndex = 3;
            // 
            // label_MST2
            // 
            this.label_MST2.Location = new System.Drawing.Point(91, 134);
            this.label_MST2.Name = "label_MST2";
            this.label_MST2.Size = new System.Drawing.Size(170, 25);
            this.label_MST2.TabIndex = 32;
            this.label_MST2.Text = "Mean Service Time (Server 2) :";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(462, 226);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(87, 27);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(368, 226);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(87, 27);
            this.button_Evaluate.TabIndex = 5;
            this.button_Evaluate.Text = "Evaluate";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // textBox_NOC
            // 
            this.textBox_NOC.Location = new System.Drawing.Point(289, 181);
            this.textBox_NOC.Name = "textBox_NOC";
            this.textBox_NOC.Size = new System.Drawing.Size(259, 22);
            this.textBox_NOC.TabIndex = 4;
            // 
            // label_NOC
            // 
            this.label_NOC.Location = new System.Drawing.Point(91, 181);
            this.label_NOC.Name = "label_NOC";
            this.label_NOC.Size = new System.Drawing.Size(170, 25);
            this.label_NOC.TabIndex = 28;
            this.label_NOC.Text = "Number Of Customers :";
            // 
            // textBox_MST1
            // 
            this.textBox_MST1.Location = new System.Drawing.Point(289, 91);
            this.textBox_MST1.Name = "textBox_MST1";
            this.textBox_MST1.Size = new System.Drawing.Size(259, 22);
            this.textBox_MST1.TabIndex = 2;
            // 
            // label_MST1
            // 
            this.label_MST1.Location = new System.Drawing.Point(91, 91);
            this.label_MST1.Name = "label_MST1";
            this.label_MST1.Size = new System.Drawing.Size(170, 25);
            this.label_MST1.TabIndex = 26;
            this.label_MST1.Text = "Mean Service Time (Server 1) :";
            // 
            // textBox_MIT
            // 
            this.textBox_MIT.Location = new System.Drawing.Point(289, 43);
            this.textBox_MIT.Name = "textBox_MIT";
            this.textBox_MIT.Size = new System.Drawing.Size(259, 22);
            this.textBox_MIT.TabIndex = 1;
            // 
            // label_MIT
            // 
            this.label_MIT.Location = new System.Drawing.Point(91, 43);
            this.label_MIT.Name = "label_MIT";
            this.label_MIT.Size = new System.Drawing.Size(170, 25);
            this.label_MIT.TabIndex = 24;
            this.label_MIT.Text = "Mean Interarrival Time :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(13, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 275);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_SimulationSecondServer);
            this.groupBox3.Location = new System.Drawing.Point(306, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 247);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report Second Server";
            // 
            // label_SimulationSecondServer
            // 
            this.label_SimulationSecondServer.AutoSize = true;
            this.label_SimulationSecondServer.Location = new System.Drawing.Point(7, 36);
            this.label_SimulationSecondServer.Name = "label_SimulationSecondServer";
            this.label_SimulationSecondServer.Size = new System.Drawing.Size(0, 15);
            this.label_SimulationSecondServer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_SimulationFirstServer);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 247);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report First Server";
            // 
            // label_SimulationFirstServer
            // 
            this.label_SimulationFirstServer.AutoSize = true;
            this.label_SimulationFirstServer.Location = new System.Drawing.Point(7, 36);
            this.label_SimulationFirstServer.Name = "label_SimulationFirstServer";
            this.label_SimulationFirstServer.Size = new System.Drawing.Size(0, 15);
            this.label_SimulationFirstServer.TabIndex = 1;
            // 
            // MultiServerQueueingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_adiq);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MultiServerQueueingSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Server Queueing System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_adiq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.TextBox textBox_NOC;
        private System.Windows.Forms.Label label_NOC;
        private System.Windows.Forms.TextBox textBox_MST1;
        private System.Windows.Forms.Label label_MST1;
        private System.Windows.Forms.TextBox textBox_MIT;
        private System.Windows.Forms.Label label_MIT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_SimulationSecondServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_SimulationFirstServer;
        private System.Windows.Forms.TextBox textBox_MST2;
        private System.Windows.Forms.Label label_MST2;
    }
}

