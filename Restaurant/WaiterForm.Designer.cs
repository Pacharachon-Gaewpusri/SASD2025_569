namespace Restaurant
{
    partial class WaiterForm
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
            Send = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Send
            // 
            Send.ImageAlign = ContentAlignment.BottomLeft;
            Send.Location = new Point(564, 67);
            Send.Name = "Send";
            Send.Size = new Size(75, 23);
            Send.TabIndex = 0;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 23);
            textBox1.TabIndex = 1;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Send);
            Name = "WaiterForm";
            Text = "WaiterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Send;
        private TextBox textBox1;
    }
}
