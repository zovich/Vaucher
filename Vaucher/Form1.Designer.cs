namespace Vaucher
{
    partial class Vaucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vaucher));
            this.Start = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbkeys = new System.Windows.Forms.TextBox();
            this.firstnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(219, 25);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(300, 25);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(381, 25);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(75, 23);
            this.Info.TabIndex = 3;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(15, 28);
            this.number.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(88, 20);
            this.number.TabIndex = 4;
            this.number.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbkeys
            // 
            this.tbkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbkeys.Location = new System.Drawing.Point(12, 54);
            this.tbkeys.Multiline = true;
            this.tbkeys.Name = "tbkeys";
            this.tbkeys.ReadOnly = true;
            this.tbkeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbkeys.Size = new System.Drawing.Size(444, 251);
            this.tbkeys.TabIndex = 6;
            // 
            // firstnumber
            // 
            this.firstnumber.Location = new System.Drawing.Point(120, 28);
            this.firstnumber.Name = "firstnumber";
            this.firstnumber.Size = new System.Drawing.Size(93, 20);
            this.firstnumber.TabIndex = 7;
            this.firstnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.firstnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstnumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First 6 digits";
            // 
            // Vaucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnumber);
            this.Controls.Add(this.tbkeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vaucher";
            this.Text = "Vaucher";
            this.Load += new System.EventHandler(this.Vaucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbkeys;
        private System.Windows.Forms.TextBox firstnumber;
        private System.Windows.Forms.Label label2;
    }
}

