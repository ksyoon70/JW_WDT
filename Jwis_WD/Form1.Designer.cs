namespace Jwis_WD
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel_form = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_start_stop = new System.Windows.Forms.Button();
            this.button_trigger = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_timer = new System.Windows.Forms.Panel();
            this.label_timer = new System.Windows.Forms.Label();
            this.numericUpDown_timer = new System.Windows.Forms.NumericUpDown();
            this.refresh_UpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerWatchdog = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_form.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_form
            // 
            this.tableLayoutPanel_form.ColumnCount = 2;
            this.tableLayoutPanel_form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_form.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel_form.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel_form.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_form.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_form.Name = "tableLayoutPanel_form";
            this.tableLayoutPanel_form.RowCount = 2;
            this.tableLayoutPanel_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.7251F));
            this.tableLayoutPanel_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.2749F));
            this.tableLayoutPanel_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_form.Size = new System.Drawing.Size(401, 251);
            this.tableLayoutPanel_form.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Watchdog";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_start_stop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_trigger, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_timer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_timer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.refresh_UpDown, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44481F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44481F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11037F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 199);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Refresh Time(초)";
            // 
            // button_start_stop
            // 
            this.button_start_stop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_start_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(168)))));
            this.button_start_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_start_stop.Location = new System.Drawing.Point(225, 18);
            this.button_start_stop.Name = "button_start_stop";
            this.button_start_stop.Size = new System.Drawing.Size(89, 30);
            this.button_start_stop.TabIndex = 1;
            this.button_start_stop.Text = "Start";
            this.button_start_stop.UseVisualStyleBackColor = false;
            this.button_start_stop.Click += new System.EventHandler(this.button_start_stop_Click);
            // 
            // button_trigger
            // 
            this.button_trigger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_trigger.BackColor = System.Drawing.Color.Gray;
            this.button_trigger.Enabled = false;
            this.button_trigger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_trigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trigger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_trigger.Location = new System.Drawing.Point(225, 84);
            this.button_trigger.Name = "button_trigger";
            this.button_trigger.Size = new System.Drawing.Size(89, 30);
            this.button_trigger.TabIndex = 2;
            this.button_trigger.Text = "Trigger";
            this.button_trigger.UseVisualStyleBackColor = false;
            this.button_trigger.EnabledChanged += new System.EventHandler(this.button_trigger_EnabledChanged);
            this.button_trigger.Click += new System.EventHandler(this.button_trigger_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "WDT Timeout(초)";
            // 
            // panel_timer
            // 
            this.panel_timer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.panel_timer, 2);
            this.panel_timer.Controls.Add(this.label_timer);
            this.panel_timer.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_timer.Location = new System.Drawing.Point(1, 11);
            this.panel_timer.Margin = new System.Windows.Forms.Padding(1);
            this.panel_timer.Name = "panel_timer";
            this.panel_timer.Size = new System.Drawing.Size(220, 43);
            this.panel_timer.TabIndex = 4;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_timer.Location = new System.Drawing.Point(175, 2);
            this.label_timer.Name = "label_timer";
            this.label_timer.Padding = new System.Windows.Forms.Padding(3);
            this.label_timer.Size = new System.Drawing.Size(35, 37);
            this.label_timer.TabIndex = 0;
            this.label_timer.Text = "0";
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_timer
            // 
            this.numericUpDown_timer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_timer.Location = new System.Drawing.Point(114, 88);
            this.numericUpDown_timer.Name = "numericUpDown_timer";
            this.numericUpDown_timer.Size = new System.Drawing.Size(105, 22);
            this.numericUpDown_timer.TabIndex = 5;
            this.numericUpDown_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_timer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_timer.ValueChanged += new System.EventHandler(this.WDT_TimeChanged);
            // 
            // refresh_UpDown
            // 
            this.refresh_UpDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.refresh_UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_UpDown.Location = new System.Drawing.Point(114, 154);
            this.refresh_UpDown.Name = "refresh_UpDown";
            this.refresh_UpDown.Size = new System.Drawing.Size(105, 22);
            this.refresh_UpDown.TabIndex = 7;
            this.refresh_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refresh_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refresh_UpDown.ValueChanged += new System.EventHandler(this.WDT_RefreshTimeChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timerWatchdog
            // 
            this.timerWatchdog.Interval = 1000;
            this.timerWatchdog.Tick += new System.EventHandler(this.timerWatchdog_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WDT";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.보기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.보기ToolStripMenuItem.Text = "보기";
            this.보기ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemShow_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(401, 251);
            this.Controls.Add(this.tableLayoutPanel_form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "진우산전(JWIS)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.tableLayoutPanel_form.ResumeLayout(false);
            this.tableLayoutPanel_form.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_timer.ResumeLayout(false);
            this.panel_timer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start_stop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_trigger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_timer;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.NumericUpDown numericUpDown_timer;
        private System.Windows.Forms.Timer timerWatchdog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown refresh_UpDown;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

