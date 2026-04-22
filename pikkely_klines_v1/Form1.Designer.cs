namespace pikkely_klines_v1
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
            btnTestConnection = new Button();
            lblResult = new Label();
            txtRawData = new TextBox();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(12, 12);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(302, 46);
            btnTestConnection.TabIndex = 0;
            btnTestConnection.Text = "kapcsolat tesztelése";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 61);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(230, 32);
            lblResult.TabIndex = 1;
            lblResult.Text = "Várakozás a tesztre...";
            // 
            // txtRawData
            // 
            txtRawData.Location = new Point(12, 96);
            txtRawData.Multiline = true;
            txtRawData.Name = "txtRawData";
            txtRawData.ScrollBars = ScrollBars.Vertical;
            txtRawData.Size = new Size(733, 268);
            txtRawData.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 370);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.Size = new Size(1648, 757);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 1139);
            Controls.Add(dgvProducts);
            Controls.Add(txtRawData);
            Controls.Add(lblResult);
            Controls.Add(btnTestConnection);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestConnection;
        private Label lblResult;
        private TextBox txtRawData;
        private DataGridView dgvProducts;
    }
}
