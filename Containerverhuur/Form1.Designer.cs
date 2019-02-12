namespace Containerverhuur
{
    partial class Form1
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.labelDistance = new System.Windows.Forms.Label();
            this.panelMilages = new System.Windows.Forms.Panel();
            this.labelCollect1 = new System.Windows.Forms.Label();
            this.panelSelection = new System.Windows.Forms.Panel();
            this.checkBoxRegularCustomer = new System.Windows.Forms.CheckBox();
            this.panelPrices = new System.Windows.Forms.Panel();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.panelSubscriptions = new System.Windows.Forms.Panel();
            this.labelSubscription1 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.numericUpDownMonth1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth2 = new System.Windows.Forms.NumericUpDown();
            this.panelDay = new System.Windows.Forms.Panel();
            this.numericUpDownDay1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay2 = new System.Windows.Forms.NumericUpDown();
            this.panelYear = new System.Windows.Forms.Panel();
            this.numericUpDownYear1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear2 = new System.Windows.Forms.NumericUpDown();
            this.panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            this.panelMilages.SuspendLayout();
            this.panelSelection.SuspendLayout();
            this.panelPrices.SuspendLayout();
            this.panelSubscriptions.SuspendLayout();
            this.panelMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth2)).BeginInit();
            this.panelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay2)).BeginInit();
            this.panelYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.panelMonth);
            this.panelLayout.Controls.Add(this.labelCustomer);
            this.panelLayout.Controls.Add(this.panelDay);
            this.panelLayout.Controls.Add(this.numericUpDownVolume);
            this.panelLayout.Controls.Add(this.panelYear);
            this.panelLayout.Controls.Add(this.labelDistance);
            this.panelLayout.Controls.Add(this.panelMilages);
            this.panelLayout.Controls.Add(this.panelSelection);
            this.panelLayout.Controls.Add(this.panelPrices);
            this.panelLayout.Controls.Add(this.panelSubscriptions);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(561, 209);
            this.panelLayout.TabIndex = 27;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(7, 44);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(13, 17);
            this.labelCustomer.TabIndex = 58;
            this.labelCustomer.Text = "-";
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Location = new System.Drawing.Point(140, 84);
            this.numericUpDownVolume.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.ReadOnly = true;
            this.numericUpDownVolume.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownVolume.TabIndex = 57;
            this.numericUpDownVolume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(10, 86);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(59, 17);
            this.labelDistance.TabIndex = 56;
            this.labelDistance.Text = "Inhoud :";
            // 
            // panelMilages
            // 
            this.panelMilages.Controls.Add(this.labelCollect1);
            this.panelMilages.Location = new System.Drawing.Point(191, 3);
            this.panelMilages.Name = "panelMilages";
            this.panelMilages.Size = new System.Drawing.Size(45, 22);
            this.panelMilages.TabIndex = 54;
            // 
            // labelCollect1
            // 
            this.labelCollect1.AutoSize = true;
            this.labelCollect1.Location = new System.Drawing.Point(4, 3);
            this.labelCollect1.Name = "labelCollect1";
            this.labelCollect1.Size = new System.Drawing.Size(13, 17);
            this.labelCollect1.TabIndex = 6;
            this.labelCollect1.Text = "-";
            // 
            // panelSelection
            // 
            this.panelSelection.Controls.Add(this.checkBoxRegularCustomer);
            this.panelSelection.Location = new System.Drawing.Point(53, 44);
            this.panelSelection.Name = "panelSelection";
            this.panelSelection.Size = new System.Drawing.Size(22, 23);
            this.panelSelection.TabIndex = 54;
            // 
            // checkBoxRegularCustomer
            // 
            this.checkBoxRegularCustomer.AutoSize = true;
            this.checkBoxRegularCustomer.Location = new System.Drawing.Point(3, 1);
            this.checkBoxRegularCustomer.Name = "checkBoxRegularCustomer";
            this.checkBoxRegularCustomer.Size = new System.Drawing.Size(18, 17);
            this.checkBoxRegularCustomer.TabIndex = 58;
            this.checkBoxRegularCustomer.UseVisualStyleBackColor = true;
            // 
            // panelPrices
            // 
            this.panelPrices.Controls.Add(this.labelPrice1);
            this.panelPrices.Location = new System.Drawing.Point(140, 4);
            this.panelPrices.Name = "panelPrices";
            this.panelPrices.Size = new System.Drawing.Size(45, 21);
            this.panelPrices.TabIndex = 53;
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Location = new System.Drawing.Point(4, 3);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(13, 17);
            this.labelPrice1.TabIndex = 6;
            this.labelPrice1.Text = "-";
            // 
            // panelSubscriptions
            // 
            this.panelSubscriptions.Controls.Add(this.labelSubscription1);
            this.panelSubscriptions.Location = new System.Drawing.Point(3, 3);
            this.panelSubscriptions.Name = "panelSubscriptions";
            this.panelSubscriptions.Size = new System.Drawing.Size(131, 22);
            this.panelSubscriptions.TabIndex = 52;
            // 
            // labelSubscription1
            // 
            this.labelSubscription1.AutoSize = true;
            this.labelSubscription1.Location = new System.Drawing.Point(4, 4);
            this.labelSubscription1.Name = "labelSubscription1";
            this.labelSubscription1.Size = new System.Drawing.Size(13, 17);
            this.labelSubscription1.TabIndex = 6;
            this.labelSubscription1.Text = "-";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(462, 172);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(3, 155);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(3, 172);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.numericUpDownMonth1);
            this.panelMonth.Controls.Add(this.numericUpDownMonth2);
            this.panelMonth.Location = new System.Drawing.Point(420, 4);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(47, 56);
            this.panelMonth.TabIndex = 31;
            // 
            // numericUpDownMonth1
            // 
            this.numericUpDownMonth1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownMonth1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth1.Name = "numericUpDownMonth1";
            this.numericUpDownMonth1.ReadOnly = true;
            this.numericUpDownMonth1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth1.TabIndex = 25;
            this.numericUpDownMonth1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMonth2
            // 
            this.numericUpDownMonth2.Location = new System.Drawing.Point(0, 31);
            this.numericUpDownMonth2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth2.Name = "numericUpDownMonth2";
            this.numericUpDownMonth2.ReadOnly = true;
            this.numericUpDownMonth2.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth2.TabIndex = 28;
            this.numericUpDownMonth2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.numericUpDownDay1);
            this.panelDay.Controls.Add(this.numericUpDownDay2);
            this.panelDay.Location = new System.Drawing.Point(345, 4);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(47, 56);
            this.panelDay.TabIndex = 32;
            // 
            // numericUpDownDay1
            // 
            this.numericUpDownDay1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDay1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay1.Name = "numericUpDownDay1";
            this.numericUpDownDay1.ReadOnly = true;
            this.numericUpDownDay1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay1.TabIndex = 26;
            this.numericUpDownDay1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDay2
            // 
            this.numericUpDownDay2.Location = new System.Drawing.Point(0, 31);
            this.numericUpDownDay2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay2.Name = "numericUpDownDay2";
            this.numericUpDownDay2.ReadOnly = true;
            this.numericUpDownDay2.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay2.TabIndex = 29;
            this.numericUpDownDay2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.numericUpDownYear1);
            this.panelYear.Controls.Add(this.numericUpDownYear2);
            this.panelYear.Location = new System.Drawing.Point(494, 3);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(67, 57);
            this.panelYear.TabIndex = 30;
            // 
            // numericUpDownYear1
            // 
            this.numericUpDownYear1.Location = new System.Drawing.Point(1, 1);
            this.numericUpDownYear1.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear1.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear1.Name = "numericUpDownYear1";
            this.numericUpDownYear1.ReadOnly = true;
            this.numericUpDownYear1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear1.TabIndex = 24;
            this.numericUpDownYear1.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // numericUpDownYear2
            // 
            this.numericUpDownYear2.Location = new System.Drawing.Point(1, 32);
            this.numericUpDownYear2.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear2.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear2.Name = "numericUpDownYear2";
            this.numericUpDownYear2.ReadOnly = true;
            this.numericUpDownYear2.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear2.TabIndex = 27;
            this.numericUpDownYear2.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            this.panelMilages.ResumeLayout(false);
            this.panelMilages.PerformLayout();
            this.panelSelection.ResumeLayout(false);
            this.panelSelection.PerformLayout();
            this.panelPrices.ResumeLayout(false);
            this.panelPrices.PerformLayout();
            this.panelSubscriptions.ResumeLayout(false);
            this.panelSubscriptions.PerformLayout();
            this.panelMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth2)).EndInit();
            this.panelDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay2)).EndInit();
            this.panelYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Panel panelMilages;
        private System.Windows.Forms.Label labelCollect1;
        private System.Windows.Forms.Panel panelSelection;
        private System.Windows.Forms.Panel panelPrices;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Panel panelSubscriptions;
        private System.Windows.Forms.Label labelSubscription1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.CheckBox checkBoxRegularCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth1;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth2;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.NumericUpDown numericUpDownDay1;
        private System.Windows.Forms.NumericUpDown numericUpDownDay2;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.NumericUpDown numericUpDownYear1;
        private System.Windows.Forms.NumericUpDown numericUpDownYear2;
    }
}

