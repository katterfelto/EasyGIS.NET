namespace EGIS.Controls
{
    partial class CsvToShapeFileControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbXCoordField = new System.Windows.Forms.ComboBox();
            this.cbYCoordField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseShapeFile = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            this.sfdShapeFile = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-Coord Field";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(171, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y-Coord Field";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbXCoordField
            // 
            this.cbXCoordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbXCoordField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXCoordField.FormattingEnabled = true;
            this.cbXCoordField.Location = new System.Drawing.Point(3, 16);
            this.cbXCoordField.Name = "cbXCoordField";
            this.cbXCoordField.Size = new System.Drawing.Size(162, 21);
            this.cbXCoordField.TabIndex = 2;
            this.cbXCoordField.SelectedIndexChanged += new System.EventHandler(this.cbXCoordField_SelectedIndexChanged);
            // 
            // cbYCoordField
            // 
            this.cbYCoordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbYCoordField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYCoordField.FormattingEnabled = true;
            this.cbYCoordField.Location = new System.Drawing.Point(171, 16);
            this.cbYCoordField.Name = "cbYCoordField";
            this.cbYCoordField.Size = new System.Drawing.Size(163, 21);
            this.cbYCoordField.TabIndex = 3;
            this.cbYCoordField.SelectedIndexChanged += new System.EventHandler(this.cbYCoordField_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source File";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(69, 3);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(190, 20);
            this.txtSource.TabIndex = 5;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSource.Location = new System.Drawing.Point(265, 3);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 6;
            this.btnBrowseSource.Text = "Browse..";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // btnBrowseShapeFile
            // 
            this.btnBrowseShapeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseShapeFile.Location = new System.Drawing.Point(265, 32);
            this.btnBrowseShapeFile.Name = "btnBrowseShapeFile";
            this.btnBrowseShapeFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseShapeFile.TabIndex = 9;
            this.btnBrowseShapeFile.Text = "Browse..";
            this.btnBrowseShapeFile.UseVisualStyleBackColor = true;
            this.btnBrowseShapeFile.Click += new System.EventHandler(this.btnBrowseShapeFile_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Location = new System.Drawing.Point(69, 32);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(190, 20);
            this.txtDestination.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destination";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(112, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 23);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ofdCsv
            // 
            this.ofdCsv.Filter = "csv files(*.csv)|*.csv|All files(*.*)|*.*";
            // 
            // sfdShapeFile
            // 
            this.sfdShapeFile.Filter = "ShapeFile(*.shp)|*.shp";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseSource, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseShapeFile, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSource, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDestination, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 139);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnConvert, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 29);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbYCoordField, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbXCoordField, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(337, 40);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // CsvToShapeFileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CsvToShapeFileControl";
            this.Size = new System.Drawing.Size(343, 139);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbXCoordField;
        private System.Windows.Forms.ComboBox cbYCoordField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnBrowseShapeFile;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
        private System.Windows.Forms.SaveFileDialog sfdShapeFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
