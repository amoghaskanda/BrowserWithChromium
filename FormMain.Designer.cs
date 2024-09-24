namespace BrowserWithChromium
{
    partial class FormMain
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
            this.buttonGo = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.Reload = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(1192, 11);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 24);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "&Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Location = new System.Drawing.Point(10, 45);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1261, 633);
            this.pContainer.TabIndex = 2;
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(74, 12);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(55, 24);
            this.Reload.TabIndex = 5;
            this.Reload.Text = "&Refresh";
            this.Reload.UseVisualStyleBackColor = true;
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(42, 12);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(30, 24);
            this.Forward.TabIndex = 7;
            this.Forward.Text = ">>";
            this.Forward.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 24);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUrl.Location = new System.Drawing.Point(132, 12);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(1054, 24);
            this.textUrl.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 690);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.buttonGo);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textUrl;
    }
}

