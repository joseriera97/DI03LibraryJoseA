namespace LibraryJose
{
    partial class UserImageProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageProductPictureBox = new System.Windows.Forms.PictureBox();
            this.sizeProductFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.precioMinimoLabel = new System.Windows.Forms.Label();
            this.idSizeProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageProductPictureBox
            // 
            this.imageProductPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageProductPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageProductPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageProductPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageProductPictureBox.Location = new System.Drawing.Point(108, 52);
            this.imageProductPictureBox.Name = "imageProductPictureBox";
            this.imageProductPictureBox.Size = new System.Drawing.Size(178, 218);
            this.imageProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageProductPictureBox.TabIndex = 0;
            this.imageProductPictureBox.TabStop = false;
            this.imageProductPictureBox.Click += new System.EventHandler(this.imageProductPictureBox_Click);
            this.imageProductPictureBox.MouseHover += new System.EventHandler(this.imageProduct_MouseEnter);
            // 
            // sizeProductFlowLayoutPanel
            // 
            this.sizeProductFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeProductFlowLayoutPanel.Location = new System.Drawing.Point(17, 288);
            this.sizeProductFlowLayoutPanel.Name = "sizeProductFlowLayoutPanel";
            this.sizeProductFlowLayoutPanel.Size = new System.Drawing.Size(361, 100);
            this.sizeProductFlowLayoutPanel.TabIndex = 1;
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameProductTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.nameProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProductTextBox.Location = new System.Drawing.Point(17, 11);
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.ReadOnly = true;
            this.nameProductTextBox.Size = new System.Drawing.Size(361, 35);
            this.nameProductTextBox.TabIndex = 2;
            // 
            // precioMinimoLabel
            // 
            this.precioMinimoLabel.AutoSize = true;
            this.precioMinimoLabel.Location = new System.Drawing.Point(310, 234);
            this.precioMinimoLabel.Name = "precioMinimoLabel";
            this.precioMinimoLabel.Size = new System.Drawing.Size(35, 13);
            this.precioMinimoLabel.TabIndex = 4;
            this.precioMinimoLabel.Text = "label1";
            // 
            // idSizeProductLabel
            // 
            this.idSizeProductLabel.AutoSize = true;
            this.idSizeProductLabel.Location = new System.Drawing.Point(310, 272);
            this.idSizeProductLabel.Name = "idSizeProductLabel";
            this.idSizeProductLabel.Size = new System.Drawing.Size(35, 13);
            this.idSizeProductLabel.TabIndex = 5;
            this.idSizeProductLabel.Text = "label1";
            // 
            // UserImageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.idSizeProductLabel);
            this.Controls.Add(this.precioMinimoLabel);
            this.Controls.Add(this.nameProductTextBox);
            this.Controls.Add(this.sizeProductFlowLayoutPanel);
            this.Controls.Add(this.imageProductPictureBox);
            this.Name = "UserImageProduct";
            this.Size = new System.Drawing.Size(400, 399);
            this.Load += new System.EventHandler(this.UserImageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageProductPictureBox;
        private System.Windows.Forms.FlowLayoutPanel sizeProductFlowLayoutPanel;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.Label precioMinimoLabel;
        private System.Windows.Forms.Label idSizeProductLabel;
    }
}
