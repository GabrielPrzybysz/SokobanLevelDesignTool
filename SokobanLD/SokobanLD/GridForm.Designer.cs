namespace SokobanLD
{
    partial class GridForm
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
            this.item = new System.Windows.Forms.Button();
            this.onPoint = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.free = new System.Windows.Forms.Button();
            this.wall = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedColorButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.item.BackColor = System.Drawing.Color.Lime;
            this.item.Location = new System.Drawing.Point(872, 575);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(30, 30);
            this.item.TabIndex = 0;
            this.item.UseVisualStyleBackColor = false;
            this.item.Click += new System.EventHandler(this.item_Click);
            // 
            // onPoint
            // 
            this.onPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.onPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.onPoint.Location = new System.Drawing.Point(872, 539);
            this.onPoint.Name = "onPoint";
            this.onPoint.Size = new System.Drawing.Size(30, 30);
            this.onPoint.TabIndex = 1;
            this.onPoint.UseVisualStyleBackColor = false;
            this.onPoint.Click += new System.EventHandler(this.onPoint_Click);
            // 
            // point
            // 
            this.point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.point.BackColor = System.Drawing.Color.Red;
            this.point.Location = new System.Drawing.Point(872, 503);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(30, 30);
            this.point.TabIndex = 2;
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // free
            // 
            this.free.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.free.BackColor = System.Drawing.Color.White;
            this.free.Location = new System.Drawing.Point(872, 395);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(30, 30);
            this.free.TabIndex = 5;
            this.free.UseVisualStyleBackColor = false;
            this.free.Click += new System.EventHandler(this.free_Click);
            // 
            // wall
            // 
            this.wall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wall.BackColor = System.Drawing.Color.Black;
            this.wall.Location = new System.Drawing.Point(872, 431);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(30, 30);
            this.wall.TabIndex = 4;
            this.wall.UseVisualStyleBackColor = false;
            this.wall.Click += new System.EventHandler(this.wall_Click);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.player.BackColor = System.Drawing.Color.Blue;
            this.player.Location = new System.Drawing.Point(872, 467);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.TabIndex = 3;
            this.player.UseVisualStyleBackColor = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(927, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Free";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(927, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wall";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(927, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(927, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Point";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(927, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "OnPoint";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(927, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Item";
            // 
            // selectedColorButton
            // 
            this.selectedColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedColorButton.BackColor = System.Drawing.Color.White;
            this.selectedColorButton.Location = new System.Drawing.Point(845, 12);
            this.selectedColorButton.Name = "selectedColorButton";
            this.selectedColorButton.Size = new System.Drawing.Size(30, 30);
            this.selectedColorButton.TabIndex = 12;
            this.selectedColorButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(896, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Selected Color";
            // 
            // finish
            // 
            this.finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.finish.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish.Location = new System.Drawing.Point(12, 579);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 14;
            this.finish.Text = "Finsih";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 615);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedColorButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.free);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.player);
            this.Controls.Add(this.point);
            this.Controls.Add(this.onPoint);
            this.Controls.Add(this.item);
            this.Name = "GridForm";
            this.Text = "GridForm";
            this.Load += new System.EventHandler(this.GridForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button item;
        private System.Windows.Forms.Button onPoint;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button free;
        private System.Windows.Forms.Button wall;
        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selectedColorButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button finish;
    }
}