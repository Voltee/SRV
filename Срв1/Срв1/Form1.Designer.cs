namespace Срв1
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_rand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.ch_divide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_main.Location = new System.Drawing.Point(200, 100);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(500, 500);
            this.pnl_main.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(150, 60);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(168, 12);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(150, 60);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Пауза";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_rand
            // 
            this.btn_rand.Location = new System.Drawing.Point(822, 12);
            this.btn_rand.Name = "btn_rand";
            this.btn_rand.Size = new System.Drawing.Size(150, 60);
            this.btn_rand.TabIndex = 3;
            this.btn_rand.Text = "Случайная траектория";
            this.btn_rand.UseVisualStyleBackColor = true;
            this.btn_rand.Click += new System.EventHandler(this.btn_rand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(324, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Время движения";
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(822, 100);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(150, 60);
            this.btn_restart.TabIndex = 5;
            this.btn_restart.Text = "Рестарт";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // ch_divide
            // 
            this.ch_divide.AutoSize = true;
            this.ch_divide.Location = new System.Drawing.Point(797, 583);
            this.ch_divide.Name = "ch_divide";
            this.ch_divide.Size = new System.Drawing.Size(175, 17);
            this.ch_divide.TabIndex = 6;
            this.ch_divide.Text = "Разделить при столкновении";
            this.ch_divide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.ch_divide);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rand);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pnl_main);
            this.Name = "Form1";
            this.Text = "СРВ №1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_rand;
        public System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_restart;
        public System.Windows.Forms.CheckBox ch_divide;
    }
}

