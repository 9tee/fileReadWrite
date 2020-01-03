namespace fileReadWrite
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
            this.RunBt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.output = new System.Windows.Forms.TextBox();
            this.FileBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.inputBt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RunBt
            // 
            this.RunBt.Location = new System.Drawing.Point(204, 228);
            this.RunBt.Name = "RunBt";
            this.RunBt.Size = new System.Drawing.Size(75, 23);
            this.RunBt.TabIndex = 0;
            this.RunBt.Text = "Run";
            this.RunBt.UseVisualStyleBackColor = true;
            this.RunBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(98, 44);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(181, 20);
            this.output.TabIndex = 1;
            // 
            // FileBt
            // 
            this.FileBt.Location = new System.Drawing.Point(285, 41);
            this.FileBt.Name = "FileBt";
            this.FileBt.Size = new System.Drawing.Size(75, 23);
            this.FileBt.TabIndex = 2;
            this.FileBt.Text = "File...";
            this.FileBt.UseVisualStyleBackColor = true;
            this.FileBt.Click += new System.EventHandler(this.FileBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(98, 104);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(181, 20);
            this.input.TabIndex = 1;
            // 
            // inputBt
            // 
            this.inputBt.Location = new System.Drawing.Point(285, 102);
            this.inputBt.Name = "inputBt";
            this.inputBt.Size = new System.Drawing.Size(75, 23);
            this.inputBt.TabIndex = 2;
            this.inputBt.Text = "File...";
            this.inputBt.UseVisualStyleBackColor = true;
            this.inputBt.Click += new System.EventHandler(this.InputBt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 309);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.inputBt);
            this.Controls.Add(this.FileBt);
            this.Controls.Add(this.output);
            this.Controls.Add(this.RunBt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunBt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button FileBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button inputBt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

