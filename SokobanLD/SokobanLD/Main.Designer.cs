namespace SokobanLD
{
    partial class Main
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
            this.label_width = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gotogrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_width.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_width.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_width.Location = new System.Drawing.Point(16, 66);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(45, 16);
            this.label_width.TabIndex = 0;
            this.label_width.Text = "Width";
            this.label_width.Click += new System.EventHandler(this.label_width_Click);
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_height.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_height.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_height.Location = new System.Drawing.Point(12, 103);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(49, 16);
            this.label_height.TabIndex = 1;
            this.label_height.Text = "Height";
            this.label_height.Click += new System.EventHandler(this.label_height_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidth.Location = new System.Drawing.Point(67, 63);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(36, 23);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(67, 100);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(36, 23);
            this.textBoxHeight.TabIndex = 3;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(185, 66);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(133, 106);
            this.result.TabIndex = 4;
            this.result.Text = "";
            this.result.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sokoban Level Design";
            // 
            // gotogrid
            // 
            this.gotogrid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gotogrid.Location = new System.Drawing.Point(19, 147);
            this.gotogrid.Name = "gotogrid";
            this.gotogrid.Size = new System.Drawing.Size(75, 23);
            this.gotogrid.TabIndex = 6;
            this.gotogrid.Text = "Go to Grid";
            this.gotogrid.UseVisualStyleBackColor = false;
            this.gotogrid.Click += new System.EventHandler(this.gotogrid_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(100, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(330, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gotogrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_width);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gotogrid;
        private System.Windows.Forms.Button button1;
    }
}

