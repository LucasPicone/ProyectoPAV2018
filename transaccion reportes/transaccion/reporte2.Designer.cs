namespace transaccion
{
    partial class reporte2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BUGSDataSet = new transaccion.BUGSDataSet();
            this.BugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BugsTableAdapter = new transaccion.BUGSDataSetTableAdapters.BugsTableAdapter();
            this.cmdBotoncito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BUGSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BugsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "transaccion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(874, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // BUGSDataSet
            // 
            this.BUGSDataSet.DataSetName = "BUGSDataSet";
            this.BUGSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BugsBindingSource
            // 
            this.BugsBindingSource.DataMember = "Bugs";
            this.BugsBindingSource.DataSource = this.BUGSDataSet;
            // 
            // BugsTableAdapter
            // 
            this.BugsTableAdapter.ClearBeforeFill = true;
            // 
            // cmdBotoncito
            // 
            this.cmdBotoncito.Location = new System.Drawing.Point(129, 7);
            this.cmdBotoncito.Name = "cmdBotoncito";
            this.cmdBotoncito.Size = new System.Drawing.Size(75, 23);
            this.cmdBotoncito.TabIndex = 1;
            this.cmdBotoncito.Text = "botoncito";
            this.cmdBotoncito.UseVisualStyleBackColor = true;
            this.cmdBotoncito.Click += new System.EventHandler(this.cmdBotoncito_Click);
            // 
            // reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 523);
            this.Controls.Add(this.cmdBotoncito);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporte2";
            this.Text = "reporte2";
            this.Load += new System.EventHandler(this.reporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BUGSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BugsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BugsBindingSource;
        private BUGSDataSet BUGSDataSet;
        private BUGSDataSetTableAdapters.BugsTableAdapter BugsTableAdapter;
        private System.Windows.Forms.Button cmdBotoncito;
    }
}