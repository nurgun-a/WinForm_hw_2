
namespace WinForm_hw_2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_panel = new System.Windows.Forms.Button();
            this.button_calc = new System.Windows.Forms.Button();
            this.button_timer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_panel
            // 
            this.button_panel.Location = new System.Drawing.Point(81, 220);
            this.button_panel.Margin = new System.Windows.Forms.Padding(4);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(100, 53);
            this.button_panel.TabIndex = 0;
            this.button_panel.Text = "Задание №1";
            this.button_panel.UseVisualStyleBackColor = true;
            this.button_panel.Click += new System.EventHandler(this.button_panel_Click);
            this.button_panel.MouseEnter += new System.EventHandler(this.button_panel_MouseEnter);
            this.button_panel.MouseLeave += new System.EventHandler(this.button_panel_MouseLeave);
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(189, 220);
            this.button_calc.Margin = new System.Windows.Forms.Padding(4);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(100, 53);
            this.button_calc.TabIndex = 0;
            this.button_calc.Text = "Задание №2";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            this.button_calc.MouseEnter += new System.EventHandler(this.button_calc_MouseEnter);
            this.button_calc.MouseLeave += new System.EventHandler(this.button_calc_MouseLeave);
            // 
            // button_timer
            // 
            this.button_timer.Location = new System.Drawing.Point(297, 220);
            this.button_timer.Margin = new System.Windows.Forms.Padding(4);
            this.button_timer.Name = "button_timer";
            this.button_timer.Size = new System.Drawing.Size(100, 53);
            this.button_timer.TabIndex = 0;
            this.button_timer.Text = "Задание №3";
            this.button_timer.UseVisualStyleBackColor = true;
            this.button_timer.Click += new System.EventHandler(this.button_timer_Click);
            this.button_timer.MouseEnter += new System.EventHandler(this.button_timer_MouseEnter);
            this.button_timer.MouseLeave += new System.EventHandler(this.button_timer_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "info";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(591, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_timer);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.button_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Д/з №2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_panel;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Button button_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

