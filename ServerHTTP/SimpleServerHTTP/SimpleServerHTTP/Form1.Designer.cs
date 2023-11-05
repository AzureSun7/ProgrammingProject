namespace SimpleServerHTTP
{
    partial class RegisteredUsers
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.serverPortText = new System.Windows.Forms.Label();
            this.serverLogText = new System.Windows.Forms.Label();
            this.registerLog = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 26);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Server";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(12, 57);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(103, 26);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop Server";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // serverPortText
            // 
            this.serverPortText.AutoSize = true;
            this.serverPortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPortText.Location = new System.Drawing.Point(12, 189);
            this.serverPortText.Name = "serverPortText";
            this.serverPortText.Size = new System.Drawing.Size(80, 17);
            this.serverPortText.TabIndex = 2;
            this.serverPortText.Text = "Server Port";
            // 
            // serverLogText
            // 
            this.serverLogText.AutoSize = true;
            this.serverLogText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLogText.Location = new System.Drawing.Point(184, 5);
            this.serverLogText.Name = "serverLogText";
            this.serverLogText.Size = new System.Drawing.Size(89, 17);
            this.serverLogText.TabIndex = 3;
            this.serverLogText.Text = "Register Log";
            // 
            // registerLog
            // 
            this.registerLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLog.Location = new System.Drawing.Point(187, 25);
            this.registerLog.Multiline = true;
            this.registerLog.Name = "registerLog";
            this.registerLog.ReadOnly = true;
            this.registerLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.registerLog.Size = new System.Drawing.Size(674, 524);
            this.registerLog.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            // 
            // RegisteredUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 561);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.registerLog);
            this.Controls.Add(this.serverLogText);
            this.Controls.Add(this.serverPortText);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "RegisteredUsers";
            this.Text = " ";
            this.Load += new System.EventHandler(this.RegisteredUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label serverPortText;
        private System.Windows.Forms.Label serverLogText;
        private System.Windows.Forms.TextBox registerLog;
        private System.Windows.Forms.TextBox textBox2;
    }
}

