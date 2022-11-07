namespace CmdInOut
{
    partial class frmCmdInOut
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtbStdOut = new System.Windows.Forms.RichTextBox();
            this.rtbStdErr = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbStdIn = new System.Windows.Forms.RichTextBox();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbStdOut
            // 
            this.rtbStdOut.BackColor = System.Drawing.Color.MidnightBlue;
            this.rtbStdOut.ForeColor = System.Drawing.Color.White;
            this.rtbStdOut.Location = new System.Drawing.Point(12, 29);
            this.rtbStdOut.Name = "rtbStdOut";
            this.rtbStdOut.Size = new System.Drawing.Size(434, 202);
            this.rtbStdOut.TabIndex = 0;
            this.rtbStdOut.TabStop = false;
            this.rtbStdOut.Text = "";
            // 
            // rtbStdErr
            // 
            this.rtbStdErr.BackColor = System.Drawing.Color.White;
            this.rtbStdErr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStdErr.ForeColor = System.Drawing.Color.Black;
            this.rtbStdErr.Location = new System.Drawing.Point(12, 267);
            this.rtbStdErr.Name = "rtbStdErr";
            this.rtbStdErr.Size = new System.Drawing.Size(434, 95);
            this.rtbStdErr.TabIndex = 1;
            this.rtbStdErr.TabStop = false;
            this.rtbStdErr.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process Standard Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process Standard Error";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter command (Process Standard Input)";
            // 
            // rtbStdIn
            // 
            this.rtbStdIn.BackColor = System.Drawing.Color.White;
            this.rtbStdIn.DetectUrls = false;
            this.rtbStdIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStdIn.ForeColor = System.Drawing.Color.Black;
            this.rtbStdIn.Location = new System.Drawing.Point(12, 397);
            this.rtbStdIn.Name = "rtbStdIn";
            this.rtbStdIn.Size = new System.Drawing.Size(434, 28);
            this.rtbStdIn.TabIndex = 0;
            this.rtbStdIn.Text = "";
            this.rtbStdIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbStdIn_KeyPress);
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStartProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartProcess.Location = new System.Drawing.Point(357, 455);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(89, 29);
            this.btnStartProcess.TabIndex = 2;
            this.btnStartProcess.Text = "Start Process";
            this.btnStartProcess.UseVisualStyleBackColor = false;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEndProcess.Enabled = false;
            this.btnEndProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEndProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEndProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndProcess.Location = new System.Drawing.Point(253, 455);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(89, 29);
            this.btnEndProcess.TabIndex = 1;
            this.btnEndProcess.Text = "End Process";
            this.btnEndProcess.UseVisualStyleBackColor = false;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = ">";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(458, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEndProcess);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbStdIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbStdErr);
            this.Controls.Add(this.rtbStdOut);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System.Diagnostics.Process  Tests";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RichTextBox rtbStdOut;
        private System.Windows.Forms.RichTextBox rtbStdErr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbStdIn;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.Label label4;
    }
}