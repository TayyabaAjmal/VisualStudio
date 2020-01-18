namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeDataDataSet = new WindowsFormsApplication2.EmployeeDataDataSet();
            this.employeeDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtrem = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // employeeDataDataSet
            // 
            this.employeeDataDataSet.DataSetName = "EmployeeDataDataSet";
            this.employeeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataDataSetBindingSource
            // 
            this.employeeDataDataSetBindingSource.DataSource = this.employeeDataDataSet;
            this.employeeDataDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtrem);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 628);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 540);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(535, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "Send Alert to a Teacher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtrem
            // 
            this.txtrem.Location = new System.Drawing.Point(585, 202);
            this.txtrem.Name = "txtrem";
            this.txtrem.Size = new System.Drawing.Size(82, 31);
            this.txtrem.TabIndex = 9;
            this.txtrem.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(38, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(535, 44);
            this.button5.TabIndex = 8;
            this.button5.Text = "Show All With Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(535, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Find and Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(535, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(535, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Location = new System.Drawing.Point(695, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 426);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teacher";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 31);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(38, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(535, 44);
            this.button6.TabIndex = 8;
            this.button6.Text = "Show All With Details";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(38, 247);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(535, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "Alerts";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(38, 172);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(535, 44);
            this.button8.TabIndex = 6;
            this.button8.Text = "Find and Update";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(38, 104);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(535, 44);
            this.button9.TabIndex = 5;
            this.button9.Text = "Remove";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(38, 41);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(535, 44);
            this.button10.TabIndex = 4;
            this.button10.Text = "Add";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Location = new System.Drawing.Point(1397, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 616);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(579, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 31);
            this.textBox2.TabIndex = 12;
            this.textBox2.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(57, 540);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(535, 44);
            this.button11.TabIndex = 8;
            this.button11.Text = "Show All With Details";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(38, 365);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(535, 44);
            this.button12.TabIndex = 7;
            this.button12.Text = "Find and Update";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(38, 202);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(535, 44);
            this.button14.TabIndex = 5;
            this.button14.Text = "Remove";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(38, 50);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(535, 44);
            this.button15.TabIndex = 4;
            this.button15.Text = "Add";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(719, 153);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(535, 44);
            this.button13.TabIndex = 11;
            this.button13.Text = "Transport, Activities, Accounts and Online Payment";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(719, 214);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(535, 44);
            this.button16.TabIndex = 12;
            this.button16.Text = "Study, Medical and Security";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2130, 769);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeDataDataSetBindingSource;
        private EmployeeDataDataSet employeeDataDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtrem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;

    }
}

