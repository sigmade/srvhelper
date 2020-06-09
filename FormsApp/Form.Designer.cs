namespace FormsApp
{
    partial class Form
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
            this.domenBox = new System.Windows.Forms.TextBox();
            this.PortBtn = new System.Windows.Forms.Button();
            this.PortLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.CsvBox = new System.Windows.Forms.TextBox();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.IpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IpPortBox = new System.Windows.Forms.TextBox();
            this.PinBtn = new System.Windows.Forms.Button();
            this.TraceBtn = new System.Windows.Forms.Button();
            this.ServerBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // domenBox
            // 
            this.domenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.domenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domenBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domenBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.domenBox.Location = new System.Drawing.Point(146, 33);
            this.domenBox.Name = "domenBox";
            this.domenBox.Size = new System.Drawing.Size(181, 30);
            this.domenBox.TabIndex = 0;
            this.domenBox.Text = "google.com";
            this.domenBox.Click += new System.EventHandler(this.domenBox_Click);
            // 
            // PortBtn
            // 
            this.PortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.PortBtn.FlatAppearance.BorderSize = 0;
            this.PortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PortBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PortBtn.Location = new System.Drawing.Point(146, 451);
            this.PortBtn.Name = "PortBtn";
            this.PortBtn.Size = new System.Drawing.Size(174, 31);
            this.PortBtn.TabIndex = 6;
            this.PortBtn.Text = "Проверить порт";
            this.PortBtn.UseVisualStyleBackColor = false;
            this.PortBtn.Click += new System.EventHandler(this.PortBtn_Click);
            // 
            // PortLbl
            // 
            this.PortLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.PortLbl.Location = new System.Drawing.Point(146, 379);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(174, 33);
            this.PortLbl.TabIndex = 7;
            this.PortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Имя домена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(21, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.label6.Location = new System.Drawing.Point(21, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "IP адрес";
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.PortBox.Location = new System.Drawing.Point(146, 335);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(181, 30);
            this.PortBox.TabIndex = 12;
            this.PortBox.Text = "21";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.label7.Location = new System.Drawing.Point(21, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер порта";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.checkBox1.Location = new System.Drawing.Point(146, 302);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "тот же IP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.ServerNameLabel.Location = new System.Drawing.Point(32, 166);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(0, 19);
            this.ServerNameLabel.TabIndex = 18;
            // 
            // CsvBox
            // 
            this.CsvBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.CsvBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CsvBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.CsvBox.Location = new System.Drawing.Point(555, 33);
            this.CsvBox.Multiline = true;
            this.CsvBox.Name = "CsvBox";
            this.CsvBox.Size = new System.Drawing.Size(192, 400);
            this.CsvBox.TabIndex = 21;
            // 
            // CopyBtn
            // 
            this.CopyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(136)))), ((int)(((byte)(65)))));
            this.CopyBtn.FlatAppearance.BorderSize = 0;
            this.CopyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CopyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CopyBtn.Location = new System.Drawing.Point(353, 451);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(184, 31);
            this.CopyBtn.TabIndex = 24;
            this.CopyBtn.Text = "Копировать в буфер";
            this.CopyBtn.UseVisualStyleBackColor = false;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(136)))), ((int)(((byte)(65)))));
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.OpenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenBtn.Location = new System.Drawing.Point(555, 451);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(192, 31);
            this.OpenBtn.TabIndex = 25;
            this.OpenBtn.Text = "Открыть в папке";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // IpBox
            // 
            this.IpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.IpBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IpBox.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.IpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.IpBox.Location = new System.Drawing.Point(146, 96);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(181, 30);
            this.IpBox.TabIndex = 2;
            // 
            // IpBtn
            // 
            this.IpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.IpBtn.FlatAppearance.BorderSize = 0;
            this.IpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IpBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.IpBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IpBtn.Location = new System.Drawing.Point(146, 154);
            this.IpBtn.Name = "IpBtn";
            this.IpBtn.Size = new System.Drawing.Size(93, 31);
            this.IpBtn.TabIndex = 3;
            this.IpBtn.Text = "Узнать IP";
            this.IpBtn.UseVisualStyleBackColor = false;
            this.IpBtn.Click += new System.EventHandler(this.IpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // IpPortBox
            // 
            this.IpPortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.IpPortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IpPortBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IpPortBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.IpPortBox.Location = new System.Drawing.Point(146, 265);
            this.IpPortBox.Name = "IpPortBox";
            this.IpPortBox.Size = new System.Drawing.Size(181, 30);
            this.IpPortBox.TabIndex = 10;
            // 
            // PinBtn
            // 
            this.PinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.PinBtn.FlatAppearance.BorderSize = 0;
            this.PinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PinBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PinBtn.Location = new System.Drawing.Point(234, 211);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(93, 31);
            this.PinBtn.TabIndex = 15;
            this.PinBtn.Text = "PING";
            this.PinBtn.UseVisualStyleBackColor = false;
            this.PinBtn.Click += new System.EventHandler(this.PinBtn_Click);
            // 
            // TraceBtn
            // 
            this.TraceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.TraceBtn.FlatAppearance.BorderSize = 0;
            this.TraceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraceBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TraceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TraceBtn.Location = new System.Drawing.Point(146, 211);
            this.TraceBtn.Name = "TraceBtn";
            this.TraceBtn.Size = new System.Drawing.Size(84, 31);
            this.TraceBtn.TabIndex = 16;
            this.TraceBtn.Text = "Trace";
            this.TraceBtn.UseVisualStyleBackColor = false;
            this.TraceBtn.Click += new System.EventHandler(this.TraceBtn_Click);
            // 
            // ServerBtn
            // 
            this.ServerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.ServerBtn.FlatAppearance.BorderSize = 0;
            this.ServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ServerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerBtn.Location = new System.Drawing.Point(25, 211);
            this.ServerBtn.Name = "ServerBtn";
            this.ServerBtn.Size = new System.Drawing.Size(100, 31);
            this.ServerBtn.TabIndex = 17;
            this.ServerBtn.Text = "Сервер";
            this.ServerBtn.UseVisualStyleBackColor = false;
            this.ServerBtn.Click += new System.EventHandler(this.ServerBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(245, 154);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(84, 31);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "Add CSV";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.ResultBox.Location = new System.Drawing.Point(353, 33);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(184, 398);
            this.ResultBox.TabIndex = 26;
            // 
            // Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(770, 509);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.CsvBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ServerNameLabel);
            this.Controls.Add(this.ServerBtn);
            this.Controls.Add(this.TraceBtn);
            this.Controls.Add(this.PinBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IpPortBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PortLbl);
            this.Controls.Add(this.PortBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpBtn);
            this.Controls.Add(this.IpBox);
            this.Controls.Add(this.domenBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(374, 39);
            this.Name = "Form";
            this.Opacity = 0.98D;
            this.Text = "SRV Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
       
        private System.Windows.Forms.TextBox domenBox;
        private System.Windows.Forms.Button PortBtn;
        private System.Windows.Forms.Label PortLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.TextBox CsvBox;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.Button IpBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IpPortBox;
        private System.Windows.Forms.Button PinBtn;
        private System.Windows.Forms.Button TraceBtn;
        private System.Windows.Forms.Button ServerBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

