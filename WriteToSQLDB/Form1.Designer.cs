namespace WriteToSQLDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableListBox = new System.Windows.Forms.ListBox();
            this.newTableTextBox = new System.Windows.Forms.TextBox();
            this.addTableButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchResultTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchTableButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteIDButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.deleteTableButton = new System.Windows.Forms.Button();
            this.idListBox = new System.Windows.Forms.ListBox();
            this.importIDButton = new System.Windows.Forms.Button();
            this.emptyFieldsButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.sqlDirTextBox = new System.Windows.Forms.TextBox();
            this.changeDirButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(225, 81);
            this.nameTextBox.MaxLength = 80;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(301, 27);
            this.nameTextBox.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.submitButton.Location = new System.Drawing.Point(412, 245);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(114, 27);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Spara i tabell";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adress";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(225, 114);
            this.addressTextBox.MaxLength = 40;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 27);
            this.addressTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Postnr.";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(225, 147);
            this.postalCodeTextBox.MaxLength = 5;
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(301, 27);
            this.postalCodeTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tel.nr";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(225, 213);
            this.phoneTextBox.MaxLength = 40;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(301, 27);
            this.phoneTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(225, 180);
            this.cityTextBox.MaxLength = 40;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(301, 27);
            this.cityTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ort";
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageBox.Location = new System.Drawing.Point(12, 410);
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(703, 79);
            this.messageBox.TabIndex = 11;
            this.messageBox.TabStop = false;
            this.messageBox.Text = "";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Statusmeddelanden";
            // 
            // tableListBox
            // 
            this.tableListBox.AllowDrop = true;
            this.tableListBox.FormattingEnabled = true;
            this.tableListBox.ItemHeight = 20;
            this.tableListBox.Location = new System.Drawing.Point(13, 79);
            this.tableListBox.Name = "tableListBox";
            this.tableListBox.Size = new System.Drawing.Size(147, 164);
            this.tableListBox.TabIndex = 13;
            this.tableListBox.SelectedIndexChanged += new System.EventHandler(this.dataBaseListBox_SelectedIndexChanged);
            // 
            // newTableTextBox
            // 
            this.newTableTextBox.Location = new System.Drawing.Point(14, 276);
            this.newTableTextBox.MaxLength = 20;
            this.newTableTextBox.Name = "newTableTextBox";
            this.newTableTextBox.Size = new System.Drawing.Size(146, 27);
            this.newTableTextBox.TabIndex = 14;
            // 
            // addTableButton
            // 
            this.addTableButton.Location = new System.Drawing.Point(14, 309);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(146, 27);
            this.addTableButton.TabIndex = 15;
            this.addTableButton.Text = "Lägg till";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lägg till ny tabell";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Befintliga tabeller";
            // 
            // searchResultTextBox
            // 
            this.searchResultTextBox.Location = new System.Drawing.Point(736, 79);
            this.searchResultTextBox.Name = "searchResultTextBox";
            this.searchResultTextBox.ReadOnly = true;
            this.searchResultTextBox.Size = new System.Drawing.Size(233, 410);
            this.searchResultTextBox.TabIndex = 18;
            this.searchResultTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(225, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Personuppgifter";
            // 
            // searchTableButton
            // 
            this.searchTableButton.Enabled = false;
            this.searchTableButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTableButton.Location = new System.Drawing.Point(307, 246);
            this.searchTableButton.Name = "searchTableButton";
            this.searchTableButton.Size = new System.Drawing.Size(99, 27);
            this.searchTableButton.TabIndex = 20;
            this.searchTableButton.Text = "Sök i tabell";
            this.searchTableButton.UseVisualStyleBackColor = true;
            this.searchTableButton.Click += new System.EventHandler(this.searchTableButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(736, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sökresultat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(549, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "ID från sökning";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // deleteIDButton
            // 
            this.deleteIDButton.Enabled = false;
            this.deleteIDButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteIDButton.ForeColor = System.Drawing.Color.Red;
            this.deleteIDButton.Location = new System.Drawing.Point(549, 345);
            this.deleteIDButton.Name = "deleteIDButton";
            this.deleteIDButton.Size = new System.Drawing.Size(167, 27);
            this.deleteIDButton.TabIndex = 24;
            this.deleteIDButton.Text = "Radera vald ID";
            this.deleteIDButton.UseVisualStyleBackColor = true;
            this.deleteIDButton.Click += new System.EventHandler(this.deleteIDButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(177, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Du arbetar med följande tabell:";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tableLabel.ForeColor = System.Drawing.Color.Gray;
            this.tableLabel.Location = new System.Drawing.Point(177, 311);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(82, 32);
            this.tableLabel.TabIndex = 28;
            this.tableLabel.Text = "Ej vald";
            this.tableLabel.TextChanged += new System.EventHandler(this.tableLabel_TextChanged);
            this.tableLabel.Click += new System.EventHandler(this.tableLabel_Click);
            // 
            // deleteTableButton
            // 
            this.deleteTableButton.Enabled = false;
            this.deleteTableButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteTableButton.ForeColor = System.Drawing.Color.Red;
            this.deleteTableButton.Location = new System.Drawing.Point(13, 345);
            this.deleteTableButton.Name = "deleteTableButton";
            this.deleteTableButton.Size = new System.Drawing.Size(147, 27);
            this.deleteTableButton.TabIndex = 29;
            this.deleteTableButton.Text = "Radera vald tabell";
            this.deleteTableButton.UseVisualStyleBackColor = true;
            this.deleteTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // idListBox
            // 
            this.idListBox.FormattingEnabled = true;
            this.idListBox.ItemHeight = 20;
            this.idListBox.Location = new System.Drawing.Point(549, 81);
            this.idListBox.Name = "idListBox";
            this.idListBox.Size = new System.Drawing.Size(167, 224);
            this.idListBox.TabIndex = 30;
            this.idListBox.SelectedIndexChanged += new System.EventHandler(this.idListBox_SelectedIndexChanged);
            // 
            // importIDButton
            // 
            this.importIDButton.Enabled = false;
            this.importIDButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importIDButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.importIDButton.Location = new System.Drawing.Point(549, 311);
            this.importIDButton.Name = "importIDButton";
            this.importIDButton.Size = new System.Drawing.Size(167, 27);
            this.importIDButton.TabIndex = 32;
            this.importIDButton.Text = "Uppdatera befintlig";
            this.importIDButton.UseVisualStyleBackColor = true;
            this.importIDButton.Click += new System.EventHandler(this.importIDButton_Click);
            // 
            // emptyFieldsButton
            // 
            this.emptyFieldsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emptyFieldsButton.Location = new System.Drawing.Point(225, 245);
            this.emptyFieldsButton.Name = "emptyFieldsButton";
            this.emptyFieldsButton.Size = new System.Drawing.Size(77, 27);
            this.emptyFieldsButton.TabIndex = 33;
            this.emptyFieldsButton.Text = "Nollställ";
            this.emptyFieldsButton.UseVisualStyleBackColor = true;
            this.emptyFieldsButton.Click += new System.EventHandler(this.emptyFieldsButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inställningarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 28);
            // 
            // inställningarToolStripMenuItem
            // 
            this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
            this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.inställningarToolStripMenuItem.Text = "Inställningar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(10, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Sökväg till SQLEXPRESS:";
            // 
            // sqlDirTextBox
            // 
            this.sqlDirTextBox.Enabled = false;
            this.sqlDirTextBox.Location = new System.Drawing.Point(184, 12);
            this.sqlDirTextBox.Name = "sqlDirTextBox";
            this.sqlDirTextBox.Size = new System.Drawing.Size(342, 27);
            this.sqlDirTextBox.TabIndex = 35;
            this.sqlDirTextBox.Text = "C:\\\\Program Files\\\\Microsoft SQL Server";
            this.sqlDirTextBox.TextChanged += new System.EventHandler(this.sqlDirTextBox_TextChanged);
            // 
            // changeDirButton
            // 
            this.changeDirButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeDirButton.Location = new System.Drawing.Point(549, 12);
            this.changeDirButton.Name = "changeDirButton";
            this.changeDirButton.Size = new System.Drawing.Size(77, 27);
            this.changeDirButton.TabIndex = 36;
            this.changeDirButton.Text = "Ändra";
            this.changeDirButton.UseVisualStyleBackColor = true;
            this.changeDirButton.Click += new System.EventHandler(this.changeDirButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 522);
            this.Controls.Add(this.changeDirButton);
            this.Controls.Add(this.sqlDirTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.emptyFieldsButton);
            this.Controls.Add(this.importIDButton);
            this.Controls.Add(this.idListBox);
            this.Controls.Add(this.deleteTableButton);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deleteIDButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchTableButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchResultTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.newTableTextBox);
            this.Controls.Add(this.tableListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Persondatabaser";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private Button submitButton;
        private Label label1;
        private Label label2;
        private TextBox addressTextBox;
        private Label label3;
        private TextBox postalCodeTextBox;
        private Label label4;
        private TextBox phoneTextBox;
        private TextBox cityTextBox;
        private Label label5;
        private RichTextBox messageBox;
        private Label label6;
        private ListBox tableListBox;
        private TextBox newTableTextBox;
        private Button addTableButton;
        private Label label7;
        private Label label8;
        private RichTextBox searchResultTextBox;
        private Label label9;
        private Button searchTableButton;
        private Label label10;
        private Label label11;
        private Button deleteIDButton;
        private Label label12;
        private Label tableLabel;
        private Button deleteTableButton;
        private ListBox idListBox;
        private Button importIDButton;
        private Button emptyFieldsButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem inställningarToolStripMenuItem;
        private Label label13;
        private TextBox sqlDirTextBox;
        private Button changeDirButton;
    }
}