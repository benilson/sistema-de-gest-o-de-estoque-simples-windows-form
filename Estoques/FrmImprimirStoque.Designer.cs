﻿namespace Estoques
{
    partial class FrmImprimirStoque
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProdutosEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutosEstoqueBindingSource
            // 
            this.ProdutosEstoqueBindingSource.DataSource = typeof(Estoques.ProdutosEstoque);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "produtosEstoque";
            reportDataSource2.Value = this.ProdutosEstoqueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Estoques.stoqueProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(551, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmImprimirStoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 580);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmImprimirStoque";
            this.Text = ":: Imprimir Stoque ::";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmImprimirStoque_FormClosed);
            this.Load += new System.EventHandler(this.FrmImprimirStoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutosEstoqueBindingSource;
    }
}