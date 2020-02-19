namespace ISYS3393Homework3
{
    partial class FlowerShop
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
            this.picBoxAd = new System.Windows.Forms.PictureBox();
            this.grpBoxFlowers = new System.Windows.Forms.GroupBox();
            this.rdoBtnTulips = new System.Windows.Forms.RadioButton();
            this.rdoBtnDaisies = new System.Windows.Forms.RadioButton();
            this.rdoBtnLilies = new System.Windows.Forms.RadioButton();
            this.rdoBtnOrchids = new System.Windows.Forms.RadioButton();
            this.rdoBtnRose = new System.Windows.Forms.RadioButton();
            this.picBoxFlower = new System.Windows.Forms.PictureBox();
            this.chkBoxPictureEnable = new System.Windows.Forms.CheckBox();
            this.lstBoxOccasions = new System.Windows.Forms.ListBox();
            this.txtBoxAddItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAd)).BeginInit();
            this.grpBoxFlowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlower)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAd
            // 
            this.picBoxAd.Image = global::ISYS3393Homework3.Properties.Resources.Ad;
            this.picBoxAd.Location = new System.Drawing.Point(10, 10);
            this.picBoxAd.Name = "picBoxAd";
            this.picBoxAd.Size = new System.Drawing.Size(540, 200);
            this.picBoxAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAd.TabIndex = 0;
            this.picBoxAd.TabStop = false;
            // 
            // grpBoxFlowers
            // 
            this.grpBoxFlowers.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxFlowers.Controls.Add(this.rdoBtnTulips);
            this.grpBoxFlowers.Controls.Add(this.rdoBtnDaisies);
            this.grpBoxFlowers.Controls.Add(this.rdoBtnLilies);
            this.grpBoxFlowers.Controls.Add(this.rdoBtnOrchids);
            this.grpBoxFlowers.Controls.Add(this.rdoBtnRose);
            this.grpBoxFlowers.Location = new System.Drawing.Point(12, 216);
            this.grpBoxFlowers.Name = "grpBoxFlowers";
            this.grpBoxFlowers.Size = new System.Drawing.Size(149, 170);
            this.grpBoxFlowers.TabIndex = 1;
            this.grpBoxFlowers.TabStop = false;
            this.grpBoxFlowers.Text = "Flowers";
            // 
            // rdoBtnTulips
            // 
            this.rdoBtnTulips.AutoSize = true;
            this.rdoBtnTulips.Location = new System.Drawing.Point(10, 140);
            this.rdoBtnTulips.Name = "rdoBtnTulips";
            this.rdoBtnTulips.Size = new System.Drawing.Size(53, 17);
            this.rdoBtnTulips.TabIndex = 4;
            this.rdoBtnTulips.TabStop = true;
            this.rdoBtnTulips.Text = "Tulips";
            this.rdoBtnTulips.UseVisualStyleBackColor = true;
            this.rdoBtnLilies.CheckedChanged += RdoBtn_CheckedChanged;
            // 
            // rdoBtnDaisies
            // 
            this.rdoBtnDaisies.AutoSize = true;
            this.rdoBtnDaisies.Location = new System.Drawing.Point(10, 110);
            this.rdoBtnDaisies.Name = "rdoBtnDaisies";
            this.rdoBtnDaisies.Size = new System.Drawing.Size(59, 17);
            this.rdoBtnDaisies.TabIndex = 3;
            this.rdoBtnDaisies.TabStop = true;
            this.rdoBtnDaisies.Text = "Daisies";
            this.rdoBtnDaisies.UseVisualStyleBackColor = true;
            this.rdoBtnDaisies.CheckedChanged += RdoBtn_CheckedChanged;
            // 
            // rdoBtnLilies
            // 
            this.rdoBtnLilies.AutoSize = true;
            this.rdoBtnLilies.Location = new System.Drawing.Point(10, 80);
            this.rdoBtnLilies.Name = "rdoBtnLilies";
            this.rdoBtnLilies.Size = new System.Drawing.Size(48, 17);
            this.rdoBtnLilies.TabIndex = 2;
            this.rdoBtnLilies.TabStop = true;
            this.rdoBtnLilies.Text = "Lilies";
            this.rdoBtnLilies.UseVisualStyleBackColor = true;
            this.rdoBtnLilies.CheckedChanged += RdoBtn_CheckedChanged;
            // 
            // rdoBtnOrchids
            // 
            this.rdoBtnOrchids.AutoSize = true;
            this.rdoBtnOrchids.Location = new System.Drawing.Point(10, 50);
            this.rdoBtnOrchids.Name = "rdoBtnOrchids";
            this.rdoBtnOrchids.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnOrchids.TabIndex = 1;
            this.rdoBtnOrchids.TabStop = true;
            this.rdoBtnOrchids.Text = "Orchids";
            this.rdoBtnOrchids.UseVisualStyleBackColor = true;
            this.rdoBtnOrchids.CheckedChanged += RdoBtn_CheckedChanged;
            // 
            // rdoBtnRose
            // 
            this.rdoBtnRose.AutoSize = true;
            this.rdoBtnRose.Location = new System.Drawing.Point(10, 20);
            this.rdoBtnRose.Name = "rdoBtnRose";
            this.rdoBtnRose.Size = new System.Drawing.Size(55, 17);
            this.rdoBtnRose.TabIndex = 0;
            this.rdoBtnRose.TabStop = true;
            this.rdoBtnRose.Text = "Roses";
            this.rdoBtnRose.UseVisualStyleBackColor = true;
            this.rdoBtnRose.CheckedChanged += RdoBtn_CheckedChanged;
            // 
            // pictureBox1
            // 
            this.picBoxFlower.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFlower.Visible = false;
            this.picBoxFlower.Location = new System.Drawing.Point(179, 222);
            this.picBoxFlower.Name = "picBoxFlower";
            this.picBoxFlower.Size = new System.Drawing.Size(120, 120);
            this.picBoxFlower.TabIndex = 5;
            this.picBoxFlower.TabStop = false;
            
            // 
            // chkBoxPictureEnable
            // 
            this.chkBoxPictureEnable.AutoSize = true;
            this.chkBoxPictureEnable.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxPictureEnable.Location = new System.Drawing.Point(179, 357);
            this.chkBoxPictureEnable.Name = "chkBoxPictureEnable";
            this.chkBoxPictureEnable.Size = new System.Drawing.Size(89, 17);
            this.chkBoxPictureEnable.TabIndex = 6;
            this.chkBoxPictureEnable.Text = "Show Picture";
            this.chkBoxPictureEnable.UseVisualStyleBackColor = false;
            this.chkBoxPictureEnable.CheckedChanged += new System.EventHandler(this.chkBoxPictureEnable_CheckedChanged);
            // 
            // lstBoxOccasions
            // 
            this.lstBoxOccasions.FormattingEnabled = true;
            this.lstBoxOccasions.Location = new System.Drawing.Point(325, 239);
            this.lstBoxOccasions.Name = "lstBoxOccasions";
            this.lstBoxOccasions.Size = new System.Drawing.Size(120, 147);
            this.lstBoxOccasions.TabIndex = 7;
            // 
            // txtBoxAddItem
            // 
            this.txtBoxAddItem.Location = new System.Drawing.Point(325, 220);
            this.txtBoxAddItem.Name = "txtBoxAddItem";
            this.txtBoxAddItem.Size = new System.Drawing.Size(120, 20);
            this.txtBoxAddItem.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(475, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseUp += BtnAdd_MouseUp;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(475, 290);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 10;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.MouseUp += BtnTotal_MouseUp;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(475, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.MouseUp += BtnDelete_MouseUp;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(40, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.MouseUp += BtnClear_MouseUp;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(140, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseUp += BtnExit_MouseUp;
            // 
            // FlowerShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISYS3393Homework3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(559, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAddItem);
            this.Controls.Add(this.lstBoxOccasions);
            this.Controls.Add(this.chkBoxPictureEnable);
            this.Controls.Add(this.picBoxFlower);
            this.Controls.Add(this.grpBoxFlowers);
            this.Controls.Add(this.picBoxAd);
            this.Name = "FlowerShop";
            this.Text = "Flower Shop";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAd)).EndInit();
            this.grpBoxFlowers.ResumeLayout(false);
            this.grpBoxFlowers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public string GetListSelectedItem()
        {
            if (lstBoxOccasions.SelectedIndex < 0)
                return "-1";
            else
                return lstBoxOccasions.SelectedItem.ToString();
        }

        public void ClearSelection()
        {
            lstBoxOccasions.SelectedItem = null;
        }

        public void ClearTextBox()
        {
            txtBoxAddItem.Clear();
        }

        public string GetTextBox()
        {
            return txtBoxAddItem.Text;
        }

        public void SetChecked(bool set)
        {
            chkBoxPictureEnable.Checked = set;
        }

        public bool GetChecked()
        {
            return chkBoxPictureEnable.Checked;
        }

        public string GetTxtBoxAddItem()
        {
            return txtBoxAddItem.Text;
        }

        public void SetPhotoBoxVisible(bool value)
        {
            picBoxFlower.Visible = value;
        }

        public void SetPhoto(System.Drawing.Image image)
        {
            picBoxFlower.Image = image;
        }

        public void SetOccasions(string[] occasions)
        {
            lstBoxOccasions.Items.Clear();
            for(int i = 0; i < occasions.Length; i++)
            {
                if(!occasions[i].Equals(""))
                    lstBoxOccasions.Items.Add(occasions[i]);
            }   
        }

        public System.Windows.Forms.GroupBox GetGroupBox()
        {
            return grpBoxFlowers;
        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAd;
        private System.Windows.Forms.GroupBox grpBoxFlowers;
        private System.Windows.Forms.RadioButton rdoBtnTulips;
        private System.Windows.Forms.RadioButton rdoBtnDaisies;
        private System.Windows.Forms.RadioButton rdoBtnLilies;
        private System.Windows.Forms.RadioButton rdoBtnOrchids;
        private System.Windows.Forms.RadioButton rdoBtnRose;
        private System.Windows.Forms.PictureBox picBoxFlower;
        private System.Windows.Forms.CheckBox chkBoxPictureEnable;
        private System.Windows.Forms.ListBox lstBoxOccasions;
        private System.Windows.Forms.TextBox txtBoxAddItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

