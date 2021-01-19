
namespace Tester
{
    partial class Parameters
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.openLocationCompiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компилятор";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(178, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(578, 34);
            this.textBox1.TabIndex = 1;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.save.Location = new System.Drawing.Point(668, 383);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 55);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openLocationCompiler
            // 
            this.openLocationCompiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openLocationCompiler.Location = new System.Drawing.Point(762, 14);
            this.openLocationCompiler.Name = "openLocationCompiler";
            this.openLocationCompiler.Size = new System.Drawing.Size(26, 42);
            this.openLocationCompiler.TabIndex = 3;
            this.openLocationCompiler.Text = ":";
            this.openLocationCompiler.UseVisualStyleBackColor = true;
            this.openLocationCompiler.Click += new System.EventHandler(this.openLocationCompiler_Click);
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openLocationCompiler);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Parameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button openLocationCompiler;
    }
}