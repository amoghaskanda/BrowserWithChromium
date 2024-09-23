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
            this.textUrl = new System.Windows.Forms.TextBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(723, 12);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "&Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Location = new System.Drawing.Point(110, 12);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(607, 20);
            this.textUrl.TabIndex = 1;
            this.textUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextUrl_KeyPress);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Location = new System.Drawing.Point(10, 38);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(786, 409);
            this.pContainer.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 7);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(41, 6);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(30, 23);
            this.Forward.TabIndex = 3;
            this.Forward.Text = ">>";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(74, 6);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(30, 23);
            this.Reload.TabIndex = 1;
            this.Reload.Text = "F5";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.buttonGo);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Reload;
    }
}

