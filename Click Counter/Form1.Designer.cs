
namespace Click_Counter
{
    partial class ls_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ls_main));
            this.btn_count = new System.Windows.Forms.Button();
            this.lbl_count_digit = new System.Windows.Forms.Label();
            this.lbl_link_open_source = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_count
            // 
            this.btn_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_count.Location = new System.Drawing.Point(335, 234);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(130, 50);
            this.btn_count.TabIndex = 0;
            this.btn_count.Text = "Count";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // lbl_count_digit
            // 
            this.lbl_count_digit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_count_digit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_count_digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_count_digit.Location = new System.Drawing.Point(12, 186);
            this.lbl_count_digit.Name = "lbl_count_digit";
            this.lbl_count_digit.Size = new System.Drawing.Size(776, 31);
            this.lbl_count_digit.TabIndex = 1;
            this.lbl_count_digit.Text = "null";
            this.lbl_count_digit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_count_digit.UseCompatibleTextRendering = true;
            // 
            // lbl_link_open_source
            // 
            this.lbl_link_open_source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_link_open_source.AutoSize = true;
            this.lbl_link_open_source.LinkArea = new System.Windows.Forms.LinkArea(44, 63);
            this.lbl_link_open_source.Location = new System.Drawing.Point(324, 424);
            this.lbl_link_open_source.Name = "lbl_link_open_source";
            this.lbl_link_open_source.Size = new System.Drawing.Size(464, 17);
            this.lbl_link_open_source.TabIndex = 2;
            this.lbl_link_open_source.TabStop = true;
            this.lbl_link_open_source.Text = "This Program is Open-Source and avaible at: https://github.com/Niklas-debug/Click-Counter";
            this.lbl_link_open_source.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_link_open_source.UseCompatibleTextRendering = true;
            this.lbl_link_open_source.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_link_open_source_LinkClicked);
            // 
            // ls_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_link_open_source);
            this.Controls.Add(this.lbl_count_digit);
            this.Controls.Add(this.btn_count);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ls_main";
            this.Text = "Lorenz Services - Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Label lbl_count_digit;
        private System.Windows.Forms.LinkLabel lbl_link_open_source;
    }
}

