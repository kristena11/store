namespace GatesCandy
{
    partial class LollipopForm
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
            this.nameLable = new System.Windows.Forms.Label();
            this.flavorSelection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLollipopSelection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.flavorSelectionL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLable.Location = new System.Drawing.Point(160, 229);
            this.nameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(124, 31);
            this.nameLable.TabIndex = 3;
            this.nameLable.Text = "selected:";
            // 
            // flavorSelection
            // 
            this.flavorSelection.AutoSize = true;
            this.flavorSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flavorSelection.Location = new System.Drawing.Point(363, 229);
            this.flavorSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flavorSelection.Name = "flavorSelection";
            this.flavorSelection.Size = new System.Drawing.Size(0, 31);
            this.flavorSelection.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(160, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pick the chocolate flavor you want :";
            // 
            // comboBoxLollipopSelection
            // 
            this.comboBoxLollipopSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxLollipopSelection.FormattingEnabled = true;
            this.comboBoxLollipopSelection.Items.AddRange(new object[] {
            "Cherry",
            "Lime",
            "Strawberry"});
            this.comboBoxLollipopSelection.Location = new System.Drawing.Point(167, 150);
            this.comboBoxLollipopSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLollipopSelection.Name = "comboBoxLollipopSelection";
            this.comboBoxLollipopSelection.Size = new System.Drawing.Size(375, 39);
            this.comboBoxLollipopSelection.TabIndex = 10;
            this.comboBoxLollipopSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxLollipopSelection_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(160, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(167, 396);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 38);
            this.numericUpDown1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(167, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 58);
            this.button1.TabIndex = 13;
            this.button1.Text = "Return to Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flavorSelectionL
            // 
            this.flavorSelectionL.AutoSize = true;
            this.flavorSelectionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flavorSelectionL.Location = new System.Drawing.Point(363, 229);
            this.flavorSelectionL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flavorSelectionL.Name = "flavorSelectionL";
            this.flavorSelectionL.Size = new System.Drawing.Size(103, 31);
            this.flavorSelectionL.TabIndex = 14;
            this.flavorSelectionL.Text = "nothing";
            // 
            // LollipopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 679);
            this.Controls.Add(this.flavorSelectionL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLollipopSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flavorSelection);
            this.Controls.Add(this.nameLable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LollipopForm";
            this.Text = "Lollipops";
            this.Load += new System.EventHandler(this.LollipopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label flavorSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLollipopSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label flavorSelectionL;
    }
}