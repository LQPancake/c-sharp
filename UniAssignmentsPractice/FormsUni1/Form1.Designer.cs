namespace FormsUni1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelDesignationOutput = new System.Windows.Forms.Label();
            this.labelCityOutput = new System.Windows.Forms.Label();
            this.labelPostcodeOutput = new System.Windows.Forms.Label();
            this.labelAddressOutput = new System.Windows.Forms.Label();
            this.labelDobOutput = new System.Windows.Forms.Label();
            this.labelNameOutput = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Gotham’s Best Visiting Card Maker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(6, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDob.Location = new System.Drawing.Point(6, 46);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(106, 20);
            this.labelDob.TabIndex = 2;
            this.labelDob.Text = "Date Of Birth:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddress.Location = new System.Drawing.Point(6, 80);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(120, 20);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Street Address:";
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostcode.Location = new System.Drawing.Point(6, 109);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(87, 20);
            this.labelPostcode.TabIndex = 4;
            this.labelPostcode.Text = "Post Code:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.Location = new System.Drawing.Point(6, 142);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(39, 20);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City:";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDesignation.Location = new System.Drawing.Point(6, 172);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(115, 20);
            this.labelDesignation.TabIndex = 6;
            this.labelDesignation.Text = "Your Specialty:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(51, 142);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 8;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(132, 80);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 8;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Location = new System.Drawing.Point(99, 111);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostcode.TabIndex = 9;
            this.textBoxPostcode.TextChanged += new System.EventHandler(this.textBoxPostcode_TextChanged);
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(127, 172);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesignation.TabIndex = 10;
            this.textBoxDesignation.TextChanged += new System.EventHandler(this.textBoxDesignation_TextChanged);
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Location = new System.Drawing.Point(118, 45);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDob.TabIndex = 11;
            this.dateTimePickerDob.ValueChanged += new System.EventHandler(this.dateTimePickerDob_ValueChanged);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.buttonSubmit);
            this.groupBoxInput.Controls.Add(this.dateTimePickerDob);
            this.groupBoxInput.Controls.Add(this.textBoxDesignation);
            this.groupBoxInput.Controls.Add(this.textBoxPostcode);
            this.groupBoxInput.Controls.Add(this.textBoxAddress);
            this.groupBoxInput.Controls.Add(this.textBoxCity);
            this.groupBoxInput.Controls.Add(this.textBoxName);
            this.groupBoxInput.Controls.Add(this.labelDesignation);
            this.groupBoxInput.Controls.Add(this.labelCity);
            this.groupBoxInput.Controls.Add(this.labelPostcode);
            this.groupBoxInput.Controls.Add(this.labelAddress);
            this.groupBoxInput.Controls.Add(this.labelDob);
            this.groupBoxInput.Controls.Add(this.labelName);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 75);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(434, 254);
            this.groupBoxInput.TabIndex = 12;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(166, 214);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelDesignationOutput);
            this.groupBoxOutput.Controls.Add(this.labelCityOutput);
            this.groupBoxOutput.Controls.Add(this.labelPostcodeOutput);
            this.groupBoxOutput.Controls.Add(this.labelAddressOutput);
            this.groupBoxOutput.Controls.Add(this.labelDobOutput);
            this.groupBoxOutput.Controls.Add(this.labelNameOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(492, 88);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(289, 240);
            this.groupBoxOutput.TabIndex = 13;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // labelDesignationOutput
            // 
            this.labelDesignationOutput.AutoSize = true;
            this.labelDesignationOutput.Location = new System.Drawing.Point(125, 166);
            this.labelDesignationOutput.Name = "labelDesignationOutput";
            this.labelDesignationOutput.Size = new System.Drawing.Size(50, 13);
            this.labelDesignationOutput.TabIndex = 5;
            this.labelDesignationOutput.Text = "Specialty";
            // 
            // labelCityOutput
            // 
            this.labelCityOutput.AutoSize = true;
            this.labelCityOutput.Location = new System.Drawing.Point(125, 136);
            this.labelCityOutput.Name = "labelCityOutput";
            this.labelCityOutput.Size = new System.Drawing.Size(24, 13);
            this.labelCityOutput.TabIndex = 4;
            this.labelCityOutput.Text = "City";
            // 
            // labelPostcodeOutput
            // 
            this.labelPostcodeOutput.AutoSize = true;
            this.labelPostcodeOutput.Location = new System.Drawing.Point(125, 101);
            this.labelPostcodeOutput.Name = "labelPostcodeOutput";
            this.labelPostcodeOutput.Size = new System.Drawing.Size(52, 13);
            this.labelPostcodeOutput.TabIndex = 3;
            this.labelPostcodeOutput.Text = "Postcode";
            // 
            // labelAddressOutput
            // 
            this.labelAddressOutput.AutoSize = true;
            this.labelAddressOutput.Location = new System.Drawing.Point(125, 72);
            this.labelAddressOutput.Name = "labelAddressOutput";
            this.labelAddressOutput.Size = new System.Drawing.Size(45, 13);
            this.labelAddressOutput.TabIndex = 2;
            this.labelAddressOutput.Text = "Address";
            // 
            // labelDobOutput
            // 
            this.labelDobOutput.AutoSize = true;
            this.labelDobOutput.Location = new System.Drawing.Point(125, 40);
            this.labelDobOutput.Name = "labelDobOutput";
            this.labelDobOutput.Size = new System.Drawing.Size(30, 13);
            this.labelDobOutput.TabIndex = 1;
            this.labelDobOutput.Text = "DOB";
            // 
            // labelNameOutput
            // 
            this.labelNameOutput.AutoSize = true;
            this.labelNameOutput.Location = new System.Drawing.Point(125, 16);
            this.labelNameOutput.Name = "labelNameOutput";
            this.labelNameOutput.Size = new System.Drawing.Size(35, 13);
            this.labelNameOutput.TabIndex = 0;
            this.labelNameOutput.Text = "Name";
            this.labelNameOutput.Click += new System.EventHandler(this.labelNameOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelDesignationOutput;
        private System.Windows.Forms.Label labelCityOutput;
        private System.Windows.Forms.Label labelPostcodeOutput;
        private System.Windows.Forms.Label labelAddressOutput;
        private System.Windows.Forms.Label labelDobOutput;
        private System.Windows.Forms.Label labelNameOutput;
    }
}

