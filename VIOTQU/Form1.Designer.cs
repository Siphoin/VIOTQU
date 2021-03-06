﻿namespace VIOTQU
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWin = new System.Windows.Forms.Label();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelVideoAdapter = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelRAMString = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonCopyToBuffer = new System.Windows.Forms.Button();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.temp_cpu = new System.Windows.Forms.Label();
            this.timerUpdateCPU = new System.Windows.Forms.Timer(this.components);
            this.temp_ram = new System.Windows.Forms.Label();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.ForeColor = System.Drawing.Color.White;
            this.labelWin.Location = new System.Drawing.Point(90, 36);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(96, 19);
            this.labelWin.TabIndex = 1;
            this.labelWin.Text = "NAME_WIN";
            // 
            // labelProcessor
            // 
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor.ForeColor = System.Drawing.Color.White;
            this.labelProcessor.Location = new System.Drawing.Point(90, 108);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(169, 19);
            this.labelProcessor.TabIndex = 3;
            this.labelProcessor.Text = "PROCESSOR_NAME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // labelVideoAdapter
            // 
            this.labelVideoAdapter.AutoSize = true;
            this.labelVideoAdapter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVideoAdapter.ForeColor = System.Drawing.Color.White;
            this.labelVideoAdapter.Location = new System.Drawing.Point(90, 182);
            this.labelVideoAdapter.Name = "labelVideoAdapter";
            this.labelVideoAdapter.Size = new System.Drawing.Size(115, 19);
            this.labelVideoAdapter.TabIndex = 5;
            this.labelVideoAdapter.Text = "VIDEO_NAME";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // labelRAMString
            // 
            this.labelRAMString.AutoSize = true;
            this.labelRAMString.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRAMString.ForeColor = System.Drawing.Color.White;
            this.labelRAMString.Location = new System.Drawing.Point(90, 246);
            this.labelRAMString.Name = "labelRAMString";
            this.labelRAMString.Size = new System.Drawing.Size(108, 19);
            this.labelRAMString.TabIndex = 7;
            this.labelRAMString.Text = "RAM_VALUE";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.UseWaitCursor = true;
            // 
            // buttonCopyToBuffer
            // 
            this.buttonCopyToBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyToBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopyToBuffer.ForeColor = System.Drawing.Color.White;
            this.buttonCopyToBuffer.Location = new System.Drawing.Point(142, 344);
            this.buttonCopyToBuffer.Name = "buttonCopyToBuffer";
            this.buttonCopyToBuffer.Size = new System.Drawing.Size(249, 44);
            this.buttonCopyToBuffer.TabIndex = 8;
            this.buttonCopyToBuffer.Text = "Copy config this PC on buffer";
            this.buttonCopyToBuffer.UseVisualStyleBackColor = true;
            this.buttonCopyToBuffer.Click += new System.EventHandler(this.buttonCopyToBuffer_Click);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // temp_cpu
            // 
            this.temp_cpu.AutoSize = true;
            this.temp_cpu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temp_cpu.ForeColor = System.Drawing.Color.White;
            this.temp_cpu.Location = new System.Drawing.Point(20, 344);
            this.temp_cpu.Name = "temp_cpu";
            this.temp_cpu.Size = new System.Drawing.Size(114, 15);
            this.temp_cpu.TabIndex = 9;
            this.temp_cpu.Text = "TEMP_VALUE_CPU";
            // 
            // timerUpdateCPU
            // 
            this.timerUpdateCPU.Enabled = true;
            this.timerUpdateCPU.Interval = 2500;
            this.timerUpdateCPU.Tick += new System.EventHandler(this.timerUpdateCPU_Tick);
            // 
            // temp_ram
            // 
            this.temp_ram.AutoSize = true;
            this.temp_ram.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temp_ram.ForeColor = System.Drawing.Color.White;
            this.temp_ram.Location = new System.Drawing.Point(20, 366);
            this.temp_ram.Name = "temp_ram";
            this.temp_ram.Size = new System.Drawing.Size(116, 15);
            this.temp_ram.TabIndex = 10;
            this.temp_ram.Text = "TEMP_VALUE_RAM";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes in Use";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(403, 400);
            this.Controls.Add(this.temp_ram);
            this.Controls.Add(this.temp_cpu);
            this.Controls.Add(this.buttonCopyToBuffer);
            this.Controls.Add(this.labelRAMString);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelVideoAdapter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelProcessor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelVideoAdapter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelRAMString;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonCopyToBuffer;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Windows.Forms.Label temp_cpu;
        private System.Windows.Forms.Timer timerUpdateCPU;
        private System.Windows.Forms.Label temp_ram;
        private System.Diagnostics.PerformanceCounter RAM;
    }
}

