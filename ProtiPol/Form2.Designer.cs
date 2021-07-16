namespace ProtiPol
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poledníkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rovníkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poledníkDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rovníkDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protipolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protipolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mestoDataGridViewTextBoxColumn,
            this.poledníkDataGridViewTextBoxColumn,
            this.rovníkDataGridViewTextBoxColumn,
            this.poledníkDataDataGridViewTextBoxColumn,
            this.rovníkDataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.protipolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            // 
            // poledníkDataGridViewTextBoxColumn
            // 
            this.poledníkDataGridViewTextBoxColumn.DataPropertyName = "Poledník";
            this.poledníkDataGridViewTextBoxColumn.HeaderText = "Poledník";
            this.poledníkDataGridViewTextBoxColumn.Name = "poledníkDataGridViewTextBoxColumn";
            // 
            // rovníkDataGridViewTextBoxColumn
            // 
            this.rovníkDataGridViewTextBoxColumn.DataPropertyName = "Rovník";
            this.rovníkDataGridViewTextBoxColumn.HeaderText = "Rovník";
            this.rovníkDataGridViewTextBoxColumn.Name = "rovníkDataGridViewTextBoxColumn";
            // 
            // poledníkDataDataGridViewTextBoxColumn
            // 
            this.poledníkDataDataGridViewTextBoxColumn.DataPropertyName = "PoledníkData";
            this.poledníkDataDataGridViewTextBoxColumn.HeaderText = "PoledníkData";
            this.poledníkDataDataGridViewTextBoxColumn.Name = "poledníkDataDataGridViewTextBoxColumn";
            // 
            // rovníkDataDataGridViewTextBoxColumn
            // 
            this.rovníkDataDataGridViewTextBoxColumn.DataPropertyName = "RovníkData";
            this.rovníkDataDataGridViewTextBoxColumn.HeaderText = "RovníkData";
            this.rovníkDataDataGridViewTextBoxColumn.Name = "rovníkDataDataGridViewTextBoxColumn";
            // 
            // protipolBindingSource
            // 
            this.protipolBindingSource.DataSource = typeof(ProtiPol.Protipol);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odstranit záznam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protipolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poledníkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rovníkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poledníkDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rovníkDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource protipolBindingSource;
        private System.Windows.Forms.Button button2;
    }
}