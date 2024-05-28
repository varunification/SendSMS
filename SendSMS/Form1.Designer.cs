namespace SendSMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fromtxt = new System.Windows.Forms.Label();
            this.totxt = new System.Windows.Forms.Label();
            this.message_body = new System.Windows.Forms.Label();
            this.CountryCode = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.richTextMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fromtxt
            // 
            this.fromtxt.AutoSize = true;
            this.fromtxt.Location = new System.Drawing.Point(143, 67);
            this.fromtxt.Name = "fromtxt";
            this.fromtxt.Size = new System.Drawing.Size(121, 25);
            this.fromtxt.TabIndex = 0;
            this.fromtxt.Text = "country_Code";
            // 
            // totxt
            // 
            this.totxt.AutoSize = true;
            this.totxt.Location = new System.Drawing.Point(143, 137);
            this.totxt.Name = "totxt";
            this.totxt.Size = new System.Drawing.Size(30, 25);
            this.totxt.TabIndex = 1;
            this.totxt.Text = "To";
            this.totxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // message_body
            // 
            this.message_body.AutoSize = true;
            this.message_body.Location = new System.Drawing.Point(143, 209);
            this.message_body.Name = "message_body";
            this.message_body.Size = new System.Drawing.Size(131, 25);
            this.message_body.TabIndex = 2;
            this.message_body.Text = "message_body";
            // 
            // CountryCode
            // 
            this.CountryCode.Location = new System.Drawing.Point(284, 67);
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.Size = new System.Drawing.Size(261, 31);
            this.CountryCode.TabIndex = 5;
            this.CountryCode.TextChanged += new System.EventHandler(this.textFrom_TextChanged);
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(284, 137);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(261, 31);
            this.textTo.TabIndex = 6;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Location = new System.Drawing.Point(630, 391);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(112, 34);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // richTextMessage
            // 
            this.richTextMessage.Location = new System.Drawing.Point(143, 255);
            this.richTextMessage.Name = "richTextMessage";
            this.richTextMessage.Size = new System.Drawing.Size(402, 144);
            this.richTextMessage.TabIndex = 11;
            this.richTextMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextMessage);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.CountryCode);
            this.Controls.Add(this.message_body);
            this.Controls.Add(this.totxt);
            this.Controls.Add(this.fromtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fromtxt;
        private Label totxt;
        private Label message_body;
        private TextBox CountryCode;
        private TextBox textTo;
        private Button submit;
        private RichTextBox richTextMessage;
    }
}