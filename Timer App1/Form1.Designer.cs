
namespace Timer_App1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button hour1;
            this.Start = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Button();
            this.sec1 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.sec10 = new System.Windows.Forms.Button();
            this.min30 = new System.Windows.Forms.Button();
            this.min10 = new System.Windows.Forms.Button();
            this.sec30 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.ProgressBar();
            this.timeup = new System.Windows.Forms.Button();
            hour1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hour1
            // 
            hour1.AutoEllipsis = true;
            hour1.BackColor = System.Drawing.Color.DarkOliveGreen;
            hour1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            hour1.Location = new System.Drawing.Point(495, 313);
            hour1.Name = "hour1";
            hour1.Size = new System.Drawing.Size(151, 52);
            hour1.TabIndex = 13;
            hour1.Tag = "";
            hour1.Text = "1Hour";
            hour1.UseVisualStyleBackColor = false;
            hour1.Visible = false;
            hour1.Click += new System.EventHandler(this.Button_SMH1);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.GrayText;
            this.Start.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Start.Location = new System.Drawing.Point(15, 507);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(304, 128);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("MS UI Gothic", 88F);
            this.display.Location = new System.Drawing.Point(95, 143);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(524, 118);
            this.display.TabIndex = 2;
            this.display.Text = "XX:XX:XX";
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.Yellow;
            this.min1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.min1.Location = new System.Drawing.Point(12, 284);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(150, 52);
            this.min1.TabIndex = 4;
            this.min1.Tag = "";
            this.min1.Text = "1Minute";
            this.min1.UseVisualStyleBackColor = false;
            this.min1.Click += new System.EventHandler(this.Button_SMH1);
            // 
            // sec1
            // 
            this.sec1.BackColor = System.Drawing.Color.Crimson;
            this.sec1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sec1.Location = new System.Drawing.Point(181, 284);
            this.sec1.Name = "sec1";
            this.sec1.Size = new System.Drawing.Size(151, 52);
            this.sec1.TabIndex = 5;
            this.sec1.Tag = "";
            this.sec1.Text = "1Second";
            this.sec1.UseVisualStyleBackColor = false;
            this.sec1.Click += new System.EventHandler(this.Button_SMH1);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Black;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(338, 371);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(304, 117);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // sec10
            // 
            this.sec10.BackColor = System.Drawing.Color.Crimson;
            this.sec10.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sec10.Location = new System.Drawing.Point(181, 359);
            this.sec10.Name = "sec10";
            this.sec10.Size = new System.Drawing.Size(151, 52);
            this.sec10.TabIndex = 7;
            this.sec10.Text = "10Seconds";
            this.sec10.UseVisualStyleBackColor = false;
            this.sec10.Click += new System.EventHandler(this.Button_SMH10);
            // 
            // min30
            // 
            this.min30.BackColor = System.Drawing.Color.Yellow;
            this.min30.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.min30.Location = new System.Drawing.Point(11, 437);
            this.min30.Name = "min30";
            this.min30.Size = new System.Drawing.Size(151, 52);
            this.min30.TabIndex = 10;
            this.min30.Text = "30Minutes";
            this.min30.UseVisualStyleBackColor = false;
            this.min30.Click += new System.EventHandler(this.Button_SMH30);
            // 
            // min10
            // 
            this.min10.BackColor = System.Drawing.Color.Yellow;
            this.min10.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.min10.Location = new System.Drawing.Point(11, 359);
            this.min10.Name = "min10";
            this.min10.Size = new System.Drawing.Size(151, 52);
            this.min10.TabIndex = 9;
            this.min10.Text = "10Minutes";
            this.min10.UseVisualStyleBackColor = false;
            this.min10.Click += new System.EventHandler(this.Button_SMH10);
            // 
            // sec30
            // 
            this.sec30.BackColor = System.Drawing.Color.Crimson;
            this.sec30.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sec30.Location = new System.Drawing.Point(181, 437);
            this.sec30.Name = "sec30";
            this.sec30.Size = new System.Drawing.Size(151, 52);
            this.sec30.TabIndex = 14;
            this.sec30.Text = "30Seconds";
            this.sec30.UseVisualStyleBackColor = false;
            this.sec30.Click += new System.EventHandler(this.Button_SMH30);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HG正楷書体-PRO", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(62, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(539, 97);
            this.Title.TabIndex = 15;
            this.Title.Text = "Timer App";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Stop.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stop.Location = new System.Drawing.Point(338, 507);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(304, 128);
            this.Stop.TabIndex = 18;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("游明朝", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.status.Location = new System.Drawing.Point(338, 261);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(219, 83);
            this.status.TabIndex = 19;
            this.status.Text = "NULL";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // status2
            // 
            this.status2.Location = new System.Drawing.Point(341, 342);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(305, 23);
            this.status2.TabIndex = 20;
            this.status2.Click += new System.EventHandler(this.status2_Click);
            // 
            // timeup
            // 
            this.timeup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeup.CausesValidation = false;
            this.timeup.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeup.Location = new System.Drawing.Point(-9, -6);
            this.timeup.Name = "timeup";
            this.timeup.Size = new System.Drawing.Size(685, 681);
            this.timeup.TabIndex = 21;
            this.timeup.Text = "タイムアップ";
            this.timeup.UseVisualStyleBackColor = false;
            this.timeup.Click += new System.EventHandler(this.timeup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 663);
            this.Controls.Add(this.timeup);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.sec30);
            this.Controls.Add(hour1);
            this.Controls.Add(this.min30);
            this.Controls.Add(this.min10);
            this.Controls.Add(this.sec10);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.sec1);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Start);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(674, 702);
            this.MinimumSize = new System.Drawing.Size(674, 702);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Tag = "Button_MSH1";
            this.Text = "TimerApp Ver1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button min1;
        private System.Windows.Forms.Button sec1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button sec10;
        private System.Windows.Forms.Button min30;
        private System.Windows.Forms.Button min10;
        private System.Windows.Forms.Button sec30;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ProgressBar status2;
        private System.Windows.Forms.Button timeup;
    }
}

