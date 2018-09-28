namespace WindowsFormsApp1
{
    partial class frmMatchMaker
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
            this.cmdCreatePerson = new System.Windows.Forms.Button();
            this.grpBTools = new System.Windows.Forms.GroupBox();
            this.cmdGenerateGroups = new System.Windows.Forms.Button();
            this.cmdPrintGroups = new System.Windows.Forms.Button();
            this.grpBGroups = new System.Windows.Forms.GroupBox();
            this.grpBTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCreatePerson
            // 
            this.cmdCreatePerson.Location = new System.Drawing.Point(43, 28);
            this.cmdCreatePerson.Name = "cmdCreatePerson";
            this.cmdCreatePerson.Size = new System.Drawing.Size(105, 56);
            this.cmdCreatePerson.TabIndex = 0;
            this.cmdCreatePerson.Text = "Create Person";
            this.cmdCreatePerson.UseVisualStyleBackColor = true;
            // 
            // grpBTools
            // 
            this.grpBTools.Controls.Add(this.cmdPrintGroups);
            this.grpBTools.Controls.Add(this.cmdGenerateGroups);
            this.grpBTools.Controls.Add(this.cmdCreatePerson);
            this.grpBTools.Location = new System.Drawing.Point(588, 28);
            this.grpBTools.Name = "grpBTools";
            this.grpBTools.Size = new System.Drawing.Size(200, 243);
            this.grpBTools.TabIndex = 1;
            this.grpBTools.TabStop = false;
            this.grpBTools.Text = "Tools";
            this.grpBTools.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdGenerateGroups
            // 
            this.cmdGenerateGroups.Location = new System.Drawing.Point(43, 90);
            this.cmdGenerateGroups.Name = "cmdGenerateGroups";
            this.cmdGenerateGroups.Size = new System.Drawing.Size(103, 59);
            this.cmdGenerateGroups.TabIndex = 1;
            this.cmdGenerateGroups.Text = "Generate Groups";
            this.cmdGenerateGroups.UseVisualStyleBackColor = true;
            // 
            // cmdPrintGroups
            // 
            this.cmdPrintGroups.Location = new System.Drawing.Point(43, 166);
            this.cmdPrintGroups.Name = "cmdPrintGroups";
            this.cmdPrintGroups.Size = new System.Drawing.Size(103, 59);
            this.cmdPrintGroups.TabIndex = 2;
            this.cmdPrintGroups.Text = "Print Groups";
            this.cmdPrintGroups.UseVisualStyleBackColor = true;
            // 
            // grpBGroups
            // 
            this.grpBGroups.Location = new System.Drawing.Point(41, 28);
            this.grpBGroups.Name = "grpBGroups";
            this.grpBGroups.Size = new System.Drawing.Size(530, 362);
            this.grpBGroups.TabIndex = 2;
            this.grpBGroups.TabStop = false;
            this.grpBGroups.Text = "Groups";
            // 
            // frmMatchMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBGroups);
            this.Controls.Add(this.grpBTools);
            this.Name = "frmMatchMaker";
            this.Text = "Match Maker";
            this.grpBTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCreatePerson;
        private System.Windows.Forms.GroupBox grpBTools;
        private System.Windows.Forms.Button cmdPrintGroups;
        private System.Windows.Forms.Button cmdGenerateGroups;
        private System.Windows.Forms.GroupBox grpBGroups;
    }
}

