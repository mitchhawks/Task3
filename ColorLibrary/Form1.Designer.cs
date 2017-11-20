namespace ColorLibrary
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
            this.lstColors = new System.Windows.Forms.ListView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtHexList = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddColour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHexToAdd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstColors
            // 
            this.lstColors.Location = new System.Drawing.Point(51, 192);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(590, 425);
            this.lstColors.TabIndex = 0;
            this.lstColors.UseCompatibleStateImageBehavior = false;
            this.lstColors.ItemActivate += new System.EventHandler(this.LstColors_ItemActivate);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(51, 660);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(182, 94);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // txtHexList
            // 
            this.txtHexList.Location = new System.Drawing.Point(147, 77);
            this.txtHexList.Name = "txtHexList";
            this.txtHexList.Size = new System.Drawing.Size(189, 38);
            this.txtHexList.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHexList);
            this.groupBox1.Location = new System.Drawing.Point(730, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Colour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hex";
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(459, 660);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(182, 94);
            this.btnSaveJson.TabIndex = 4;
            this.btnSaveJson.Text = "Save";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddColour);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHexToAdd);
            this.groupBox2.Location = new System.Drawing.Point(730, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 220);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Colour";
            // 
            // btnAddColour
            // 
            this.btnAddColour.Location = new System.Drawing.Point(147, 109);
            this.btnAddColour.Name = "btnAddColour";
            this.btnAddColour.Size = new System.Drawing.Size(182, 94);
            this.btnAddColour.TabIndex = 6;
            this.btnAddColour.Text = "Add";
            this.btnAddColour.UseVisualStyleBackColor = true;
            this.btnAddColour.Click += new System.EventHandler(this.btnAddColour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hex";
            // 
            // txtHexToAdd
            // 
            this.txtHexToAdd.Location = new System.Drawing.Point(147, 55);
            this.txtHexToAdd.Name = "txtHexToAdd";
            this.txtHexToAdd.Size = new System.Drawing.Size(189, 38);
            this.txtHexToAdd.TabIndex = 4;
            this.txtHexToAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHexToAdd_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 848);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstColors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstColors;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtHexList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHexToAdd;
    }
}

