
namespace TagWall.core
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTextType = new System.Windows.Forms.ComboBox();
            this.chbFunction = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.chbThickness = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDecimals = new System.Windows.Forms.ComboBox();
            this.cbUnits = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTextType);
            this.groupBox1.Controls.Add(this.chbFunction);
            this.groupBox1.Controls.Add(this.chbName);
            this.groupBox1.Controls.Add(this.chbThickness);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Annotate Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text Type";
            // 
            // cbTextType
            // 
            this.cbTextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextType.FormattingEnabled = true;
            this.cbTextType.Location = new System.Drawing.Point(6, 116);
            this.cbTextType.Name = "cbTextType";
            this.cbTextType.Size = new System.Drawing.Size(362, 21);
            this.cbTextType.TabIndex = 3;
            this.cbTextType.SelectedIndexChanged += new System.EventHandler(this.cbTextType_SelectedIndexChanged);
            // 
            // chbFunction
            // 
            this.chbFunction.AutoSize = true;
            this.chbFunction.Checked = true;
            this.chbFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFunction.Location = new System.Drawing.Point(6, 65);
            this.chbFunction.Name = "chbFunction";
            this.chbFunction.Size = new System.Drawing.Size(67, 17);
            this.chbFunction.TabIndex = 2;
            this.chbFunction.Text = "Function";
            this.chbFunction.UseVisualStyleBackColor = true;
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Checked = true;
            this.chbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbName.Location = new System.Drawing.Point(6, 42);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(54, 17);
            this.chbName.TabIndex = 1;
            this.chbName.Text = "Name";
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // chbThickness
            // 
            this.chbThickness.AutoSize = true;
            this.chbThickness.Checked = true;
            this.chbThickness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbThickness.Location = new System.Drawing.Point(6, 19);
            this.chbThickness.Name = "chbThickness";
            this.chbThickness.Size = new System.Drawing.Size(75, 17);
            this.chbThickness.TabIndex = 0;
            this.chbThickness.Text = "Thickness";
            this.chbThickness.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(209, 308);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbDecimals);
            this.groupBox2.Controls.Add(this.cbUnits);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Units Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Decimals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Units";
            // 
            // cbDecimals
            // 
            this.cbDecimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDecimals.FormattingEnabled = true;
            this.cbDecimals.Location = new System.Drawing.Point(5, 85);
            this.cbDecimals.Name = "cbDecimals";
            this.cbDecimals.Size = new System.Drawing.Size(362, 21);
            this.cbDecimals.TabIndex = 0;
            this.cbDecimals.SelectedIndexChanged += new System.EventHandler(this.cbDecimals_SelectedIndexChanged);
            // 
            // cbUnits
            // 
            this.cbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnits.FormattingEnabled = true;
            this.cbUnits.Location = new System.Drawing.Point(5, 37);
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.Size = new System.Drawing.Size(362, 21);
            this.cbUnits.TabIndex = 0;
            this.cbUnits.SelectedIndexChanged += new System.EventHandler(this.cbUnits_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 378);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 378);
            this.Name = "Form1";
            this.Text = "Tag Wall";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTextType;
        private System.Windows.Forms.CheckBox chbFunction;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.CheckBox chbThickness;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDecimals;
        private System.Windows.Forms.ComboBox cbUnits;
    }
}