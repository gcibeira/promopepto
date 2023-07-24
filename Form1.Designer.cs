namespace promopepto
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
            buttonAdd = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            buttonEdit = new Button();
            buttonDelete = new Button();
            progressBarCredits = new ProgressBar();
            buttonReset = new Button();
            buttonDecrement = new Button();
            buttonIncrement = new Button();
            labelCredits = new Label();
            labelName = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            labelCount = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(14, 585);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(519, 49);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Nuovo Cliente";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(77, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 34);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(progressBarCredits);
            groupBox1.Controls.Add(buttonReset);
            groupBox1.Controls.Add(buttonDecrement);
            groupBox1.Controls.Add(buttonIncrement);
            groupBox1.Controls.Add(labelCredits);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(539, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 615);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEdit.Location = new Point(7, 516);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(338, 44);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Modifica Cliente";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDelete.Location = new Point(7, 566);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(338, 44);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Cancella Cliente";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // progressBarCredits
            // 
            progressBarCredits.Location = new Point(7, 135);
            progressBarCredits.Name = "progressBarCredits";
            progressBarCredits.Size = new Size(338, 41);
            progressBarCredits.Step = 1;
            progressBarCredits.Style = ProgressBarStyle.Continuous;
            progressBarCredits.TabIndex = 7;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonReset.Location = new Point(7, 384);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(338, 105);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonDecrement
            // 
            buttonDecrement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDecrement.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecrement.Location = new Point(7, 273);
            buttonDecrement.Name = "buttonDecrement";
            buttonDecrement.Size = new Size(166, 105);
            buttonDecrement.TabIndex = 0;
            buttonDecrement.Text = "-";
            buttonDecrement.UseVisualStyleBackColor = true;
            buttonDecrement.Click += buttonDecrement_Click;
            // 
            // buttonIncrement
            // 
            buttonIncrement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonIncrement.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIncrement.Location = new Point(178, 273);
            buttonIncrement.Name = "buttonIncrement";
            buttonIncrement.Size = new Size(166, 105);
            buttonIncrement.TabIndex = 1;
            buttonIncrement.Text = "+";
            buttonIncrement.UseVisualStyleBackColor = true;
            buttonIncrement.Click += buttonIncrement_Click;
            // 
            // labelCredits
            // 
            labelCredits.AutoSize = true;
            labelCredits.Location = new Point(72, 92);
            labelCredits.Name = "labelCredits";
            labelCredits.Size = new Size(39, 28);
            labelCredits.TabIndex = 3;
            labelCredits.Text = "xxx";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(72, 52);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 28);
            labelName.TabIndex = 2;
            labelName.Text = "xxx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 92);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 1;
            label3.Text = "Punti:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 52);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 71);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(519, 507);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCount.Location = new Point(375, 29);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(15, 20);
            labelCount.TabIndex = 9;
            labelCount.Text = "/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 10;
            label1.Text = "Filtro:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 645);
            Controls.Add(label1);
            Controls.Add(labelCount);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Pepto Promo Pizza";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdd;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button buttonReset;
        private Button buttonDecrement;
        private Button buttonIncrement;
        private Label labelCredits;
        private Label labelName;
        private Label label3;
        private Label label2;
        private ProgressBar progressBarCredits;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private Label labelCount;
        private Label label1;
        private Button buttonEdit;
    }
}