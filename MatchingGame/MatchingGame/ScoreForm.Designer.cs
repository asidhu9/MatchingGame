namespace MatchingGame
{
    partial class ScoreForm
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
            this.initialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreDbDataSet = new MatchingGame.ScoreDbDataSet();
            this.scoreDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highScoreTableAdapter = new MatchingGame.ScoreDbDataSetTableAdapters.HighScoreTableAdapter();
            this.returnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.initialsDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.highScoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(259, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // initialsDataGridViewTextBoxColumn
            // 
            this.initialsDataGridViewTextBoxColumn.DataPropertyName = "Initials";
            this.initialsDataGridViewTextBoxColumn.HeaderText = "Initials";
            this.initialsDataGridViewTextBoxColumn.Name = "initialsDataGridViewTextBoxColumn";
            this.initialsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // highScoreBindingSource
            // 
            this.highScoreBindingSource.DataMember = "HighScore";
            this.highScoreBindingSource.DataSource = this.scoreDbDataSet;
            // 
            // scoreDbDataSet
            // 
            this.scoreDbDataSet.DataSetName = "ScoreDbDataSet";
            this.scoreDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreDbDataSetBindingSource
            // 
            this.scoreDbDataSetBindingSource.DataSource = this.scoreDbDataSet;
            this.scoreDbDataSetBindingSource.Position = 0;
            // 
            // highScoreTableAdapter
            // 
            this.highScoreTableAdapter.ClearBeforeFill = true;
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(103, 227);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 23);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource scoreDbDataSetBindingSource;
        private ScoreDbDataSet scoreDbDataSet;
        private System.Windows.Forms.BindingSource highScoreBindingSource;
        private ScoreDbDataSetTableAdapters.HighScoreTableAdapter highScoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button returnBtn;
    }
}