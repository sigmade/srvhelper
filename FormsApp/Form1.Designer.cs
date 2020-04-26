namespace FormsApp
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
            this.domenBox = new System.Windows.Forms.TextBox();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.IpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortBtn = new System.Windows.Forms.Button();
            this.PortLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IpPortBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PinBtn = new System.Windows.Forms.Button();
            this.TraceBtn = new System.Windows.Forms.Button();
            this.ServBtn = new System.Windows.Forms.Button();
            this.ServLbl = new System.Windows.Forms.Label();
            this.CnslBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domenBox
            // 
            this.domenBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domenBox.Location = new System.Drawing.Point(146, 33);
            this.domenBox.Name = "domenBox";
            this.domenBox.Size = new System.Drawing.Size(174, 30);
            this.domenBox.TabIndex = 0;
            this.domenBox.Text = "erp-server.ru";
            this.domenBox.Click += new System.EventHandler(this.domenBox_Click);
            // 
            // IpBox
            // 
            this.IpBox.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.IpBox.Location = new System.Drawing.Point(146, 96);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(174, 30);
            this.IpBox.TabIndex = 2;
            // 
            // IpBtn
            // 
            this.IpBtn.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.IpBtn.Location = new System.Drawing.Point(146, 166);
            this.IpBtn.Name = "IpBtn";
            this.IpBtn.Size = new System.Drawing.Size(175, 39);
            this.IpBtn.TabIndex = 3;
            this.IpBtn.Text = "Узнать IP";
            this.IpBtn.UseVisualStyleBackColor = true;
            this.IpBtn.Click += new System.EventHandler(this.IpBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(143, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // PortBtn
            // 
            this.PortBtn.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.PortBtn.Location = new System.Drawing.Point(146, 424);
            this.PortBtn.Name = "PortBtn";
            this.PortBtn.Size = new System.Drawing.Size(174, 39);
            this.PortBtn.TabIndex = 6;
            this.PortBtn.Text = "Проверить порт";
            this.PortBtn.UseVisualStyleBackColor = true;
            this.PortBtn.Click += new System.EventHandler(this.PortBtn_Click);
            // 
            // PortLbl
            // 
            this.PortLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortLbl.Location = new System.Drawing.Point(143, 381);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(177, 39);
            this.PortLbl.TabIndex = 7;
            this.PortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.label5.Location = new System.Drawing.Point(21, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP адрес";
            // 
            // IpPortBox
            // 
            this.IpPortBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IpPortBox.Location = new System.Drawing.Point(146, 265);
            this.IpPortBox.Name = "IpPortBox";
            this.IpPortBox.Size = new System.Drawing.Size(174, 30);
            this.IpPortBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "IP адрес";
            // 
            // PortBox
            // 
            this.PortBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortBox.Location = new System.Drawing.Point(146, 335);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(174, 30);
            this.PortBox.TabIndex = 12;
            this.PortBox.Text = "21";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.checkBox1.Location = new System.Drawing.Point(146, 302);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "тот же IP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PinBtn
            // 
            this.PinBtn.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.PinBtn.Location = new System.Drawing.Point(234, 211);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(84, 39);
            this.PinBtn.TabIndex = 15;
            this.PinBtn.Text = "PING";
            this.PinBtn.UseVisualStyleBackColor = true;
            this.PinBtn.Click += new System.EventHandler(this.PinBtn_Click);
            // 
            // TraceBtn
            // 
            this.TraceBtn.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.TraceBtn.Location = new System.Drawing.Point(146, 211);
            this.TraceBtn.Name = "TraceBtn";
            this.TraceBtn.Size = new System.Drawing.Size(84, 39);
            this.TraceBtn.TabIndex = 16;
            this.TraceBtn.Text = "Trace";
            this.TraceBtn.UseVisualStyleBackColor = true;
            this.TraceBtn.Click += new System.EventHandler(this.TraceBtn_Click);
            // 
            // ServBtn
            // 
            this.ServBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServBtn.Location = new System.Drawing.Point(25, 211);
            this.ServBtn.Name = "ServBtn";
            this.ServBtn.Size = new System.Drawing.Size(100, 39);
            this.ServBtn.TabIndex = 17;
            this.ServBtn.Text = "Сервер";
            this.ServBtn.UseVisualStyleBackColor = true;
            this.ServBtn.Click += new System.EventHandler(this.ServBtn_Click);
            // 
            // ServLbl
            // 
            this.ServLbl.AutoSize = true;
            this.ServLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServLbl.Location = new System.Drawing.Point(32, 166);
            this.ServLbl.Name = "ServLbl";
            this.ServLbl.Size = new System.Drawing.Size(0, 19);
            this.ServLbl.TabIndex = 18;
            // 
            // CnslBtn
            // 
            this.CnslBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnslBtn.Location = new System.Drawing.Point(25, 424);
            this.CnslBtn.Name = "CnslBtn";
            this.CnslBtn.Size = new System.Drawing.Size(100, 39);
            this.CnslBtn.TabIndex = 19;
            this.CnslBtn.Text = "Консоль";
            this.CnslBtn.UseVisualStyleBackColor = true;
            this.CnslBtn.Click += new System.EventHandler(this.CnslBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(358, 481);
            this.Controls.Add(this.CnslBtn);
            this.Controls.Add(this.ServLbl);
            this.Controls.Add(this.ServBtn);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpBtn);
            this.Controls.Add(this.IpBox);
            this.Controls.Add(this.domenBox);
            this.MinimumSize = new System.Drawing.Size(374, 39);
            this.Name = "Form1";
            this.Text = "IP Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox domenBox;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.Button IpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PortBtn;
        private System.Windows.Forms.Label PortLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IpPortBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button PinBtn;
        private System.Windows.Forms.Button TraceBtn;
        private System.Windows.Forms.Button ServBtn;
        private System.Windows.Forms.Label ServLbl;
        private System.Windows.Forms.Button CnslBtn;
    }
}

