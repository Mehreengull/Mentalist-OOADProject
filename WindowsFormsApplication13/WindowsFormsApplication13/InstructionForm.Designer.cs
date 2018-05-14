namespace WindowsFormsApplication13
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.startbtn = new System.Windows.Forms.Button();
            this.instructiontxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(145, 226);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // instructiontxt
            // 
            this.instructiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructiontxt.Location = new System.Drawing.Point(12, 12);
            this.instructiontxt.Name = "instructiontxt";
            this.instructiontxt.Size = new System.Drawing.Size(393, 207);
            this.instructiontxt.TabIndex = 4;
            this.instructiontxt.Text = resources.GetString("instructiontxt.Text");
            this.instructiontxt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.NNJNKMK;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.instructiontxt);
            this.Controls.Add(this.startbtn);
            this.Name = "InstructionForm";
            this.Text = "InstructionForm";
            this.Load += new System.EventHandler(this.InstructionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.RichTextBox instructiontxt;
    }
}