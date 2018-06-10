namespace GatesCandy
{
    partial class GumForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGumSelection = new System.Windows.Forms.ComboBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3Gum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(116, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pick the chocolate flavor you want :";
            // 
            // comboBoxGumSelection
            // 
            this.comboBoxGumSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxGumSelection.FormattingEnabled = true;
            this.comboBoxGumSelection.Items.AddRange(new object[] {
            "Bubble Gum",
            "Mint",
            "Watermelon"});
            this.comboBoxGumSelection.Location = new System.Drawing.Point(121, 139);
            this.comboBoxGumSelection.Name = "comboBoxGumSelection";
            this.comboBoxGumSelection.Size = new System.Drawing.Size(282, 33);
            this.comboBoxGumSelection.TabIndex = 11;
            this.comboBoxGumSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxGumSelection_SelectedIndexChanged);
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLable.Location = new System.Drawing.Point(116, 213);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(91, 25);
            this.nameLable.TabIndex = 12;
            this.nameLable.Text = "selected:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(116, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(121, 333);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Click += button1_Click;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(121, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Return to Main";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3Gum
            // 
            this.label3Gum.AutoSize = true;
            this.label3Gum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3Gum.Location = new System.Drawing.Point(290, 213);
            this.label3Gum.Name = "label3Gum";
            this.label3Gum.Size = new System.Drawing.Size(76, 25);
            this.label3Gum.TabIndex = 17;
            this.label3Gum.Text = "nothing";
            // 
            // GumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 561);
            this.Controls.Add(this.label3Gum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.comboBoxGumSelection);
            this.Controls.Add(this.label2);
            this.Name = "GumForm";
            this.Text = "Gum";
            this.Load += new System.EventHandler(this.GumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGumSelection;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3Gum;
    }
}